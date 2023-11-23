namespace Epmo.Application;

public sealed record GridSystemMenuRequest : GridParameters , IRequest<Result<Grid<SystemMenuModel>>>;
