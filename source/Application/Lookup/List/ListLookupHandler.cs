using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record ListLookupHandler : IRequestHandler<ListLookupRequest, Result<IEnumerable<LookupModel>>>
{
    private readonly ILookupRepository _lookupRepository;

    public ListLookupHandler(ILookupRepository lookupRepository) => _lookupRepository = lookupRepository;

    public async Task<Result<IEnumerable<LookupModel>>> Handle(ListLookupRequest request , CancellationToken cancellationToken)
    {
        var lookups = await _lookupRepository.ListModelAsync();

        return new Result<IEnumerable<LookupModel>>(lookups is null ? NotFound : OK, lookups);
    }
}
