using Mapster;
using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record UpdateAttachmenHandler : IRequestHandler<UpdateAttachmenRequest, Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAttachmentRepository _attachmentRepository;

    public UpdateAttachmenHandler
    (
        IUnitOfWork unitOfWork,
        IAttachmentRepository attachmentRepository
    )
    {
        _unitOfWork = unitOfWork;
        _attachmentRepository = attachmentRepository;
    }

    public async Task<Result> Handle(UpdateAttachmenRequest request , CancellationToken cancellationToken)
    {
        var attachmentGroup = await _attachmentRepository.GetAsync(request.Id);

        if (attachmentGroup is null) return new Result(NotFound);

        attachmentGroup.UpdateAttachment(request.AttachmentModels.Adapt<List<Attachment>>());

        await _attachmentRepository.UpdateAsync(attachmentGroup);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
