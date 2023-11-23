using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record ListExampleHandler : IRequestHandler<ListExampleRequest, Result<IEnumerable<ExampleModel>>>
{
    private readonly IExampleRepository _exampleRepository;

    public ListExampleHandler(IExampleRepository exampleRepository) => _exampleRepository = exampleRepository;

    public async Task<Result<IEnumerable<ExampleModel>>> Handle(ListExampleRequest request , CancellationToken cancellationToken)
    {
        var list = await _exampleRepository.ListModelAsync();

        return new Result<IEnumerable<ExampleModel>>(list is null ? NotFound : OK, list);
    }
}
