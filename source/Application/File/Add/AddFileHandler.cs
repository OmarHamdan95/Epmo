using static System.Net.HttpStatusCode;

namespace Architecture.Application;

public sealed record AddFileHandler : IRequestHandler<AddFileRequest, Result<IEnumerable<BinaryFile>>>
{
    public async Task<Result<IEnumerable<BinaryFile>>> Handle(AddFileRequest request , CancellationToken cancellationToken)
    {
        var files = await request.Files.SaveAsync("Files");

        return new Result<IEnumerable<BinaryFile>>(Created, files);
    }
}
