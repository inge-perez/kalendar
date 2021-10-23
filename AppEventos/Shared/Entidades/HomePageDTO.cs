using AppEventos.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppEventos.Shared.DTOs
{
    public class HomePageDTO
    {
        public List<Evento> PeliculasEnCartelera { get; set; }
        public List<Evento> ProximosEstrenos { get; set; }
    }
}
