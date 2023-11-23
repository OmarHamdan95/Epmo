namespace Epmo.Database;

public interface ISystemMenuRepository : IRepository<SystemMenu>
{
    Task<SystemMenuModel> GetModelAsync(long id);

    Task<Grid<SystemMenuModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<SystemMenuModel>> ListModelAsync();
}
