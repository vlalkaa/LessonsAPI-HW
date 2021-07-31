using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests.Controllers
{
    public class RAMMetricsControllerUnitTests
    {
        private readonly RAMMetricsController _controller;

        public RAMMetricsControllerUnitTests()
        {
            _controller = new RAMMetricsController();
        }
        
        [Fact]
        public void GetSizeFreeFromRam_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            
            var result = _controller.GetSizeFreeFromRam(fromTime,toTime);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}