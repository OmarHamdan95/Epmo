namespace Epmo.Application;

public sealed record ListAttachmenRequest : IRequest<Result<IEnumerable<AttachemntGroupModel>>>;
