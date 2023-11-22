namespace Architecture.Application;

public sealed record GridExampleRequest : GridParameters , IRequest<Result<Grid<ExampleModel>>>;
