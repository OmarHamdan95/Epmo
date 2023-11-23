using static System.Net.HttpStatusCode;

namespace Epmo.Application;

public sealed record UpdateUserHandler : IRequestHandler<UpdateUserRequest, Result>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;

    public UpdateUserHandler
    (
        IUnitOfWork unitOfWork,
        IUserRepository userRepository
    )
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(UpdateUserRequest request , CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetAsync(request.Id);

        if (user is null) return new Result(NotFound);

        user.UpdateName(request.Name);

        user.UpdateEmail(request.Email);

        await _userRepository.UpdateAsync(user);

        await _unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
