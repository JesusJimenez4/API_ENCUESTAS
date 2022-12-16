using EncuestasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    [ApiController]
    [Route("api/encuestas")]
    public class EncuestaController : Controller
    {
        private DB db;
        public EncuestaController(DB database)
        {
            this.db = database;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Encuesta>> Get()
        {
            return Ok(db.Encuesta.ToList());
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
                var item = await db.Encuesta.FindAsync(id);
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
        public ActionResult Post([FromBody] Encuesta json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Iinvalid information");

            db.Encuesta.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Encuesta json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Information");
            var dbjson = db.Encuesta.Where(a => a.IdEncuesta == json.IdEncuesta).FirstOrDefault();
            if (dbjson == null) ;
            return BadRequest($"Category with id json.id not found");
            dbjson.IdEncuesta = json.IdEncuesta;
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
            var dbjson = db.Encuesta.Where(a => a.IdEncuesta == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Encuesta with id int not found");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }
    }
}
