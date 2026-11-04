using Api_PlataformaJogos.Models.Contexto;
using Api_PlataformaJogos.Models.Entidades;

namespace Api_PlataformaJogos.Repositorios
{
    public class RepositorioEstudio
    {
        //Campo
        private ContextoEstudio contexto = new ContextoEstudio();

        //Métodos
        public List<Estudio> ListarEstudio()
        {
            var lista = contexto.Estudios.ToList();
            return lista;
        }

        public Estudio PesquisarEstudioID(int id)
        {
            var pesquisar = contexto.Estudios.FirstOrDefault(e => e.Id == id);
            return pesquisar;
        }

        public void CadastrarNovoEstudio(Estudio estudio)
        {
            contexto.Estudios.Add(estudio);
            contexto.SaveChanges();
        }

        public bool EditarEstudio(int id, Estudio estudio)
        {
            var existeUser = PesquisarEstudioID(id);
            if (existeUser == null)
            {
                return false;
            }
            else
            {
                existeUser.Nome = estudio.Nome;
                existeUser.Pais = estudio.Pais;
                contexto.SaveChanges();
                return true;
            }

        }

        public bool DeletarEstudio(int id)
        {
            var existe = PesquisarEstudioID(id);
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
