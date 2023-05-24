using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GenteFit.Entidades
{
   
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string NombreCli { get; set; }
        public string ApellidoCli { get; set; }
        public string TelefonoCli { get; set; }
        public string MailCli { get; set; }
        public string ContrasenaPerfil { get; set; }
        public int ReservasActivas { get; set; }
        public int ColaReserva { get; set; }
        public int SesionIniciada { get; set; }

    }


}
