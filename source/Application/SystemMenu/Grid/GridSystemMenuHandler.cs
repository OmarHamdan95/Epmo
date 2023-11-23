using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GridSystemMenuHandler : IRequestHandler<GridSystemMenuRequest, Result<Grid<SystemMenuModel>>>
{
    private readonly ISystemMenuRepository _systemMenuRepository;

    public GridSystemMenuHandler(ISystemMenuRepository systemMenuRepository) => _systemMenuRepository = systemMenuRepository;

    public async Task<Result<Grid<SystemMenuModel>>> Handle(GridSystemMenuRequest request , CancellationToken cancellationToken)
    {
        var grid = await _systemMenuRepository.GridAsync(request);

        return new Result<Grid<SystemMenuModel>>(grid is null ? NotFound : OK, grid);
    }

}
