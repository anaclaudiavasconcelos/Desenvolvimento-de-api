using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api_PlataformaJogos.Models.Entidades
{
    public class Jogo
    {
        //Propriedades
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [Required]
        public int EstudioId { get; set; }

        //Construtor
        public Jogo(string nome, string descricao, decimal preco, int categoriaId, int estudioId)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            CategoriaId = categoriaId;
            EstudioId = estudioId;
        }
    }
}
