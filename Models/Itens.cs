namespace Loja.Models
{
    public class Itens
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public int Fk_id_compra { get; set; }

        public int Fk_id_produto { get; set; }

        public Compra? compra { get; set; }

        public Produto? produto { get; set; }
    }
}
