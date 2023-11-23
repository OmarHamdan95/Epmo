using Architecture.Model.SystemMenu;
using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record GetSystemMenuHandler : IRequestHandler<GetSystemMenuRequest, Result<SystemMenuModel>>
{
    private readonly ISystemMenuRepository _systemMenuRepository;

    public GetSystemMenuHandler(ISystemMenuRepository systemMenuRepository) => _systemMenuRepository = systemMenuRepository;

    public async Task<Result<SystemMenuModel>> Handle(GetSystemMenuRequest request , CancellationToken cancellationToken)
    {
        var systemMenu = await _systemMenuRepository.GetModelAsync(request.Id);

        return new Result<SystemMenuModel>(systemMenu is null ? NotFound : OK, systemMenu);
    }
}
