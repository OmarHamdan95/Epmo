using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record ListAttachmenHandler : IRequestHandler<ListAttachmenRequest, Result<IEnumerable<AttachemntGroupModel>>>
{
    private readonly IAttachmentRepository _attachmentRepository;

    public ListAttachmenHandler(IAttachmentRepository attachmentRepository) => _attachmentRepository = attachmentRepository;

    public async Task<Result<IEnumerable<AttachemntGroupModel>>> Handle(ListAttachmenRequest request , CancellationToken cancellationToken)
    {
        var attachemntGroups = await _attachmentRepository.ListModelAsync();

        return new Result<IEnumerable<AttachemntGroupModel>>(attachemntGroups is null ? NotFound : OK, attachemntGroups);
    }
}
