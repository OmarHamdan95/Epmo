using Mapster;

namespace Epmo.Database;

public sealed class LookupRepository : EFRepository<Lookup>, ILookupRepository
{
    public LookupRepository(Context context) : base(context)
    {
    }

    public Task<LookupModel> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).ProjectToType<LookupModel>().SingleOrDefaultAsync();

    public Task<Grid<LookupModel>> GridAsync(GridParameters parameters) => Queryable.ProjectToType<LookupModel>().GridAsync(
        parameters);

    public async Task<IEnumerable<LookupModel>> ListModelAsync() => await Queryable.ProjectToType<LookupModel>().ToListAsync();
}
