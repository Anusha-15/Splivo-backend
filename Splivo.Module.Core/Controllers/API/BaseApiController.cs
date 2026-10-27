using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Splivo.Module.Core.Controllers.API
{
    [Authorize]
    [Area("Core")]
    public class BaseApiController : Controller
    {

    }
}
