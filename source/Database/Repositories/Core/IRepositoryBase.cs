using Epmo.Domain.Common;
using Epmo.Domain.MarkarEntity;

namespace Epmo.Database;

public interface IRepositoryBase<T> :IRepository<T> where T : BaseAuditableEntity , IAggregateRoot
{
    Task<ProjectionType> GetModelAsync<ProjectionType>(long id);

    Task<Grid<ProjectionType>> GridAsync<ProjectionType>(GridParameters parameters);

    Task<IEnumerable<ProjectionType>> ListModelAsync<ProjectionType>();
    public void DeleteEntity(object key);
    Task DeleteEntityAsync(object key);

}
