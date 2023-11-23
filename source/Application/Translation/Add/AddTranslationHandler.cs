using Mapster;
namespace Epmo.Application;
using static System.Net.HttpStatusCode;

public sealed record AddTranslationHandler : IRequestHandler<AddTranslationRequest, Result<long>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITranslationRepository _translationRepository;


    public AddTranslationHandler
    (
        IUnitOfWork unitOfWork,
        ITranslationRepository translationRepository
    )
    {
        _unitOfWork = unitOfWork;
        _translationRepository = translationRepository;
    }

    public async Task<Result<long>> Handle(AddTranslationRequest request , CancellationToken cancellationToken)
    {

        var translation = new Translation(request.code, request.translationValues.Adapt<List<TranslationValue>>());

        await _translationRepository.AddAsync(translation);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, translation.Id);
       // throw new NotImplementedException();
    }
}
