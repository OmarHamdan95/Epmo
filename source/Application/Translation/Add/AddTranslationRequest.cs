namespace Epmo.Application;

public  sealed record AddTranslationRequest (string? code ,  List<TranslationValueModel>? translationValues) : IRequest<Result<long>>;

