using Mapster;
namespace Epmo.Application;
using static System.Net.HttpStatusCode;

public sealed record AddLanguageHandler : IRequestHandler<AddLanguageRequest, Result<long>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepositoryBase<Language> _languageRepository;
    public AddLanguageHandler
    (
        IUnitOfWork unitOfWork,
        IRepositoryBase<Language> languageRepository
    )
    {
        _unitOfWork = unitOfWork;
        _languageRepository = languageRepository;
    }

    public async Task<Result<long>> Handle(AddLanguageRequest request , CancellationToken cancellationToken)
    {

        var language = new Language(request.Code, request.LangFlag);

        await _languageRepository.AddAsync(language);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, language.Id);
        // throw new NotImplementedException();
    }
}
