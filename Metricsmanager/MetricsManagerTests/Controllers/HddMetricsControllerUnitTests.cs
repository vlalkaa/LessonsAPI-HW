using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests.Controllers
{
    public class HddMetricsControllerUnitTests
    {
        private readonly HddMetricsController _controller;

        public HddMetricsControllerUnitTests()
        {
            _controller = new HddMetricsController();
        }

        [Fact]
        public void GetSizeFreeFromHdd_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            
            var result = _controller.GetSizeFreeFromHdd(fromTime,toTime);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }   
    }
}