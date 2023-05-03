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

        //******* FORMS-INICIO APP *******//
        //Comprueba si ya existe el Mail y la Contraseña en las tablas CLIENTE Y ADMINISTRADOR(INICIO SESION)
        public bool VerificarExistencia(string email, string contrasena)
        {
            using (SqlConnection connection = this.conexion.GetConnection()) // obtiene la conexión a la base de datos desde la instancia de ConexionBD
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM (SELECT MailCli AS Mail, ContrasenaPerfil AS Contrasena FROM CLIENTE UNION SELECT MailAdmin AS Mail, ContrasenaAdmin AS Contrasena FROM ADMINISTRADOR) AS Usuarios WHERE Mail = @Email AND Contrasena = @Contrasena", connection);
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

        //Registra al Cliente como Usuario con sus datos (REGISTRO)
        public bool RegistrarUsuario(string nombre, string apellido, string email, string telefono, string contrasena)
        {
            using (SqlConnection connection = this.conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO CLIENTE(NombreCli, ApellidoCli, MailCli, TelefonoCli, ContrasenaPerfil) VALUES (@Nombre, @Apellido, @Email, @Telefono, @Contrasena)", connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario en la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
