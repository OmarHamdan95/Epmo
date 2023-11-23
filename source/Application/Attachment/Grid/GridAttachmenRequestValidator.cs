namespace Epmo.Application;

public sealed class GridAttachmenRequestValidator : AbstractValidator<GridLookupRequest>
{
    public GridAttachmenRequestValidator() => RuleFor(request => request).Grid();
}
