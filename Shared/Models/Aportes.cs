using System.ComponentModel.DataAnnotations;

namespace BlazorWASM_1ero.Shared.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Persona { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Observación { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Range(1, float.MaxValue, ErrorMessage = "Este Campo no puede ser <=0")]
        public float Monto { get; set; }
    }
}
