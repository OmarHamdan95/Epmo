namespace Epmo.Domain;

public class SystemMenu : BaseAuditableEntity , IAggregateRoot
{
    public LocalizedText? Name { get; set; }
    public string? Icon { get; set; }
    public string? Route { get; set; }
    public string? Permission { get; set; }
    public SystemMenu? Parent { get; set; }
    public long? ParentId { get; set; }
    public List<SystemMenu> Child { get; set; }


    public SystemMenu(){}

    public SystemMenu(long id) => Id = id;

    public SystemMenu(LocalizedText? name, string? icon, string? route, string? permission, SystemMenu? parent,
        List<SystemMenu> child)
    {
        Name = name;
        Icon = icon;
        Route = route;
        Permission = permission;
        Parent = parent;
        Child = child;
    }
}
