using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record ListTranslationHandler : IRequestHandler<ListTranslationRequest, Result<IEnumerable<TranslationModelQuery>>>
{
    private readonly IRepositoryBase<Translation> _translationRepository;

    public ListTranslationHandler(IRepositoryBase<Translation> translationRepository) => _translationRepository = translationRepository;

    public async Task<Result<IEnumerable<TranslationModelQuery>>> Handle(ListTranslationRequest request , CancellationToken cancellationToken)
    {
        var translations = await _translationRepository.ListModelAsync<TranslationModelQuery>();

        return new Result<IEnumerable<TranslationModelQuery>>(translations is null ? NotFound : OK, translations);
    }
}
