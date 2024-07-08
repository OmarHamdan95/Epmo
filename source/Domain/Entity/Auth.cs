namespace Epmo.Domain;

public class Auth : BaseAuditableEntity
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

    public Auth()
    {
    }

    public string? Login { get; private set; }

    public string? Password { get; private set; }

    public Guid Salt { get;  private set; }

    public Roles Roles { get;  private set; }

    public User? User { get; private set; }

    public void UpdatePassword(string password) => Password = password;
}
