using EncuestasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    [ApiController]
    [Route("api/preguntas")]
    public class PreguntasController : Controller
    {
        private DB db;
        public PreguntasController(DB database)
        {
            this.db = database;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Preguntas>> Get()
        {
            return Ok(db.Preguntas.ToList());
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
                var item = await db.Preguntas.FindAsync(id);
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
        public ActionResult Post([FromBody] Preguntas json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Iinvalid information");

            db.Preguntas.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Preguntas json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Information");
            var dbjson = db.Preguntas.Where(a => a.IdPreguntas == json.IdPreguntas).FirstOrDefault();
            if (dbjson == null) ;
            return BadRequest($"Category with id json.id not found");
            dbjson.IdPreguntas = json.IdPreguntas;
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
            var dbjson = db.Preguntas.Where(a => a.IdPreguntas == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Pregunta with id int not found");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }
    }
}
