using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFit.Entidades
{
    public class Actividades
    {
        public int IDActividad { get; set; }
        public string NombreAct { get; set; }
        public string Descripcion { get; set; }
        public string Instructor { get; set; }
        public DateTime Horario { get; set; }
        public float Precio { get; set; }
        //public int Reservas { get; set; }
        //public int EnCola { get; set; }


    }
}
