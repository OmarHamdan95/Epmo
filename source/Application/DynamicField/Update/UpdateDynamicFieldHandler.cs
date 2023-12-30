using Mapster;
using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record UpdateDynamicFieldHandler : IRequestHandler<UpdateDynamicFieldRequest, Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<DynamicField> _dynamicFieldRepository;

    public UpdateDynamicFieldHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<DynamicField> dynamicFieldRepository
    )
    {
        _unitOfWork = unitOfWork;
        _dynamicFieldRepository = dynamicFieldRepository;
    }

    public async Task<Result> Handle(UpdateDynamicFieldRequest request , CancellationToken cancellationToken)
    {
        var dynamicField = await _dynamicFieldRepository.GetAsync(request.Id);

        if (dynamicField is null) return new Result(NotFound);

        dynamicField.UpdateDynamicField(request.Name.Adapt<Translation>(), request.EntityType.Adapt<LookupValue>() ,
            request.DynamicFieldType.Adapt<LookupValue>(),request.DynamicFieldRegex,request.DynamicFieldMinValue ,request.DynamicFieldMaxValue,
            request.DynamicFieldLookupType.Adapt<LookupValue>());

        await _dynamicFieldRepository.UpdateAsync(dynamicField);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
