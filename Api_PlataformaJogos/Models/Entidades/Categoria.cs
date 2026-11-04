using System.ComponentModel.DataAnnotations;

namespace Api_PlataformaJogos.Models.Entidades
{
    public class Categoria
    {
        //Propriedades
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Construtor
        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
