
namespace Epmo.Application;

public sealed record GetLanguageRequest(long Id) : IRequest<Result<LanguageModel>>;
