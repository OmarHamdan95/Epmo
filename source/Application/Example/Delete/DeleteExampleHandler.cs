using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record DeleteExampleHandler : IRequestHandler<DeleteExampleRequest , Result>
{
    private readonly IExampleRepository _exampleRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteExampleHandler
    (
        IExampleRepository exampleRepository,
        IUnitOfWork unitOfWork
    )
    {
        _exampleRepository = exampleRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(DeleteExampleRequest request ,CancellationToken cancellationToken)
    {
        await _exampleRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
