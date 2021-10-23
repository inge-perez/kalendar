using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Shared.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        //Rechazado,Pendiente,Aprobado
        public string Valor { get; set; }
    }
}
