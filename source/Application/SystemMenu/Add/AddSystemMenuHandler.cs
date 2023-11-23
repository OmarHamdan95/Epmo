using Mapster;
namespace Epmo.Application;
using static System.Net.HttpStatusCode;

public sealed record AddSystemMenuHandler : IRequestHandler<AddSystemMenuRequest, Result<long>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISystemMenuRepository _systemMenuRepository;


    public AddSystemMenuHandler
    (
        IUnitOfWork unitOfWork,
        ISystemMenuRepository languageRepository
    )
    {
        _unitOfWork = unitOfWork;
        _systemMenuRepository = languageRepository;
    }

    public async Task<Result<long>> Handle(AddSystemMenuRequest request , CancellationToken cancellationToken)
    {

        var systemMenu = new SystemMenu(request.Name.Adapt<Translation>(), request.Icon , request.Route , request.Permission,
            request.Parent.Adapt<SystemMenu>() , request.Child.Adapt<List<SystemMenu>>());

        await _systemMenuRepository.AddAsync(systemMenu);

        await _unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, systemMenu.Id);
       // throw new NotImplementedException();
    }
}
