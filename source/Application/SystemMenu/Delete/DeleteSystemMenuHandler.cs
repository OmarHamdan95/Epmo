using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record DeleteSystemMenuHandler : IRequestHandler<DeleteSystemMenuRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISystemMenuRepository _systemMenuRepository;

    public DeleteSystemMenuHandler
    (
        IUnitOfWork unitOfWork,
        ISystemMenuRepository systemMenuRepository
    )
    {
        _unitOfWork = unitOfWork;
        _systemMenuRepository = systemMenuRepository;
    }

    public async Task<Result> Handle(DeleteSystemMenuRequest request , CancellationToken cancellationToken)
    {

        await _systemMenuRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
