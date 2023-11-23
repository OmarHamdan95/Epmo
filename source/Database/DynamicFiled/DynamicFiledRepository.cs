using Mapster;

namespace Epmo.Database;

public sealed class DynamicFieldRepository : EFRepository<DynamicField>, IDynamicFieldRepository
{
    public DynamicFieldRepository(Context context) : base(context)
    {
    }

    public Task<DynamicFieldModel> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).ProjectToType<DynamicFieldModel>().SingleOrDefaultAsync();

    public Task<Grid<DynamicFieldModel>> GridAsync(GridParameters parameters) => Queryable.ProjectToType<DynamicFieldModel>().GridAsync(
        parameters);

    public async Task<IEnumerable<DynamicFieldModel>> ListModelAsync() => await Queryable.ProjectToType<DynamicFieldModel>().ToListAsync();
}
