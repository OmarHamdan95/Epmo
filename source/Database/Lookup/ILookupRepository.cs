using Architecture.Model.Lookup;

namespace Architecture.Database;

public interface ILookupRepository : IRepository<Lookup>
{
    Task<LookupModel> GetModelAsync(long id);

    Task<Grid<LookupModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<LookupModel>> ListModelAsync();
}
