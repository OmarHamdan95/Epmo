using Architecture.Model.SystemMenu;

namespace Architecture.Application;

public sealed record GridSystemMenuRequest : GridParameters , IRequest<Result<Grid<SystemMenuModel>>>;
