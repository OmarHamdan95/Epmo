

namespace Epmo.Database;

public interface IAttachmentRepository : IRepository<AttachmentGroup>
{
    Task<AttachemntGroupModel> GetModelAsync(long id);

    Task<Grid<AttachemntGroupModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<AttachemntGroupModel>> ListModelAsync();
}
