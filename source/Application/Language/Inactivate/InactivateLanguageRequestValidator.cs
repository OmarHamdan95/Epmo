namespace Epmo.Application;

public sealed class InactivateLanguageRequestValidator : AbstractValidator<InactivateLanguageRequest>
{
    public InactivateLanguageRequestValidator() => RuleFor(request => request.Id).Id();
}
