namespace Architecture.Application;

public sealed record DeleteTranslationRequest(long Id) : IRequest<Result>;
