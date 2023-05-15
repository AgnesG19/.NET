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


        //******* FORMS-MENU ADMINISTRADOR *******//

        //MOSTRAR LAS ACTIVIDADES en la ComboBox para selecionar luego.
        public DataTable ConsultaActividades()
        {
            
            string connectionString = "Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Crear el comando SQL para obtener las actividades
            string query = "SELECT IDActividad, NombreAct FROM Actividades";
            SqlCommand command = new SqlCommand(query, connection);

            // Crear el adaptador de datos y obtener los datos en un DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Devolver el DataTable con los datos de las actividades
            return dt;
        }

        //INSERTAR RESERVA en la TABLA RESERVA
        public void InsertarReserva(int idCliente, int idActividad, DateTime fecha, DateTime hora, int posicion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Reservas (IDCliente, IDActividad, Fecha, Hora, Posicion) " +
                               "VALUES (@idCliente, @idActividad, @fecha, @hora, @posicion)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@idActividad", idActividad);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@hora", hora);
                    command.Parameters.AddWithValue("@posicion", posicion);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Obtener la información de las reservas de UNA ACTIVIDAD ESPECIFICA
        //función vinculada a ActualizarDataGridView
        public DataTable ConsultaReservasActividad(int idActividad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Reservas.IDCliente, Cliente.NombreCli, Cliente.ApellidoCli, Reservas.FechaReserva, Reservas.HoraReserva, Reservas.PosicionEnCola " +
                               "FROM Reservas " +
                               "INNER JOIN Actividades ON Reservas.IDActividad = Actividades.IDActividad " +
                               "INNER JOIN Cliente ON Reservas.IDCliente = Cliente.IDCliente " +
                               "WHERE Reservas.IDActividad = @idActividad " +
                               "ORDER BY Reservas.PosicionEnCola";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idActividad", idActividad);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }




    }
}
