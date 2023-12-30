using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record ListSystemMenuHandler : IRequestHandler<ListSystemMenuRequest, Result<IEnumerable<SystemMenuModel>>>
{
    private readonly IRepositoryBase<SystemMenu> _systemMenuRepository;

    public ListSystemMenuHandler(IRepositoryBase<SystemMenu> systemMenuRepository) => _systemMenuRepository = systemMenuRepository;

    public async Task<Result<IEnumerable<SystemMenuModel>>> Handle(ListSystemMenuRequest request , CancellationToken cancellationToken)
    {
        var systemMenus = await _systemMenuRepository.ListModelAsync<SystemMenuModel>();

        return new Result<IEnumerable<SystemMenuModel>>(systemMenus is null ? NotFound : OK, systemMenus);
    }
}
