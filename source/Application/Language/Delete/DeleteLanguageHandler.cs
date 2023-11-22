using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record DeleteLanguageHandler : IRequestHandler<DeleteLanguageRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILanguageRepository _languageRepository;

    public DeleteLanguageHandler
    (
        IUnitOfWork unitOfWork,
        ILanguageRepository languageRepository
    )
    {
        _unitOfWork = unitOfWork;
        _languageRepository = languageRepository;
    }

    public async Task<Result> Handle(DeleteLanguageRequest request , CancellationToken cancellationToken)
    {

        await _languageRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
