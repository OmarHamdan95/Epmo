using Architecture.Model.Lookup;
using Architecture.Model.Translation;
using Mapster;

namespace Architecture.Database;

public sealed class DynamicFieldRepository : EFRepository<DynamicField>, IDynamicFieldRepository
{
    public DynamicFieldRepository(Context context) : base(context)
    {
    }


    // public static Expression<Func<Lookup, LookupModel>> Model => entity => new LookupModel
    // {
    //     Id = entity.Id,
    //     Translation = new TranslationModel()
    //     {
    //         Id = entity.Translation.Id,
    //         Code = entity.Translation.Code,
    //         TranslationValues = entity.Translation.TranslationValues.Select(x => new TranslationValueModel()
    //         {
    //             Id = x.Id,
    //             Code = x.Code,
    //             TransaltionValue = x.TransaltionValue
    //         }).ToList()
    //     },
    //     LookupValues = entity.LookupValues.Select(_=> new LookupValueModel()
    //     {
    //         Id = _.Id,
    //         LookupCode = _.LookupValueCode,
    //         Translation = new TranslationModel()
    //         {
    //             Id = _.Translation.Id,
    //             Code = _.Translation.Code,
    //             TranslationValues = _.Translation.TranslationValues.Select(x => new TranslationValueModel()
    //             {
    //                 Id = x.Id,
    //                 Code = x.Code,
    //                 TransaltionValue = x.TransaltionValue
    //             }).ToList()
    //         }
    //     }).ToList()
    // };

    public Task<DynamicFieldModel> GetModelAsync(long id) =>
        Queryable.Where(entity => entity.Id == id).ProjectToType<DynamicFieldModel>().SingleOrDefaultAsync();

    public Task<Grid<DynamicFieldModel>> GridAsync(GridParameters parameters) => Queryable.ProjectToType<DynamicFieldModel>().GridAsync(
        parameters);

    public async Task<IEnumerable<DynamicFieldModel>> ListModelAsync() => await Queryable.ProjectToType<DynamicFieldModel>().ToListAsync();
}
