namespace Epmo.Application;

public sealed class GetTranslationRequestValidator : AbstractValidator<GetTranslationRequest>
{
    public GetTranslationRequestValidator() => RuleFor(request => request.Id).Id();
}
