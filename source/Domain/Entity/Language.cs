using Epmo.Domain.Common;

namespace Epmo.Domain;

public class Language : LookupBase
{
    public string? LangFlag { get; init; }

    public Language(long id) => Id = id;

    public Language(){}

    public Language(string? code, string? langFlag)
    {
        Code = code;
        LangFlag = langFlag;
        ValidFrom = DateTime.Now;
    }

    public void Inactivate() => ValidTo = DateTime.Now.AddDays(-1);
}
