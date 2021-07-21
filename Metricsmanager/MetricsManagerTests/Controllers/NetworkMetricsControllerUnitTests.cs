using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests.Controllers
{
    public class NetworkMetricsControllerUnitTests
    {
        private readonly NetworkMetricsController _controller;

        public NetworkMetricsControllerUnitTests()
        {
            _controller = new NetworkMetricsController();
        }
        
        [Fact]
        public void GetMetricsFromAllAgent_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            
            var result = _controller.GetMetricsFromAllAgent(fromTime, toTime);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}