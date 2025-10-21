namespace Loja.Models
{
    public class Compra
    {
        public int Id { get; set; }

        public DateTime Data_compra { get; set; }

        public string? Fk_id_usuario { get; set; }

        public int Fk_id_item { get; set; }

        public Usuario? usuario { get; set; }

        public List<Itens>? item { get; set; } //uma compra pode ter vários itens

        //public ICollection<Itens> item { get; set; }
        /* Tem que dar foreach pra conseguir todos os objetos da coleção
           E em List é só usar .Find()*/
    }
}
