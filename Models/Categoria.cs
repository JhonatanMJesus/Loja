namespace Loja.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string? Descritivo { get; set; }

        public int Fk_id_produto { get; set; }

        public Produto? produto { get; set; }

    }
}
