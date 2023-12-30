using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record InactivateLanguageHandler : IRequestHandler<InactivateLanguageRequest , Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<Language> _languageRepository;

    public InactivateLanguageHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<Language> languageRepository
    )
    {
        _unitOfWork = unitOfWork;
        _languageRepository = languageRepository;
    }

    public async Task<Result> Handle(InactivateLanguageRequest request , CancellationToken cancellationToken)
    {
        var language = new Language(request.Id);

        language.Inactivate();

        await _languageRepository.UpdatePartialAsync(new { language.Id, language.ValidTo });

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
