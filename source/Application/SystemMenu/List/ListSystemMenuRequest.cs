using Architecture.Model.Lookup;
using Architecture.Model.SystemMenu;

namespace Architecture.Application;

public sealed record ListSystemMenuRequest : IRequest<Result<IEnumerable<SystemMenuModel>>>;
