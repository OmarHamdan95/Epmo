namespace Epmo.Application;

public sealed class UpdateTranslationRequestValidator : AbstractValidator<UpdateTranslationRequest>
{
    public UpdateTranslationRequestValidator()
    {
        RuleFor(request => request.Id).Id();
    }
}
