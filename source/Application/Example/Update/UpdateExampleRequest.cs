using System.Text.Json.Serialization;
namespace Epmo.Application;

public sealed record UpdateExampleRequest(string Name) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
