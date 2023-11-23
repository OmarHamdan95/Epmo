namespace Epmo.Application;

public sealed record GridUserRequest : GridParameters , IRequest<Result<Grid<UserModel>>>;
