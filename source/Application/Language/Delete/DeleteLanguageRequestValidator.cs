namespace Epmo.Application;

public sealed class DeleteLanguageRequestValidator : AbstractValidator<DeleteLanguageRequest>
{
    public DeleteLanguageRequestValidator() => RuleFor(request => request.Id).Id();
}
