namespace Epmo.Application;

public sealed record ListUserRequest : IRequest<Result<IEnumerable<UserModel>>>;
