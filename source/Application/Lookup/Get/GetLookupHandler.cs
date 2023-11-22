using Architecture.Model.Lookup;
using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record GetLookupHandler : IRequestHandler<GetLookupRequest, Result<LookupModel>>
{
    private readonly ILookupRepository _lookupRepository;

    public GetLookupHandler(ILookupRepository lookupRepository) => _lookupRepository = lookupRepository;

    public async Task<Result<LookupModel>> Handle(GetLookupRequest request , CancellationToken cancellationToken)
    {
        var lookup = await _lookupRepository.GetModelAsync(request.Id);

        return new Result<LookupModel>(lookup is null ? NotFound : OK, lookup);
    }
}
