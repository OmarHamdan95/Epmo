
namespace Epmo.Database;

public interface ILanguageRepository : IRepository<Language>
{
    Task<LanguageModel> GetModelAsync(long id);

    Task<Grid<LanguageModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<LanguageModel>> ListModelAsync();
}
