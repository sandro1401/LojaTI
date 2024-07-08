using System.ComponentModel.DataAnnotations;

namespace LojaTI.Models
{
    public class Pedido
    {
        // Identificador único do pedido
        public int Id { get; set; }

        // Data em que o pedido foi feito
        public DateTime DataPedido { get; set; }

        // Identificador do cliente que fez o pedido
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        // Nome do cliente (pode ser opcional, caso você tenha uma tabela de clientes)
        public string NomeCliente { get; set; }

        // Lista de itens do pedido
        public List<ItemPedido> Itens { get; set; }

        // Valor total do pedido
        public decimal ValorTotal { get; set; }

        // Status do pedido (ex: Pendente, Enviado, Entregue, Cancelado)
        public SaleStatus Status { get; set; }

        // Endereço de entrega do pedido
        public string EnderecoEntrega { get; set; }

        // Método de pagamento (ex: Cartão de Crédito, Boleto, PayPal)
        public string MetodoPagamento { get; set; }

        // Observações adicionais sobre o pedido
        public string Observacoes { get; set; }

        // Construtor
        public Pedido()
        {
            Itens = new List<ItemPedido>();
        }
        public enum SaleStatus : int
        {
            PENDING = 0,
            BILLED = 1,
            CANCELED = 2
        }
    }
}
