using Mapster;

namespace Architecture.Database;

public sealed class LanguageRepository : EFRepository<Language>, ILanguageRepository
{
    public LanguageRepository(Context context) : base(context)
    {
    }


    public Task<LanguageModel> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).ProjectToType<LanguageModel>().SingleOrDefaultAsync();

    public Task<Grid<LanguageModel>> GridAsync(GridParameters parameters) => Queryable.ProjectToType<LanguageModel>().GridAsync(
        parameters);

    public async Task<IEnumerable<LanguageModel>> ListModelAsync() => await Queryable.ProjectToType<LanguageModel>().ToListAsync();
}
