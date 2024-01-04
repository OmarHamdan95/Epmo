namespace Epmo.Application;

public sealed class UpdateDynamicFieldRequestValidator : AbstractValidator<UpdateDynamicFieldRequest>
{
    public UpdateDynamicFieldRequestValidator()
    {
        RuleFor(request => request.Id).Id();
        //RuleFor(request => request.LookupValueModels).NotEmpty();
    }
}
