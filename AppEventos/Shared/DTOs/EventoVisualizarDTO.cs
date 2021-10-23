using AppEventos.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppEventos.Shared.DTOs
{
    public class EventoVisualizarDTO : EventoDTO
    {
        public string NombreUsuario { get; set; }
        public string DescripcionCategoria { get; set; }
        public string NombreDepartamento { get; set; }
        public string NombreMunicipio { get; set; }
        public string DescripcionEvento { get; set; }
    }
}
