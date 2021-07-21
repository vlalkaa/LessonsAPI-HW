using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HwOneController : ControllerBase
    {
        private static readonly List<string> Str = new List<string>()
        {
            "a", "b", "c","d", "e", "f","g"
        };

        private readonly ILogger<HwOneController> _logger;

        
        public HwOneController(ILogger<HwOneController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return Str;
        }
        
        
        [HttpGet("{index}")]
        public IActionResult GetIndex(int index)
        {
            return Ok(Str[index]);
        }

        
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            for (int i = Str.Count - 1; i > -1; i--)
            {
                Str.RemoveAt(i);
            }

            return Ok();
        }
        
        
        [HttpDelete("{index}")]
        public IActionResult DeleteIndex([FromRoute] int index)
        {
            Str.RemoveAt(index);
            
            return Ok();
        }
        
        
        [HttpPut("{predicate}")]
        public IActionResult Put(string predicate)
        {
            Str.Add(predicate);
            
            return Ok();
        }
    }
}