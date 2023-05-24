using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFit.Entidades
{
    internal class InstanciasActividad
    {
        public int IdInstanciaActividad { get; set; }
        public int IdActividad { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string NombreAct { get; set; }
        public string Descripcion { get; set; }
        public string Instructor { get; set; }
        public int Plazas { get; set; }
    }
}
