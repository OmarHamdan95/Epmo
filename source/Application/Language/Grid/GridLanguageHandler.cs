using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GridLanguageHandler : IRequestHandler<GridLanguageRequest, Result<Grid<LanguageModel>>>
{
    private readonly ILanguageRepository _languageRepository;

    public GridLanguageHandler(ILanguageRepository languageRepository) => _languageRepository = languageRepository;

    public async Task<Result<Grid<LanguageModel>>> Handle(GridLanguageRequest request , CancellationToken cancellationToken)
    {
        var grid = await _languageRepository.GridAsync(request);

        return new Result<Grid<LanguageModel>>(grid is null ? NotFound : OK, grid);
    }

}
