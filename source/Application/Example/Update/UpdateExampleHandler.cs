using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record UpdateExampleHandler : IRequestHandler<UpdateExampleRequest , Result>
{
    private readonly IExampleRepository _exampleRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateExampleHandler
    (
        IExampleRepository exampleRepository,
        IUnitOfWork unitOfWork
    )
    {
        _exampleRepository = exampleRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(UpdateExampleRequest request , CancellationToken cancellationToken)
    {
        var entity = new Example(request.Id, request.Name);

        await _exampleRepository.UpdateAsync(entity);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
