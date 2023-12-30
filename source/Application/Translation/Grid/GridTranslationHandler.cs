using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record GridTranslationHandler : IRequestHandler<GridTranslationRequest, Result<Grid<TranslationModelQuery>>>
{
    private readonly IRepositoryBase<Translation> _translationRepository;

    public GridTranslationHandler(IRepositoryBase<Translation> translationRepository) => _translationRepository = translationRepository;

    public async Task<Result<Grid<TranslationModelQuery>>> Handle(GridTranslationRequest request , CancellationToken cancellationToken)
    {
        var grid = await _translationRepository.GridAsync<TranslationModelQuery>(request);

        return new Result<Grid<TranslationModelQuery>>(grid is null ? NotFound : OK, grid);
    }

}
