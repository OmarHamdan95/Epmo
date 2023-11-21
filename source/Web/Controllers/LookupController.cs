using Architecture.Application.Lookup.Add;
using Architecture.Model.Lookup;

namespace Architecture.Web;

[ApiController]
[Route("api/lookup")]
public sealed class LookupController : BaseController
{
    [HttpPost]
    public IActionResult Add(AddLookupRequest request) => Mediator.HandleAsync<AddLookupRequest, long>(request).ApiResult();

    [HttpGet("{id}")]
    public IActionResult Get(long id) => Mediator.HandleAsync<GetLookupRequest, LookupModel>(new GetLookupRequest(id)).ApiResult();
}
