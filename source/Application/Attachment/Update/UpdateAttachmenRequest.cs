using System.Text.Json.Serialization;
using Architecture.Model.Attachment;
using Architecture.Model.Lookup;
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record UpdateAttachmenRequest(List<AttachmentModel> AttachmentModels) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
