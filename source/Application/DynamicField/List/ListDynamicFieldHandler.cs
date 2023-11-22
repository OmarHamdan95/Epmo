using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record ListDynamicFieldHandler : IRequestHandler<ListDynamicFieldRequest, Result<IEnumerable<DynamicFieldModel>>>
{
    private readonly IDynamicFieldRepository _dynamicFieldRepository;

    public ListDynamicFieldHandler(IDynamicFieldRepository dynamicFieldRepository) => _dynamicFieldRepository = dynamicFieldRepository;

    public async Task<Result<IEnumerable<DynamicFieldModel>>> Handle(ListDynamicFieldRequest request , CancellationToken cancellationToken)
    {
        var lookups = await _dynamicFieldRepository.ListModelAsync();

        return new Result<IEnumerable<DynamicFieldModel>>(lookups is null ? NotFound : OK, lookups);
    }
}
