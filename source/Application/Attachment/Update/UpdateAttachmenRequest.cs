using System.Text.Json.Serialization;

namespace Epmo.Application;

public sealed record UpdateAttachmenRequest(List<AttachmentModel> AttachmentModels) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
