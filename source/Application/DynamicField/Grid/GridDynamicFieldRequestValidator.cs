namespace Architecture.Application;

public sealed class GridDynamicFieldRequestValidator : AbstractValidator<GridDynamicFieldRequest>
{
    public GridDynamicFieldRequestValidator() => RuleFor(request => request).Grid();
}
