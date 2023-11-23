namespace Epmo.Application;

public sealed record GridExampleRequest : GridParameters , IRequest<Result<Grid<ExampleModel>>>;
