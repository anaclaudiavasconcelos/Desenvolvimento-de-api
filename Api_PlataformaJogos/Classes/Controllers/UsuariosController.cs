using Api_PlataformaJogos.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using PlataformaJogosAPI.Repositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlataformaJogosAPI.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        RepositorioUsuario rep = new RepositorioUsuario();

        /// <summary>
        /// Obtém a lista de usuário.
        /// </summary>
        /// <returns></returns>

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return rep.ListarUsuario();
        }

        /// <summary>
        /// Obtém o usuário pelo identificador informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(rep.PesquisarUsuarioID);
        }

        /// <summary>
        /// Cadastra um novo usuário.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        // POST api/<UsuarioController>
        [HttpPost]
        public IActionResult Post([FromBody] Usuario user)
        {
            try
            {
                rep.CadastrarNovoUsuario(user);
                return CreatedAtAction(
                    nameof(Get),
                    new { id = user.Id },
                    user
                );
            }
            catch (Exception ex)
            {

                return Conflict(ex.Message);
            }
        }

        /// <summary>
        /// Atualiza os dados do usuário.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Usuario user)
        {
            try
            {
                if (rep.EditarUsuario(id, user))
                {
                    return Ok("Conta atualizado com sucesso!");
                }
                else
                {
                    return NotFound("Conta não encontrada.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        /// <summary>
        /// Exclui um usuario pelo identificador informado.
        /// </summary>
        /// <param name="id"></param>

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (rep.DeletarUsuario(id))
                {
                    return Ok("Usuario deletado com sucesso!");
                }
                else
                {
                    return NotFound("Usuário não encontrado.");
                }

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}