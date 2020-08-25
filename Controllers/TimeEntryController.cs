using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCRUDoperation.Controllers
{
    [Route("api/[TimeEntry]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryRepository _repository;
        public TimeEntryController(ITimeEntryRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Create([FromBody] TimeEntry timeEntry)
        {
            var created = _repository.Create(timeEntry);
            return CreatedAtRoute("GetTimeEntry", new { id = created.Id }, created);
        }
        [HttpGet("{id}" ,Name ="GetTimeEntry")]
        public IActionResult Find(long id)
        {
            return _repository.Contains(id) ? (IActionResult)Ok(_repository.Find(id)) : NotFound();
        }
        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.List());
        }
        [HttpPut("{id}")]
        public IActionResult Update(long id,[FromBody]TimeEntry timeEntry)
        {
            return _repository.Contains(id) ? (IActionResult)Ok(_repository.Find(id)) : NotFound();
        }
        [HttpDelete("{id")] 
        public IActionResult Delete(long id)
        {
            if (!_repository.Contains(id))
            {
                return NotFound();
            }
            _repository.Delete(id);
            return NoContent();
        }
    }
}
