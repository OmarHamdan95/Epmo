namespace Epmo.Application;

public sealed class DeleteTranslationRequestValidator : AbstractValidator<DeleteTranslationRequest>
{
    public DeleteTranslationRequestValidator() => RuleFor(request => request.Id).Id();
}
