using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record DeleteAttachmenHandler : IRequestHandler<DeleteAttachmenRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAttachmentRepository _attachmentRepository;

    public DeleteAttachmenHandler
    (
        IUnitOfWork unitOfWork,
        IAttachmentRepository attachmentRepository
    )
    {
        _unitOfWork = unitOfWork;
        _attachmentRepository = attachmentRepository;
    }

    public async Task<Result> Handle(DeleteAttachmenRequest request , CancellationToken cancellationToken)
    {

        await _attachmentRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
