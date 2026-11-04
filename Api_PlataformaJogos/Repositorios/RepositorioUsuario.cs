using Api_PlataformaJogos.Models.Contexto;
using Api_PlataformaJogos.Models.Entidades;
using System.Security.Cryptography;

namespace PlataformaJogosAPI.Repositorio
{
    public class RepositorioUsuario
    {
        //Campo
        private ContextoUsuario contexto = new ContextoUsuario();

        //Métodos
        public List<Usuario> ListarUsuario()
        {
            var lista = contexto.Usuarios.ToList();
            return lista;
        }

        public Usuario PesquisarUsuarioID(int id)
        {
            var pesquisar = contexto.Usuarios.FirstOrDefault(u => u.Id == id);
            return pesquisar;
        }

        public void CadastrarNovoUsuario(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public bool EditarUsuario(int id, Usuario user)
        {
            var existeUser = PesquisarUsuarioID(id);
            if (existeUser == null)
            {
                return false;
            }
            else
            {
                existeUser.Email = user.Email;
                existeUser.Senha = user.Senha;
                contexto.SaveChanges();
                return true;

            }


        }

        public bool DeletarUsuario(int id)
        {
            var existe = PesquisarUsuarioID(id);
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