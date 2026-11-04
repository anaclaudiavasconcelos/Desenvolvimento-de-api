using Api_PlataformaJogos.Models.Contexto;
using Api_PlataformaJogos.Models.Entidades;
using PlataformaJogosAPI.Classes.Controllers;


namespace PlataformaJogosAPI.Repositorio
{
    public class RepositorioJogo
    {
        //Campo
        private ContextoJogo contexto = new ContextoJogo();

        //Métodos
        public List<Jogo> ListarJogo()
        {
            var lista = contexto.Jogos.ToList();
            return lista;
        }

        public Jogo PesquisarJogoID(int id)
        {
            var pesquisar = contexto.Jogos.FirstOrDefault(p => p.Id == id);
            return pesquisar;
        }

        public void CadastrarJogo(Jogo jogo)
        {
            contexto.Jogos.Add(jogo);
            contexto.SaveChanges();
        }

        public bool EditarJogo(int id, Jogo jogo)
        {
            var existeUser = PesquisarJogoID(id);
            if (existeUser == null)
            {
                return false;
            }
            else
            {
                existeUser.Nome = jogo.Nome;
                existeUser.Descricao = jogo.Descricao;
                existeUser.Preco = jogo.Preco;
                existeUser.CategoriaId = jogo.CategoriaId;
                existeUser.EstudioId = jogo.EstudioId;
                contexto.SaveChanges();
                return true;
            }
        }

        public bool DeletarJogo(int id)
        {
            var existe = PesquisarJogoID(id);
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