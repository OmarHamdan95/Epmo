namespace Epmo.Application;

public sealed class GetLanguageRequestValidator : AbstractValidator<GetLanguageRequest>
{
    public GetLanguageRequestValidator() => RuleFor(request => request.Id).Id();
}
