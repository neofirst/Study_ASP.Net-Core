using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ApiHelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiHelloWorldWithValueController : ControllerBase
    {
        public IEnumerable<Value> Get()
        {
            return new Value[] {
                new Value { Id = 1, Text = "1" },
                new Value { Id = 2, Text = "2" },
                new Value { Id = 3, Text = "3" }
            };
        }

        [HttpGet("{id:int}")]
        public Value Get(int id)
        {
            return new Value { Id = id, Text = $"넘어온 값:{id}" };
        }

        [HttpPost]
        [Produces("application/json", Type = typeof(Value))]
        [Consumes("application/json")]
        public IActionResult Post([FromBody]Value value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { id = value.Id }, value);
        }
    }

    public class Value
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Text 속성 필수")]
        public string Text { get; set; }
    }
}
