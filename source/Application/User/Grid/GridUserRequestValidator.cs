namespace Epmo.Application;

public sealed class GridUserRequestValidator : AbstractValidator<GridUserRequest>
{
    public GridUserRequestValidator() => RuleFor(request => request).Grid();
}
