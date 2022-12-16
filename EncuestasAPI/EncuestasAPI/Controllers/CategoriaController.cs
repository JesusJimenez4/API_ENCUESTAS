using EncuestasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    [ApiController]
    [Route("api/categoria")]
    public class CategoriaController : Controller
    {
        private DB db; 
        public CategoriaController(DB database)
        {
            this.db = database;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Cateegoria>> Get()
        {
            return Ok(db.Cateegoria.ToList());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Find(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            try
            {
                var item = await db.Cateegoria.FindAsync(id);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
            

        }
        [HttpPost]
        public ActionResult Post([FromBody] Cateegoria json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Iinvalid information");

            db.Cateegoria.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cateegoria json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Information");
            var dbjson = db.Cateegoria.Where(a => a.Id == json.Id).FirstOrDefault();
            if (dbjson == null) ;
            return BadRequest($"Category with id json.id not found");
            dbjson.Id = json.Id;
            db.Update(dbjson);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int? id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Information");
            var dbjson = db.Cateegoria.Where(a => a.Id == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Category with id int not found");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }

    }
}
