namespace Epmo.Application;

public sealed class DeleteLookupRequestValidator : AbstractValidator<DeleteLookupRequest>
{
    public DeleteLookupRequestValidator() => RuleFor(request => request.Id).Id();
}
