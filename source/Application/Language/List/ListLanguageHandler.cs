using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record ListLanguageHandler : IRequestHandler<ListLanguageRequest, Result<IEnumerable<LanguageModel>>>
{
    private readonly IRepositoryBase<Language> _languageRepository;

    public ListLanguageHandler(IRepositoryBase<Language> languageRepository) => _languageRepository = languageRepository;

    public async Task<Result<IEnumerable<LanguageModel>>> Handle(ListLanguageRequest request , CancellationToken cancellationToken)
    {
        var languages = await _languageRepository.ListModelAsync<LanguageModel>();

        return new Result<IEnumerable<LanguageModel>>(languages is null ? NotFound : OK, languages);
    }
}
