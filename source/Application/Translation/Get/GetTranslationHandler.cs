using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GetTranslationHandler : IRequestHandler<GetTranslationRequest, Result<TranslationModelQuery>>
{
    private readonly ITranslationRepository _translationRepository;

    public GetTranslationHandler(ITranslationRepository translationRepository) => _translationRepository = translationRepository;

    public async Task<Result<TranslationModelQuery>> Handle(GetTranslationRequest request , CancellationToken cancellationToken)
    {
        var translation = await _translationRepository.GetModelAsync(request.Id);

        return new Result<TranslationModelQuery>(translation is null ? NotFound : OK, translation);
    }
}
