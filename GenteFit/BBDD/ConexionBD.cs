using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GenteFit.BBDD
{
    internal class ConexionBD{

        private SqlConnection BD;

        public ConexionBD()
        {
            //this.BD = new SqlConnection("Server=FRANKY-PC\\NET;Database=GenteFITBD;user ID=Franky-PC\\Franky;Password=;");
            this.BD = new SqlConnection("Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True");
        }

        public bool Conectar()
        {
            try
            {
                this.BD.Open();
                return true;
            }catch(SqlException ex)
            {
                return false;
            }
        }
        public void Desconectar()
        {
            this.BD.Close();
            
        }
    
    }

}
