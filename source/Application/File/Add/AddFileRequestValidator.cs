namespace Epmo.Application;

public sealed class AddFileRequestValidator : AbstractValidator<AddFileRequest>
{
    public AddFileRequestValidator() => RuleFor(request => request.Files).Files();
}
