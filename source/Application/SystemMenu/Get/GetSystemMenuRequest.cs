namespace Epmo.Application;

public sealed record GetSystemMenuRequest(long Id) : IRequest<Result<SystemMenuModel>>;
