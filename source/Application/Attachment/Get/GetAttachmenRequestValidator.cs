namespace Epmo.Application;

public sealed class GetAttachmenRequestValidator : AbstractValidator<GetLookupRequest>
{
    public GetAttachmenRequestValidator() => RuleFor(request => request.Id).Id();
}
