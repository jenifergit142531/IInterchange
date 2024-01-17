using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace webapiclass1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LangController : ControllerBase
    {
        private readonly IStringLocalizer<LangController> _localizer;

        public LangController(IStringLocalizer<LangController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        [Route("culture")]
        public IEnumerable<string> Get()
        {
            var localMessage = _localizer["Hello", "John"].Value;
            return new string[] { localMessage };
        }
    }
}
