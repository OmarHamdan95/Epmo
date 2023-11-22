using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record AddExampleHandler : IRequestHandler<AddExampleRequest, Result<long>>
{
    private readonly IExampleRepository _exampleRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddExampleHandler
    (
        IExampleRepository exampleRepository,
        IUnitOfWork unitOfWork
    )
    {
        _exampleRepository = exampleRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<long>> Handle(AddExampleRequest request ,CancellationToken cancellationToken)
    {
        var entity = new Example(request.Name);

        await _exampleRepository.AddAsync(entity);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, entity.Id);
    }


}
