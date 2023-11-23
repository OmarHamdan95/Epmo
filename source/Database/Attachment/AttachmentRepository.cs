using Mapster;

namespace Architecture.Database;

public sealed class AttachmentRepository : EFRepository<AttachmentGroup>, IAttachmentRepository
{
    public AttachmentRepository(Context context) : base(context)
    {
    }


    public Task<AttachemntGroupModel> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).ProjectToType<AttachemntGroupModel>().SingleOrDefaultAsync();

    public Task<Grid<AttachemntGroupModel>> GridAsync(GridParameters parameters) => Queryable.ProjectToType<AttachemntGroupModel>().GridAsync(
        parameters);

    public async Task<IEnumerable<AttachemntGroupModel>> ListModelAsync() => await Queryable.ProjectToType<AttachemntGroupModel>().ToListAsync();
}
