using Api_PlataformaJogos.Models.Contexto;
using Api_PlataformaJogos.Models.Entidades;


namespace PlataformaJogosAPI.Repositorio
{
    public class RepositorioCategoria
    {
        //Campo
        private ContextoCategoria contexto = new ContextoCategoria();

        //Métodos
        public List<Categoria> ListarCategoria()
        {
            var lista = contexto.Categorias.ToList();
            return lista;
        }

        public Categoria PesquisarCategoriaID(int id)
        {
            var pesquisar = contexto.Categorias.FirstOrDefault(c => c.Id == id);
            return pesquisar;
        }

        public void CadastrarCategoria(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public bool EditarCategoria(int id, Categoria categoria)
        {
            var existeUser = PesquisarCategoriaID(id);
            if (existeUser == null)
            {
                return false;
            }
            else
            {
                existeUser.Nome = categoria.Nome;
                existeUser.Descricao = categoria.Descricao;
                contexto.SaveChanges();
                return true;

            }
        }

        public bool DeletarCategoria(int id)
        {
            var existe = PesquisarCategoriaID(id);
            if (existe == null)
            {
                return false;
            }
            else
            {
                contexto.Remove(existe);
                contexto.SaveChanges();
                return true;
            }
        }


    }
}