using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record GetLanguageHandler : IRequestHandler<GetLanguageRequest, Result<LanguageModel>>
{
    private readonly ILanguageRepository _languageRepository;

    public GetLanguageHandler(ILanguageRepository languageRepository) => _languageRepository = languageRepository;

    public async Task<Result<LanguageModel>> Handle(GetLanguageRequest request , CancellationToken cancellationToken)
    {
        var language = await _languageRepository.GetModelAsync(request.Id);

        return new Result<LanguageModel>(language is null ? NotFound : OK, language);
    }
}
