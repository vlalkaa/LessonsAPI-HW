using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests.Controllers
{
    public class DotNetMetricsControllerUnitTests
    {
        private readonly DotNetMetricsController _controller;

        public DotNetMetricsControllerUnitTests()
        {
            _controller = new DotNetMetricsController();
        }

        [Fact]
        public void GetMetricsFromAllCluster_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            
            var result = _controller.GetMetricsFromAllAgentErrorsCount(fromTime, toTime);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}