using Epmo.Domain.Common;

namespace Epmo.Domain;

public sealed class Auth : BaseAuditableEntity
{
    public Auth
    (
        string login,
        string password,
        User user
    )
    {
        Login = login;
        Password = password;
        User = user;
        Salt = Guid.NewGuid();
        Roles = Roles.User;
    }

    public Auth(long id) => Id = id;
    public Auth() { }

    public string? Login { get; }

    public string? Password { get; private set; }

    public Guid Salt { get; }

    public Roles Roles { get; }

    public User? User { get; }

    public void UpdatePassword(string password) => Password = password;
}
