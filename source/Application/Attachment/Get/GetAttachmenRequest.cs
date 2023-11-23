using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record GetAttachmenRequest(long Id) : IRequest<Result<AttachemntGroupModel>>;
