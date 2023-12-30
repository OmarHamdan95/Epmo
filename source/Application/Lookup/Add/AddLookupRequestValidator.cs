namespace Epmo.Application;

public sealed class AddLookupRequestValidator :  AbstractValidator<AddLookupRequest>
{
    public AddLookupRequestValidator()
    {
        RuleFor(request => request.Code).Name();
        RuleFor(request => request.TranslationModel).NotEmpty();
    }
}
