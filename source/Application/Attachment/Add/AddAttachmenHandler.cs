namespace Epmo.Application;
using static System.Net.HttpStatusCode;

public sealed record AddAttachmenHandler : IRequestHandler<AddAttachmenRequest, Result<long>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAttachmentRepository _attachmentRepository;
    public AddAttachmenHandler
    (
        IUnitOfWork unitOfWork,
        IAttachmentRepository attachmentRepository
    )
    {
        _unitOfWork = unitOfWork;
        _attachmentRepository = attachmentRepository;
    }

    public async Task<Result<long>> Handle(AddAttachmenRequest request , CancellationToken cancellationToken)
    {

        var attachemntGroup = new AttachmentGroup(request.Attachments.Adapt<List<Attachment>>());

        await _attachmentRepository.AddAsync(attachemntGroup);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, attachemntGroup.Id);
       // throw new NotImplementedException();
    }
}
