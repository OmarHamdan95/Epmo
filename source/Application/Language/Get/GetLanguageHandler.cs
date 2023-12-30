using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GetLanguageHandler : IRequestHandler<GetLanguageRequest, Result<LanguageModel>>
{
    private readonly IRepositoryBase<Language> _languageRepository;

    public GetLanguageHandler(IRepositoryBase<Language> languageRepository) => _languageRepository = languageRepository;

    public async Task<Result<LanguageModel>> Handle(GetLanguageRequest request , CancellationToken cancellationToken)
    {
        var language = await _languageRepository.GetModelAsync<LanguageModel>(request.Id);

        return new Result<LanguageModel>(language is null ? NotFound : OK, language);
    }
}
