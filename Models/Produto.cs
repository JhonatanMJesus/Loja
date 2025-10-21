namespace Loja.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public int Nome_produto { get; set; }

        public int Descricao_produto { get; set; }

        public decimal Preco { get; set; }

        public int Fk_id_categoria { get; set; }

        public List<Categoria>? categoria { get; set; }  //Pega o objeto inteiro e guarda só o id

    }
}
