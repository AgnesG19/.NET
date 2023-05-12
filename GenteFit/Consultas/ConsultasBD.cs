using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadido para SQL y Forms
using System.Data.SqlClient;
using System.Windows.Forms;
using GenteFit.BBDD;
using System.Data;

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
        //Comprueba si ya existe el Mail y la Contraseña en las tablas CLIENTE Y ADMINISTRADOR (INICIO SESION)
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
                    MessageBox.Show("Error al verificar existencia de datos en la BD: " + ex.Message);
                    return false;
                }
            }
        }
        //Comprueba el TIPO DE USUARIO para acceder luego a un Menu (ACCEDER APP)
        public string ObtenerTipoUsuario(string email)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT TOP 1 TipoUsuario FROM (SELECT 'Cliente' AS TipoUsuario FROM CLIENTE WHERE MailCli = @Email UNION ALL SELECT 'Administrador' AS TipoUsuario FROM ADMINISTRADOR WHERE MailAdmin = @Email) AS TiposUsuario", connection);
                    command.Parameters.AddWithValue("@Email", email);
                    string tipoUsuario = (string)command.ExecuteScalar();
                    return tipoUsuario;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener tipo de usuario desde la base de datos: " + ex.Message);
                    return null;
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
                    MessageBox.Show("Error al registrar usuario en la BD: " + ex.Message);
                    return false;
                }
            }
        }


        //*******************************************************************************//


        //******* FORMS-ADMINISTRADOR *******//
        //Consultar la lista de espera de los Clientes+Actividad 
        public DataTable ConsultaListaEspera()
        {
            using (SqlConnection connection = this.conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT c.IDCliente, c.NombreCli, c.ReservasActivas, c.ColaReserva, a.IDActividad, a.NombreAct, a.Horario " +
                                   "FROM CLIENTE c " +
                                   "JOIN Actividades a ON c.IDActividad = a.IDActividad";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la lista de espera: " + ex.Message);
                    return null;
                }
            }
        }



    }
}
