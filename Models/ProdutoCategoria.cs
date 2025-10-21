namespace Loja.Models
{
    public class ProdutoCategoria
    {
        public int Id { get; set; }

        public int Fk_id_produto { get; set; }

        public int Fk_id_categoria { get; set; }

        public Produto? produto { get; set; }

        public Categoria? categoria { get; set; }
    }
}
