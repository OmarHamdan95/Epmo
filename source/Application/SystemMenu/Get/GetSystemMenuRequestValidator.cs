namespace Epmo.Application;

public sealed class GetSystemMenuRequestValidator : AbstractValidator<GetLanguageRequest>
{
    public GetSystemMenuRequestValidator() => RuleFor(request => request.Id).Id();
}
