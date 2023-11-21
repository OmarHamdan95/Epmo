namespace Architecture.Application.Lookup.Add;
using static System.Net.HttpStatusCode;

public sealed record AddLookupHandler : IHandler<AddLookupRequest, long>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILookupRepository _lookupRepository;


    public AddLookupHandler
    (
        IUnitOfWork unitOfWork,
        ILookupRepository lookupRepository
    )
    {
        _unitOfWork = unitOfWork;
        _lookupRepository = lookupRepository;
    }

    public async Task<Result<long>> HandleAsync(AddLookupRequest request)
    {

        var Translation = new Translation()
        {
            Code = "Test",
            TranslationValues = new List<TranslationValue>()
            {
                new TranslationValue()
                {
                    Code = "Test01",
                    TransaltionValue = "TestTR"
                }
            }
        };

        var LookupValue = new List<LookupValue>()
        {
            new LookupValue()
            {
                Code = "raed",
                Translation = new Translation()
                {
                    Code = "raed",
                    TranslationValues = new List<TranslationValue>()
                    {
                        new TranslationValue()
                        {
                            Code = "raed01",
                            TransaltionValue = "raed"
                        },
                        new TranslationValue()
                        {
                            Code = "raed001",
                            TransaltionValue = "raed"
                        }
                    }
                }
            },
             new LookupValue()
            {
                Code = "omar",
                Translation = new Translation()
                {
                    Code = "omar",
                    TranslationValues = new List<TranslationValue>()
                    {
                        new TranslationValue()
                        {
                            Code = "omar01",
                            TransaltionValue = "omar"
                        },
                        new TranslationValue()
                        {
                            Code = "omar001",
                            TransaltionValue = "omar"
                        }
                    }
                }
            }
        };

        var lookup = new Domain.Lookup(request.LookupCode, Translation , LookupValue);


        await _lookupRepository.AddAsync(lookup);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, lookup.Id);
       // throw new NotImplementedException();
    }
}
