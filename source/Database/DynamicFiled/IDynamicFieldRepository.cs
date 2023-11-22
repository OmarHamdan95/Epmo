namespace Architecture.Database;

public interface IDynamicFieldRepository : IRepository<DynamicField>
{
    Task<DynamicFieldModel> GetModelAsync(long id);

    Task<Grid<DynamicFieldModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<DynamicFieldModel>> ListModelAsync();
}
