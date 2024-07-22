using Epmo.Domain.Common;
using Mapster;

namespace Epmo.Application;

using static System.Net.HttpStatusCode;

public sealed record AddLookupHandler : IRequestHandler<AddLookupRequest, Result<long>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<Lookup> _lookupRepository;

    public AddLookupHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<Lookup> lookupRepository
    )
    {
        _unitOfWork = unitOfWork;
        _lookupRepository = lookupRepository;
    }

    public async Task<Result<long>> Handle(AddLookupRequest request, CancellationToken cancellationToken)
    {
        var lookup = new Lookup(request.Code,
           request.TranslationModel.Adapt<LocalizedText>(),
            request.dataType,
            request.parent?.Id ?? null);

        if (request.LookupValueModels.Any())
        {
            foreach (var value in request.LookupValueModels)
            {
                lookup.AddLookupValue(new
                    LookupValue(value.Code , value.Order, value.Color,
                        value.Translation.Adapt<LocalizedText>(),
                        value.Parent?.Id ?? null));
            }
        }

        await _lookupRepository.AddAsync(lookup);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, lookup.Id);
        // throw new NotImplementedException();
    }
}
