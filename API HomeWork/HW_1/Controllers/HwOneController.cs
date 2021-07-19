using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HwOneController : Controller
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
        public string GetIndex(int index)
        {
            return Str[index];
        }

        [HttpDelete]
        public void DeleteAll()
        {
            for (int i = Str.Count - 1; i > -1; i--)
            {
                Str.RemoveAt(i);
            }
        }
        
        [HttpDelete("{index}")]
        public void DeleteIndex(int index)
        {
            Str.RemoveAt(index);
        }
        
        [HttpPut("{predicate}")]
        public void Put(string predicate)
        {
            Str.Add(predicate);
        }
    }
}