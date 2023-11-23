using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GetExampleHandler : IRequestHandler<GetExampleRequest, Result<ExampleModel>>
{
    private readonly IExampleRepository _exampleRepository;

    public GetExampleHandler(IExampleRepository exampleRepository) => _exampleRepository = exampleRepository;

    public async Task<Result<ExampleModel>> Handle(GetExampleRequest request , CancellationToken cancellationToken)
    {
        var model = await _exampleRepository.GetModelAsync(request.Id);

        return new Result<ExampleModel>(model is null ? NotFound : OK, model);
    }
}
