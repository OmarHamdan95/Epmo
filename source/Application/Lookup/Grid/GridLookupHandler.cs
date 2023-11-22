using Architecture.Model.Lookup;
using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record GridLookupHandler : IRequestHandler<GridLookupRequest, Result<Grid<LookupModel>>>
{
    private readonly ILookupRepository _lookupRepository;

    public GridLookupHandler(ILookupRepository lookupRepository) => _lookupRepository = lookupRepository;

    public async Task<Result<Grid<LookupModel>>> Handle(GridLookupRequest request , CancellationToken cancellationToken)
    {
        var grid = await _lookupRepository.GridAsync(request);

        return new Result<Grid<LookupModel>>(grid is null ? NotFound : OK, grid);
    }

}
