
using Architecture.Model.SystemMenu;

namespace Architecture.Application;

public sealed record GetSystemMenuRequest(long Id) : IRequest<Result<SystemMenuModel>>;
