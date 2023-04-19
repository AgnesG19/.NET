using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFit.Entidades
{
    internal class Cliente
    {
        public string IDCliente { get; set; }
        public string NombreCli { get; set; }
        public string AppellidoCli { get; set; }
        public string TelefonoCli { get; set; }
        public string MailCli { get; set; }
        public string ContrasenaPerfil { get; set; }
        public string ReservasActivas { get; set; }
        public string ColaReserva { get; set; }

    }
}
