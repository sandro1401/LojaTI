namespace LojaTI.Models
{
    public class ItemPedido
    {
        // Identificador do item
        public int Id { get; set; }

        // Identificador do produto
        public int ProdutoId { get; set; }

        // Nome do produto
        public string NomeProduto { get; set; }

        // Quantidade do produto no pedido
        public int Quantidade { get; set; }

        // Preço unitário do produto
        public decimal PrecoUnitario { get; set; }

        // Total do item (Quantidade * PrecoUnitario)
        public decimal Total => Quantidade * PrecoUnitario;
    }
}
