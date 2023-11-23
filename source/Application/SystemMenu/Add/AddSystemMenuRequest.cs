using Architecture.Model.SystemMenu;
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record AddSystemMenuRequest(TranslationModel? Name,
    string? Icon,
    string? Route,
    string? Permission,
    SystemMenuModel? Parent,
    List<SystemMenuModel>? Child) : IRequest<Result<long>>;
