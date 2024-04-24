using System.ComponentModel.DataAnnotations;

namespace JimmyAlbarracin_Examen1P.Models
{
    public class JA_Tabla1
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string NombreVideojuego { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public bool ContenidoPremium { get; set; }
        [Range(0.01, 999.99)]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Fecha { get; set; }

    }
}
