using Mapster;
using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record UpdateLookupHandler : IRequestHandler<UpdateLookupRequest, Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<Lookup> _lookupRepository;

    public UpdateLookupHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<Lookup> lookupRepository
    )
    {
        _unitOfWork = unitOfWork;
        _lookupRepository = lookupRepository;
    }

    public async Task<Result> Handle(UpdateLookupRequest request , CancellationToken cancellationToken)
    {
        var lookup = await _lookupRepository.GetAsync(request.Id);

        if (lookup is null) return new Result(NotFound);

        lookup.UpdateLookup(request.TranslationModel.Adapt<Translation>() , request.LookupValueModels.Adapt<List<LookupValue>>(),
            request.dataType,request.parent.Adapt<Lookup>());

        await _lookupRepository.UpdateAsync(lookup);

        // Call Audit Service (Old Value , New Value);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
