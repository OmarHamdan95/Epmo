using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record DeleteLanguageHandler : IRequestHandler<DeleteLanguageRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<Language> _languageRepository;
    public DeleteLanguageHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<Language> languageRepository
    )
    {
        _unitOfWork = unitOfWork;
        _languageRepository = languageRepository;
    }

    public async Task<Result> Handle(DeleteLanguageRequest request , CancellationToken cancellationToken)
    {

        await _languageRepository.DeleteEntityAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
