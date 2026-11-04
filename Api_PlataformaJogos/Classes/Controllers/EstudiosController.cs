using Microsoft.AspNetCore.Mvc;
using Api_PlataformaJogos.Repositorios;
using Api_PlataformaJogos.Models.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api_PlataformaJogos.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiosController : ControllerBase
    {
        RepositorioEstudio rep = new RepositorioEstudio();

        // GET: api/<EstudioController>
        [HttpGet]
        public IEnumerable<Estudio> Get()
        {
            return rep.ListarEstudio();
        }

        // GET api/<EstudioController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok( rep.PesquisarEstudioID(id));
        }

        // POST api/<EstudioController>
        [HttpPost]
        public IActionResult Post([FromBody] Estudio estudio)
        {
            try
            {
            rep.CadastrarNovoEstudio(estudio);
            return Created("Estúdio cadastrado com sucesso!", estudio);

            }
            catch (Exception ex)
            {

                return Conflict(ex.Message);
            }
        }

        // PUT api/<EstudioController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Estudio estudio)
        {
            try
            {
                if (rep.EditarEstudio(id, estudio))
                {
                    return Ok("Estúdio atualizado com sucesso!");
                }
                else
                {
                    return NotFound("Estúdio não encontrado!");
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }

        // DELETE api/<EstudioController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
            if (rep.DeletarEstudio(id))
            {
                return Ok("Estúdio deletado com sucesso!");
            }
            else
            {
                return NotFound("Estúdio não encontrado!");
            }

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
