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
            var result = _controller.GetSizeFreeFromHdd();
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }   
    }
}