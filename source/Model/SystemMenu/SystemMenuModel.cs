﻿namespace Epmo.Model;

public class SystemMenuModel
{
    public LocalizationModel? Name { get; init; }
    public string? Icon { get; init; }
    public string? Route { get; init; }
    public string? Permission { get; init; }
    public SystemMenuModel? Parent { get; init; }
    public List<SystemMenuModel>? Child { get; init; }
}
