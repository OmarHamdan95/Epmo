namespace Epmo.Application;

public sealed class UpdateDynamicFieldRequestValidator : AbstractValidator<UpdateLookupRequest>
{
    public UpdateDynamicFieldRequestValidator()
    {
        RuleFor(request => request.Id).Id();
        RuleFor(request => request.LookupValueModels).NotEmpty();
    }
}
