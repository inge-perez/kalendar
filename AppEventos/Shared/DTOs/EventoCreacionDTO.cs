using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppEventos.Shared.DTOs
{
    public class EventoCreacionDTO
    {
        public int UsuarioId { get; set; }
        [Required]
        public int MunicipioId { get; set; }
        [Required]
        public Guid CategoriaId { get; set; }
        [Required]
        public int DepartamentoId { get; set; }
        public int EstadoId { get; set; }
        public DateTime FechaPublicacion { get; set; }
        [Required]
        public DateTime FechaEvento { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Nombre del evento mínimo 8 caracteres", MinimumLength = 8)]
        public string NombreEvento { get; set; }
        [Required]
        [StringLength(180, ErrorMessage = "Descripción del evento mínimo 8 caracteres", MinimumLength = 8)]
        public string DescripcionEvento { get; set; }
        public string Imagen { get; set; }
    }
}
