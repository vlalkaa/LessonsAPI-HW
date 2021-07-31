using MetricsManager.Controllers;
using MetricsManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace MetricsManagerTests.Controllers
{
    public class AgentControllerTests
    {
        private readonly AgentController _controller;

        public AgentControllerTests(ILogger<AgentController> logger)
        {
            
            _controller = new AgentController(logger);
        }

        [Fact]
        public void Check_ReturnOk()
        {
            var result = _controller.Check();

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
        
        [Fact]
        public void RegisterAgent_ReturnsOk()
        {
            var agentInfo = new AgentInfo();
            
            var result = _controller.RegisterAgent(agentInfo);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
        
        [Fact]
        public void EnableAgentById_ReturnsOk()
        {
            var agentId = 5;
            
            var result = _controller.EnableAgentById(agentId);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
        
        [Fact]
        public void DisableAgentById_ReturnsOk()
        {
            var agentId = 5;
            
            var result = _controller.DisableAgentById(agentId);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
        
        [Fact]
        public void GetListAllRegisterAgent_ReturnsOk()
        {
            var result = _controller.GetListAllRegisterAgent();
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}