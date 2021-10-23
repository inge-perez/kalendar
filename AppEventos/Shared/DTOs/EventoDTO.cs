using AppEventos.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Shared.DTOs
{
    public class EventoDTO
    {
        public int EventoId { get; set; }
        //public int UsuarioId { get; set; }
        public Municipio Municipio { get; set; }
        public Departamento Departamento { get; set; }
        public Categoria Categoria { get; set; }
        //public int CategoriaId { get; set; }
        //public int EstadoId { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaEvento { get; set; }
        public string NombreEvento { get; set; }
        //public string DescripcionEvento { get; set; }
        public string Imagen { get; set; }
        
    }
}
