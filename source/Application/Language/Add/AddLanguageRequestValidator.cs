namespace Architecture.Application;

public sealed class AddLanguageRequestValidator :  AbstractValidator<AddLanguageRequest>
{
    public AddLanguageRequestValidator()
    {
        RuleFor(request => request.LangFlag).NotEmpty();
    }
}
