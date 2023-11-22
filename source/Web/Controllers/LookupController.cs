using Architecture.Application;
using Architecture.Model.Lookup;

namespace Architecture.Web;

[ApiController]
[Route("api/lookup")]
public sealed class LookupController : BaseController
{
    [HttpPost]
    public IActionResult Add(AddLookupRequest request) => Mediator.Send(request).ApiResult();

    [HttpGet("{id}")]
    public IActionResult Get(long id) => Mediator.Send(new GetLookupRequest(id)).ApiResult();
}
