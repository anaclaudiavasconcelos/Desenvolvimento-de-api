using System.ComponentModel.DataAnnotations;

namespace Api_PlataformaJogos.Models.Entidades
{
    public class Estudio
    {
        //Propriedades
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        public string Pais { get; set; }

        //Construtor
        public Estudio(string nome, string pais)
        {
            Nome = nome;
            Pais = pais;
        }
    }
}
