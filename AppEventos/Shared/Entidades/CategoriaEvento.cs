using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Shared.Entidades
{
    public class CategoriaEvento
    {
        public int CategoriaId { get; set; }
        public int EventoId { get; set; }
        public Categoria Categoria { get; set; }
        public Evento Evento { get; set; }
    }
}
