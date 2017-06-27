using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LightsApi.Models;
using System.Linq;

namespace LightsApi.Controllers
{
    [Route("api/[controller]")]
    public class LightsController : Controller
    {
        private readonly LightsContext _context;

        public LightsController(LightsContext context)
        {
            _context = context;
            if (_context.LightsItems.Count() == 0)
            {
                _context.LightsItems.Add(new LightsItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<LightsItem> GetAll()
         {
             return _context.LightsItems.ToList(); 
         }

         [HttpGet ("{id}", Name = "GetLights")]
         public IActionResult GetById(long id)
         {
             var item = _context.LightsItems.FirstOrDefault ( t => t.Id == id);
             if ( item == null )
             {
                 return NotFound();
             }
             return new ObjectResult(item);
         }

         [HttpPost]
         public IActionResult Create([FromBody] LightsItem item){

             if ( item == null)
             {
                 return BadRequest();
             }

             _context.LightsItems.Add(item);
             _context.SaveChanges();

             return CreatedAtRoute("GetLights", new { id = item.Id }, item );

         }

         [HttpPut("{id}")]
         public IActionResult Update(long id ,[FromBody] LightsItem item)
         {
             if (item == null || item.Id != id)
             {
                 return BadRequest();
             }
             var lights = _context.LightsItems.FirstOrDefault( t => t.Id == id);
             if (lights == null)
             {
                 return NotFound();
             }

             lights.IsComplete = item.IsComplete;
             lights.Name = item.Name;

             _context.LightsItems.Update(lights);
             _context.SaveChanges();
             return new NoContentResult();

         }

         [HttpDelete ("{id}")]
         public IActionResult Delete(long id)
         {
             var lights = _context.LightsItems.First( t => t.Id == id);
             if (lights == null)
             {
                return NotFound();
             }

             _context.LightsItems.Remove(lights);
             _context.SaveChanges();
             return new NoContentResult();
         }
    }

    
}