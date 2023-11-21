namespace Architecture.Application;

public sealed class GetLookupRequestValidator : AbstractValidator<GetUserRequest>
{
    public GetLookupRequestValidator() => RuleFor(request => request.Id).Id();
}
