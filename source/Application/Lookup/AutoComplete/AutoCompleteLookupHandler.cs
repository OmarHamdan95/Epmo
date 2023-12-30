using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record AutoCompleteLookupHandler : IRequestHandler<AutoCompleteLookupRequest, Result<IEnumerable<LookupValueModel>>>
{
    private readonly ILookupValueRepository _lookupRepository;

    public AutoCompleteLookupHandler(ILookupValueRepository lookupRepository) => _lookupRepository = lookupRepository;

    public async Task<Result<IEnumerable<LookupValueModel>>> Handle(AutoCompleteLookupRequest request , CancellationToken cancellationToken)
    {
        var lookup = await _lookupRepository.AutoComplate<LookupValueModel>(request.lookupCode , request.text);

        return new Result<IEnumerable<LookupValueModel>>(lookup is null ? NotFound : OK, lookup);
    }
}
