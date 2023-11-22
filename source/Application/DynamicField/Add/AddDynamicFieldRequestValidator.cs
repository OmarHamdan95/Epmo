namespace Architecture.Application;

public sealed class AddDynamicFieldRequestValidator :  AbstractValidator<AddDynamicFieldRequest>
{
    public AddDynamicFieldRequestValidator()
    {
        RuleFor(request => request.Name).NotEmpty();
        //RuleFor(request => request.TranslationModel).NotEmpty();
    }
}
