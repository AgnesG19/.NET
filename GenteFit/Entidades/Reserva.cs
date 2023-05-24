using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFit.Entidades
{
    public class Reserva
    {
        public int IDReserva { get; set; }
        public int IDCliente { get; set; }
        public int IDActividad { get; set; }
        public int IDInstanciaActividad { get; set; }
        public DateTime FechaReserva { get; set; }
        public TimeSpan HoraReserva { get; set; }
        public int PosicionEnCola { get; set; }
    }

}
