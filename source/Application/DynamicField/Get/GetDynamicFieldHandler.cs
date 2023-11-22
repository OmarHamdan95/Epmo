using Architecture.Model.Lookup;
using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record GetDynamicFieldHandler : IRequestHandler<GetDynamicFieldRequest, Result<DynamicFieldModel>>
{
    private readonly IDynamicFieldRepository _dynamicFieldRepository;

    public GetDynamicFieldHandler(IDynamicFieldRepository dynamicFieldRepository) => _dynamicFieldRepository = dynamicFieldRepository;

    public async Task<Result<DynamicFieldModel>> Handle(GetDynamicFieldRequest request , CancellationToken cancellationToken)
    {
        var lookup = await _dynamicFieldRepository.GetModelAsync(request.Id);

        return new Result<DynamicFieldModel>(lookup is null ? NotFound : OK, lookup);
    }
}
