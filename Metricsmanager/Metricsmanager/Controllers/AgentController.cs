using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricsManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;

namespace MetricsManager.Controllers
{
    [Route("api/controller/agent")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly ILogger<AgentController> _logger;

        public AgentController(ILogger<AgentController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "nlog встроен в AgentController");
        }

        [HttpGet]
        public IActionResult Check()
        {
            return Ok("gooood");
        }
        
        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            return Ok();
        }

        [HttpPut("enable/{agentId}")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpPut("disable/{agentId}")]
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpGet("list/all/register")]
        public IActionResult GetListAllRegisterAgent()
        {
            return Ok();
        }
    }
}