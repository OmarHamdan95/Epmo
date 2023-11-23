
namespace Epmo.Application;

public sealed record AddAttachmenRequest (List<AttachemntGroupModel> Attachments) : IRequest<Result<long>>;

