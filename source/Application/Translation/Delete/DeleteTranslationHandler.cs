using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record DeleteTranslationHandler : IRequestHandler<DeleteTranslationRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<Translation> _translationRepository;

    public DeleteTranslationHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<Translation> translationRepository
    )
    {
        _unitOfWork = unitOfWork;
        _translationRepository = translationRepository;
    }

    public async Task<Result> Handle(DeleteTranslationRequest request , CancellationToken cancellationToken)
    {

        await _translationRepository.DeleteEntityAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
