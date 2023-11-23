namespace Epmo.Application;

public sealed record ListSystemMenuRequest : IRequest<Result<IEnumerable<SystemMenuModel>>>;
