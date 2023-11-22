namespace Architecture.Application;

public sealed class GetDynamicFieldRequestValidator : AbstractValidator<GetDynamicFieldRequest>
{
    public GetDynamicFieldRequestValidator() => RuleFor(request => request.Id).Id();
}
