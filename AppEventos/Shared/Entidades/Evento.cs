using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Shared.Entidades
{
    public class Evento
    {
        public int Id { get; set; }
        //public int UsuarioId { get; set; }
        public int MunicipioId { get; set; }
        public int CategoriaId { get; set; }
        public int EstadoId { get; set; }
        public CategoriaEvento CategoriaEvento { get; set; }
        public EstadoEvento EstadoEvento{ get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        [Required]
        public DateTime FechaEvento { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "El nombre no debe de tener más de 50 caracteres, ni menos de 3 caracteres.")]
        public string NombreEvento { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 3,
            ErrorMessage = "La descripcion no debe de tener más de 255 caracteres, ni menos de 3 caracteres.")]
        public string DescripcionEvento { get; set; }
        public string Imagen { get; set; }
        //public Usuario Usuario { get; set; }
        public Municipio Municipio { get; set; }
        public Departamento Departamento { get; set; }
        public Categoria Categoria { get; set; }
        public Estado Estado { get; set; }
    }
}
