using Orders.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Entities
{
    public class City : IEntityWithName
    {
        public int Id { get; set; }

        [Display(Name = "Ciudad")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [RegularExpression(
        @"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$",
        ErrorMessage = "El campo {0} solo permite letras y espacios."
    )]
        public string Name { get; set; } = null!;

        public int StateId { get; set; }
        public State? State { get; set; } = null!;
    }
}