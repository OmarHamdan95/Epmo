using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record ListAttachmenRequest : IRequest<Result<IEnumerable<AttachemntGroupModel>>>;
