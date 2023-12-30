using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GridLanguageHandler : IRequestHandler<GridLanguageRequest, Result<Grid<LanguageModel>>>
{
    private readonly IRepositoryBase<Language> _languageRepository;

    public GridLanguageHandler(IRepositoryBase<Language> languageRepository) => _languageRepository = languageRepository;

    public async Task<Result<Grid<LanguageModel>>> Handle(GridLanguageRequest request , CancellationToken cancellationToken)
    {
        var grid = await _languageRepository.GridAsync<LanguageModel>(request);

        return new Result<Grid<LanguageModel>>(grid is null ? NotFound : OK, grid);
    }

}
