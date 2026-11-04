using Api_PlataformaJogos.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using PlataformaJogosAPI.Repositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlataformaJogosAPI.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        RepositorioJogo rep = new RepositorioJogo();

        /// <summary>
        /// Obtém a lista de jogos
        /// </summary>
        /// <returns></returns>

        // GET: api/<JogoController>
        [HttpGet]
        public IEnumerable<Jogo> Get()
        {
            return rep.ListarJogo();
        }

        /// <summary>
        /// Obtém o jogo pelo identificador informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/<JogoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(rep.PesquisarJogoID(id));
        }

        /// <summary>
        /// Cadastrar um novo jogo. 
        /// </summary>
        /// <param name="value"></param>
        // POST api/<JogoController>
        [HttpPost]
        public IActionResult Post([FromBody] Jogo jogo)
        {
            try
            {
                rep.CadastrarJogo(jogo);
                return Created(string.Empty, jogo);
            }
            catch (Exception ex)
            {

                return Conflict(ex.Message);
            }
        }

        /// <summary>
        ///  Edita os dados do jogo.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>

        // PUT api/<JogoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Jogo jogo)
        {
            try
            {
                if (rep.EditarJogo(id, jogo))
                {
                    return Ok("Jogo atualizado com sucesso");
                }
                else
                {
                    return NotFound("Jogo não encontrado");
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Exclui um jogo pelo identificador informado.
        /// </summary>
        /// <param name="id"></param>

        // DELETE api/<JogoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (rep.DeletarJogo(id))
                {
                    return Ok("Jogo deletado com sucesso!");
                }
                else
                {
                    return NotFound("Jogo não encontrado");
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}