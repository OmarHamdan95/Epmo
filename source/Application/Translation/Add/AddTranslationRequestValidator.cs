namespace Epmo.Application;

public sealed class AddTranslationRequestValidator :  AbstractValidator<AddTranslationRequest>
{
    public AddTranslationRequestValidator()
    {
        RuleFor(request => request.translationValues).NotEmpty();
    }
}
