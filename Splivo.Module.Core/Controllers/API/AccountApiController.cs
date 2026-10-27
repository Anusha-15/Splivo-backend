using Microsoft.Extensions.Logging;
using Splivo.Module.Core.Controllers.API;

namespace Splivo.API.Controllers
{
    public class AccountApiController : BaseApiController
    {
        private readonly ILogger<AccountApiController> _logger;
        public AccountApiController(ILogger<AccountApiController> logger)
        {
            _logger = logger;
        }
    }
}
