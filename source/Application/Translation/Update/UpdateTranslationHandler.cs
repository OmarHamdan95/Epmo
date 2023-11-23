using Mapster;
using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record UpdateTranslationHandler : IRequestHandler<UpdateTranslationRequest, Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITranslationRepository _translationRepository;

    public UpdateTranslationHandler
    (
        IUnitOfWork unitOfWork,
        ITranslationRepository translationRepository
    )
    {
        _unitOfWork = unitOfWork;
        _translationRepository = translationRepository;
    }

    public async Task<Result> Handle(UpdateTranslationRequest request , CancellationToken cancellationToken)
    {
        var translation = await _translationRepository.GetAsync(request.Id);

        if (translation is null) return new Result(NotFound);

        translation.UpdateTranslation(request.translationValues.Adapt<List<TranslationValue>>());

        await _translationRepository.UpdateAsync(translation);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
