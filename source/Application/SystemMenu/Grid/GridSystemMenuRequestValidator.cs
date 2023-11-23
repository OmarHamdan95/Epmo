namespace Architecture.Application;

public sealed class GridSystemMenuRequestValidator : AbstractValidator<GridLanguageRequest>
{
    public GridSystemMenuRequestValidator() => RuleFor(request => request).Grid();
}
