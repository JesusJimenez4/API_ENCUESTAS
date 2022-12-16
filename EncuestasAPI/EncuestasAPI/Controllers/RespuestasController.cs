using EncuestasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    [ApiController]
    [Route("api/respuestas")]
    public class RespuestasController : Controller
    {
        private DB db;
        public RespuestasController(DB database)
        {
            this.db = database;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Respuestas>> Get()
        {
            return Ok(db.Respuestas.ToList());
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
                var item = await db.Respuestas.FindAsync(id);
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
        public ActionResult Post([FromBody] Respuestas json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Iinvalid information");

            db.Respuestas.Add(json);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Respuestas json)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Information");
            var dbjson = db.Respuestas.Where(a => a.IdRespuesta == json.IdRespuesta).FirstOrDefault();
            if (dbjson == null) ;
            return BadRequest($"Category with id json.id not found");
            dbjson.IdRespuesta = json.IdRespuesta;
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
            var dbjson = db.Respuestas.Where(a => a.IdRespuesta == id).FirstOrDefault();
            if (dbjson == null)
                return BadRequest($"Encuesta with id int not found");
            db.Remove(dbjson);
            db.SaveChanges();
            return Ok();
        }
    }
}
