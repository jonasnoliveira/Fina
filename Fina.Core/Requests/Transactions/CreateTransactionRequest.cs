using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Título é obrigatório")]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Tipo é obrigatório")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
    
    [Required(ErrorMessage = "Valor é obrigatório")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "Categoria é obrigatório")]
    public long CategoryId { get; set; }
    
    [Required(ErrorMessage = "Data é obrigatório")]
    public DateTime PaidOrReceivedAt { get; set; }
}