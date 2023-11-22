using Architecture.Model.Lookup;
using Architecture.Model.Translation;
namespace Architecture.Application;

public  sealed record AddTranslationRequest (string? code ,  List<TranslationValueModel>? translationValues) : IRequest<Result<long>>;

