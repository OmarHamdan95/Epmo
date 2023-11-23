using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record DeleteDynamicFieldHandler : IRequestHandler<DeleteDynamicFieldRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDynamicFieldRepository _dynamicFieldRepository;

    public DeleteDynamicFieldHandler
    (
        IUnitOfWork unitOfWork,
        IDynamicFieldRepository dynamicFieldRepository
    )
    {
        _unitOfWork = unitOfWork;
        _dynamicFieldRepository = dynamicFieldRepository;
    }

    public async Task<Result> Handle(DeleteDynamicFieldRequest request , CancellationToken cancellationToken)
    {

        await _dynamicFieldRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
