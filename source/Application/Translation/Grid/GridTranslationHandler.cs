using Architecture.Model.Lookup;
using Architecture.Model.Translation;
using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record GridTranslationHandler : IRequestHandler<GridTranslationRequest, Result<Grid<TranslationModelQuery>>>
{
    private readonly ITranslationRepository _translationRepository;

    public GridTranslationHandler(ITranslationRepository translationRepository) => _translationRepository = translationRepository;

    public async Task<Result<Grid<TranslationModelQuery>>> Handle(GridTranslationRequest request , CancellationToken cancellationToken)
    {
        var grid = await _translationRepository.GridAsync(request);

        return new Result<Grid<TranslationModelQuery>>(grid is null ? NotFound : OK, grid);
    }

}
