using Mapster;

namespace Epmo.Database;

public sealed class SystemMenuRepository : EFRepository<SystemMenu>, ISystemMenuRepository
{
    public SystemMenuRepository(Context context) : base(context)
    {
    }

    public Task<SystemMenuModel> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).ProjectToType<SystemMenuModel>().SingleOrDefaultAsync();

    public Task<Grid<SystemMenuModel>> GridAsync(GridParameters parameters) => Queryable.ProjectToType<SystemMenuModel>().GridAsync(
        parameters);

    public async Task<IEnumerable<SystemMenuModel>> ListModelAsync() => await Queryable.ProjectToType<SystemMenuModel>().ToListAsync();
}
