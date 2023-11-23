using Mapster;

namespace Epmo.Database;

public sealed class TranslationRepository : EFRepository<Translation>, ITranslationRepository
{
    public TranslationRepository(Context context) : base(context)
    {
    }


    public Task<TranslationModelQuery> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).ProjectToType<TranslationModelQuery>().SingleOrDefaultAsync();

    public Task<Grid<TranslationModelQuery>> GridAsync(GridParameters parameters) => Queryable.ProjectToType<TranslationModelQuery>().GridAsync(
        parameters);

    public async Task<IEnumerable<TranslationModelQuery>> ListModelAsync() => await Queryable.ProjectToType<TranslationModelQuery>().ToListAsync();
}
