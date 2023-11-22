namespace Architecture.Application;

public sealed class GridTranslationRequestValidator : AbstractValidator<GridTranslationRequest>
{
    public GridTranslationRequestValidator() => RuleFor(request => request).Grid();
}
