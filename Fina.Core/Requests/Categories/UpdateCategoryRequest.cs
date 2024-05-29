using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }
    
    [Required (ErrorMessage = "Título é obrigatório")]
    [MaxLength(80, ErrorMessage = "Título deve ter no maximo 80 caracteres")]
    public string Title { get; set; }
    
    [MaxLength(255, ErrorMessage = "Descricão deve ter no maximo 255 caracteres")]
    public string? Description { get; set; }
}