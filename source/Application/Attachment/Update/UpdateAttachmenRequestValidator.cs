namespace Architecture.Application;

public sealed class UpdateAttachmenRequestValidator : AbstractValidator<UpdateLookupRequest>
{
    public UpdateAttachmenRequestValidator()
    {
        RuleFor(request => request.Id).Id();
        RuleFor(request => request.LookupValueModels).NotEmpty();
    }
}
