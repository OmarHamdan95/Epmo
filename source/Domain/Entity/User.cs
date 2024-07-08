namespace Epmo.Domain;

public class User : BaseAuditableEntity , IAggregateRoot
{
    public User
    (
        string name,
        string email
    )
    {
        Name = name;
        Email = email;
        Activate();
    }

    public User(long id) => Id = id;

    public User(){}
    public string? Name { get; private set; }

    public string? Email { get; private set; }

    public Status Status { get; private set; }

    public void UpdateName(string name) => Name = name;

    public void UpdateEmail(string email) => Email = email;

    public void Activate() => Status = Status.Active;

    public void Inactivate() => Status = Status.Inactive;
}
