
using Architecture.Model.Translation;

namespace Architecture.Database;

public interface ITranslationRepository : IRepository<Translation>
{
    Task<TranslationModelQuery> GetModelAsync(long id);

    Task<Grid<TranslationModelQuery>> GridAsync(GridParameters parameters);

    Task<IEnumerable<TranslationModelQuery>> ListModelAsync();
}
