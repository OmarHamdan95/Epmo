using Architecture.Model.Lookup;
using Architecture.Model.Translation;

namespace Architecture.Database;

public sealed class LookupRepository : EFRepository<Lookup>, ILookupRepository
{
    public LookupRepository(Context context) : base(context)
    {
    }


    public static Expression<Func<Lookup, LookupModel>> Model => entity => new LookupModel
    {
        Id = entity.Id,
        TranslationModel = new TranslationModel()
        {
            Id = entity.Translation.Id,
            Code = entity.Translation.Code,
            TranslationValues = entity.Translation.TranslationValues.Select(x => new TranslationValueModel()
            {
                Id = x.Id,
                Code = x.Code,
                TransaltionValue = x.TransaltionValue
            }).ToList()
        },
        LookupValueModels = entity.LookupValues.Select(_=> new LookupValueModel()
        {
            Id = _.Id,
            LookupCode = _.LookupValueCode,
            TranslationModel = new TranslationModel()
            {
                Id = _.Translation.Id,
                Code = _.Translation.Code,
                TranslationValues = _.Translation.TranslationValues.Select(x => new TranslationValueModel()
                {
                    Id = x.Id,
                    Code = x.Code,
                    TransaltionValue = x.TransaltionValue
                }).ToList()
            }
        }).ToList()
    };

    public Task<LookupModel> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).Select(Model).SingleOrDefaultAsync();

    public Task<Grid<LookupModel>> GridAsync(GridParameters parameters) => Queryable.Select(Model).GridAsync(
        parameters);

    public async Task<IEnumerable<LookupModel>> ListModelAsync() => await Queryable.Select(Model).ToListAsync();
}
