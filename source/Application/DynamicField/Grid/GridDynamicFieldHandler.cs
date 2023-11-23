using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GridDynamicFieldHandler : IRequestHandler<GridDynamicFieldRequest, Result<Grid<DynamicFieldModel>>>
{
    private readonly IDynamicFieldRepository _dynamicFieldRepository;

    public GridDynamicFieldHandler(IDynamicFieldRepository dynamicFieldRepository) => _dynamicFieldRepository = dynamicFieldRepository;

    public async Task<Result<Grid<DynamicFieldModel>>> Handle(GridDynamicFieldRequest request , CancellationToken cancellationToken)
    {
        var grid = await _dynamicFieldRepository.GridAsync(request);

        return new Result<Grid<DynamicFieldModel>>(grid is null ? NotFound : OK, grid);
    }

}
