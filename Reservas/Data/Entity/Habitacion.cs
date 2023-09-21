using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservas.BData.Data.Entity
{
    public class Habitacion
	{
		public int Id { get; set; }
        [Required]
        public string Nhab { get; set; }

		[Required]
		public int Camas { get; set; }

		[Required(ErrorMessage = "El estado es Obligatorio")]
		public string Estado { get; set; } = "";

	
        public Reserva Reserva { get; set; }
    }
}
