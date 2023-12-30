using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record DeleteDynamicFieldHandler : IRequestHandler<DeleteDynamicFieldRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<DynamicField> _dynamicFieldRepository;

    public DeleteDynamicFieldHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<DynamicField> dynamicFieldRepository
    )
    {
        _unitOfWork = unitOfWork;
        _dynamicFieldRepository = dynamicFieldRepository;
    }

    public async Task<Result> Handle(DeleteDynamicFieldRequest request , CancellationToken cancellationToken)
    {

        await _dynamicFieldRepository.DeleteEntityAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
