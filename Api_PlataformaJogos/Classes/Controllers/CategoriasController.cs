using Api_PlataformaJogos.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using PlataformaJogosAPI.Repositorio;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlataformaJogosAPI.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        RepositorioCategoria rep = new RepositorioCategoria();


        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return rep.ListarCategoria();
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(rep.PesquisarCategoriaID(id));
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public IActionResult Post([FromBody] Categoria categoria)
        {
            try
            {
                rep.CadastrarCategoria(categoria);
                return Created("Categoria cadastrada com sucesso!", categoria);
            }
            catch (Exception ex)
            {
                return Conflict(ex.Message);
            }
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Categoria categoria)
        {
            try
            {
                if (rep.EditarCategoria(id, categoria))
                {
                    return Ok("Categoria atualizada com sucesso!");
                }
                else
                {
                    return NotFound("Categoria não encontrada!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (rep.DeletarCategoria(id))
                {
                    return Ok("Categoria deletada com sucesso!");
                }
                else
                {
                    return NotFound("Categoria não encontrada!");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}