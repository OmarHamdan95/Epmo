namespace Epmo.Application;

public sealed class DeleteDynamicFieldRequestValidator : AbstractValidator<DeleteDynamicFieldRequest>
{
    public DeleteDynamicFieldRequestValidator() => RuleFor(request => request.Id).Id();
}
