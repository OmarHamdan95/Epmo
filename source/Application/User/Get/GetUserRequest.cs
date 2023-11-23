namespace Epmo.Application;

public sealed record GetUserRequest(long Id) : IRequest<Result<UserModel>>;
