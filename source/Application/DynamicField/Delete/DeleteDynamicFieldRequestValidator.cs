namespace Architecture.Application;

public sealed class DeleteDynamicFieldRequestValidator : AbstractValidator<DeleteDynamicFieldRequest>
{
    public DeleteDynamicFieldRequestValidator() => RuleFor(request => request.Id).Id();
}
