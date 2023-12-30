using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GetDynamicFieldHandler : IRequestHandler<GetDynamicFieldRequest, Result<DynamicFieldModel>>
{
    private readonly IRepositoryBase<DynamicField> _dynamicFieldRepository;

    public GetDynamicFieldHandler(IRepositoryBase<DynamicField> dynamicFieldRepository) => _dynamicFieldRepository = dynamicFieldRepository;

    public async Task<Result<DynamicFieldModel>> Handle(GetDynamicFieldRequest request , CancellationToken cancellationToken)
    {
        var lookup = await _dynamicFieldRepository.GetModelAsync<DynamicFieldModel>(request.Id);

        return new Result<DynamicFieldModel>(lookup is null ? NotFound : OK, lookup);
    }
}
