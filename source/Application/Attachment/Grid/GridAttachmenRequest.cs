
namespace Architecture.Application;

public sealed record GridAttachmenRequest : GridParameters , IRequest<Result<Grid<AttachemntGroupModel>>>;
