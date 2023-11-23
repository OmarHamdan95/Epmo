using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GetAttachmenHandler : IRequestHandler<GetAttachmenRequest, Result<AttachemntGroupModel>>
{
    private readonly IAttachmentRepository _attachmentRepository;

    public GetAttachmenHandler(IAttachmentRepository attachmentRepository) => _attachmentRepository = attachmentRepository;

    public async Task<Result<AttachemntGroupModel>> Handle(GetAttachmenRequest request , CancellationToken cancellationToken)
    {
        var attachemntGroup = await _attachmentRepository.GetModelAsync(request.Id);

        return new Result<AttachemntGroupModel>(attachemntGroup is null ? NotFound : OK, attachemntGroup);
    }
}
