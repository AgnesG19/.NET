using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GenteFit.BBDD
{
    internal class ConexionBD{

        private SqlConnection BD;

        public ConexionBD()
        {
            this.BD = new SqlConnection("Server=Franky-PC\\NET ; Database=GenteFITBD ; userID=Franky-PC\\Franky ; Password=;");
        }

        public bool Conectar()
        {
            try
            {
                this.BD.Open();
                ImprimirEstadoConexion();
                return true;
            }catch(SqlException ex)
            {
                return false;
            }
        }
        public void Desconectar()
        {
            this.BD.Close();
            ImprimirEstadoConexion();
        }

        private void ImprimirEstadoConexion()
        {
            Console.WriteLine("El estado de la conexión es: " + this.BD.State.ToString());
        }
    }

}
