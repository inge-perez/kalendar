using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Shared.Entidades
{
    public class EstadoEvento
    {
        public int EstadoId { get; set; }
        public int EventoId { get; set; }
        public Estado Estado { get; set; }
        public Evento Evento { get; set; }
    }
}
