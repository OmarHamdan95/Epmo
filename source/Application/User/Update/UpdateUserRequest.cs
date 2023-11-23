using System.Text.Json.Serialization;
namespace Epmo.Application;

public sealed record UpdateUserRequest(string Name, string Email) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
