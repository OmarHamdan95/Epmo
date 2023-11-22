using Architecture.Model.Lookup;
using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record ListLanguageHandler : IRequestHandler<ListLanguageRequest, Result<IEnumerable<LanguageModel>>>
{
    private readonly ILanguageRepository _languageRepository;

    public ListLanguageHandler(ILanguageRepository languageRepository) => _languageRepository = languageRepository;

    public async Task<Result<IEnumerable<LanguageModel>>> Handle(ListLanguageRequest request , CancellationToken cancellationToken)
    {
        var languages = await _languageRepository.ListModelAsync();

        return new Result<IEnumerable<LanguageModel>>(languages is null ? NotFound : OK, languages);
    }
}
