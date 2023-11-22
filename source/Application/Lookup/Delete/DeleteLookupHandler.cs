using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record DeleteLookupHandler : IRequestHandler<DeleteLookupRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILookupRepository _lookupRepository;

    public DeleteLookupHandler
    (
        IUnitOfWork unitOfWork,
        ILookupRepository lookupRepository
    )
    {
        _unitOfWork = unitOfWork;
        _lookupRepository = lookupRepository;
    }

    public async Task<Result> Handle(DeleteLookupRequest request , CancellationToken cancellationToken)
    {

        await _lookupRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
