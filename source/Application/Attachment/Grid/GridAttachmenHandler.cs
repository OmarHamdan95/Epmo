using Architecture.Model.Lookup;
using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record GridAttachmenHandler : IRequestHandler<GridAttachmenRequest, Result<Grid<AttachemntGroupModel>>>
{
    private readonly IAttachmentRepository _attachmentRepository;

    public GridAttachmenHandler(IAttachmentRepository attachmentRepository) => _attachmentRepository = attachmentRepository;

    public async Task<Result<Grid<AttachemntGroupModel>>> Handle(GridAttachmenRequest request , CancellationToken cancellationToken)
    {
        var grid = await _attachmentRepository.GridAsync(request);

        return new Result<Grid<AttachemntGroupModel>>(grid is null ? NotFound : OK, grid);
    }

}
