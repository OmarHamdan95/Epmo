using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record ListDynamicFieldHandler : IRequestHandler<ListDynamicFieldRequest, Result<IEnumerable<DynamicFieldModel>>>
{
    private readonly IRepositoryBase<DynamicField> _dynamicFieldRepository;

    public ListDynamicFieldHandler(IRepositoryBase<DynamicField> dynamicFieldRepository) => _dynamicFieldRepository = dynamicFieldRepository;

    public async Task<Result<IEnumerable<DynamicFieldModel>>> Handle(ListDynamicFieldRequest request , CancellationToken cancellationToken)
    {
        var lookups = await _dynamicFieldRepository.ListModelAsync<DynamicFieldModel>();

        return new Result<IEnumerable<DynamicFieldModel>>(lookups is null ? NotFound : OK, lookups);
    }
}
