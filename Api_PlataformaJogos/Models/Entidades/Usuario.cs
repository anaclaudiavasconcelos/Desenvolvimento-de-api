using System.ComponentModel.DataAnnotations;

namespace Api_PlataformaJogos.Models.Entidades
{
    public class Usuario
    {
        //Propriedades
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Senha { get; set; }

        //Construtor    
        public Usuario()
        {
            
        }

        public Usuario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

    }
}
