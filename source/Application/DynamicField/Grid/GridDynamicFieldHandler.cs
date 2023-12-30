using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GridDynamicFieldHandler : IRequestHandler<GridDynamicFieldRequest, Result<Grid<DynamicFieldModel>>>
{
    private readonly IRepositoryBase<DynamicField> _dynamicFieldRepository;

    public GridDynamicFieldHandler(IRepositoryBase<DynamicField> dynamicFieldRepository) => _dynamicFieldRepository = dynamicFieldRepository;

    public async Task<Result<Grid<DynamicFieldModel>>> Handle(GridDynamicFieldRequest request , CancellationToken cancellationToken)
    {
        var grid = await _dynamicFieldRepository.GridAsync<DynamicFieldModel>(request);

        return new Result<Grid<DynamicFieldModel>>(grid is null ? NotFound : OK, grid);
    }

}
