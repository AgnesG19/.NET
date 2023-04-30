using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido para SQL y Forms
using System.Data.SqlClient;
using System.Windows.Forms;
using GenteFit.BBDD;

namespace GenteFit.Consultas
{
    internal class ConsultasBD
    {
        private string connectionString;
        private ConexionBD conexion;

        public ConsultasBD(string connectionString)
        {
            this.connectionString = connectionString;
            this.conexion = new ConexionBD();
        }


        //Comprueba si ya existe el Mail y la Contraseña (INICIO SESION)
        public bool VerificarExistencia(string email, string contrasena)
        {
            using (SqlConnection connection = this.conexion.GetConnection()) // obtiene la conexión a la base de datos desde la instancia de ConexionBD
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM CLIENTE WHERE MailCli = @Email AND ContrasenaPerfil = @Contrasena", connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar existencia de datos en la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
