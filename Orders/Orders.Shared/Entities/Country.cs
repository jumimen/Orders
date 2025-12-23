using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities;

public class Country
{
    public int Id { get; set; }

    //[Display("País")]
    [MaxLength(80, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string Name { get; set; } = null!;
}