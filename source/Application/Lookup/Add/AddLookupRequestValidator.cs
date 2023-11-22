namespace Architecture.Application;

public sealed class AddLookupRequestValidator :  AbstractValidator<AddLookupRequest>
{
    public AddLookupRequestValidator()
    {
        RuleFor(request => request.LookupCode).Name();
        RuleFor(request => request.TranslationModel).NotEmpty();
    }
}
