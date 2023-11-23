using Mapster;
namespace Epmo.Application;
using static System.Net.HttpStatusCode;

public sealed record AddLookupHandler : IRequestHandler<AddLookupRequest, Result<long>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILookupRepository _lookupRepository;


    public AddLookupHandler
    (
        IUnitOfWork unitOfWork,
        ILookupRepository lookupRepository
    )
    {
        _unitOfWork = unitOfWork;
        _lookupRepository = lookupRepository;
    }

    public async Task<Result<long>> Handle(AddLookupRequest request , CancellationToken cancellationToken)
    {

        var lookup = new Lookup(request.LookupCode, request.TranslationModel.Adapt<Translation>() ,
            request.LookupValueModels.Adapt<List<LookupValue>>(),request.dataType,request.parent.Adapt<Lookup>());

        await _lookupRepository.AddAsync(lookup);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, lookup.Id);
       // throw new NotImplementedException();
    }
}
