using Architecture.Model.Lookup;
using Architecture.Model.Translation;
namespace Architecture.Application;

public  sealed record AddAttachmenRequest (List<AttachemntGroupModel> Attachments) : IRequest<Result<long>>;

