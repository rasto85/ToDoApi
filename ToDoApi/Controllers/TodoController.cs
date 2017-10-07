using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {

        private readonly ToDoContext _context;
        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        // GET api/Todo
        [HttpGet]
        public IActionResult Get()
        {

            var todos = _context.ToDoItems;
            var apa = 3;
            return Ok(todos);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var todo = _context.ToDoItems.Single(x => x.ToDoItemId == id);
            return Ok(todo);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]ToDoItem toDo)
        {
            _context.Add(toDo);
            _context.SaveChanges();
            return Ok();
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var todo = _context.ToDoItems.Single(x => x.ToDoItemId == id);
            _context.ToDoItems.Remove(todo);
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

    }
}
