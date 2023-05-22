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
       
        private ConexionBD conexion;
        private static string connectionString = "Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True";
        private string connectionString1;

        public ConsultasBD(string connectionString1)
        {
            this.connectionString1 = connectionString1;
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


        //*******************************************************************************************//


        //******* FORMS-MENU ADMINISTRADOR *******//

        // ******** BTN 1 - CREAR ACTIVIDAD

        //Comprueba si hay X Actividad creada en la BD para no sobrescribir, luego sino está se guarda en la TABA INSTANCIASACTIVIDADES.
        public static bool ComprobarActividad(string nombreActividad, string descripcion, string instructor, int plazas, DateTime fecha, TimeSpan hora)
        {
            
            // Realiza la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Construye la sentencia SQL para comprobar la existencia de la actividad
                string query = "SELECT COUNT(*) FROM Actividades WHERE NombreAct = @NombreAct AND Descripcion = @Descripcion AND Instructor = @Instructor AND Plazas = @Plazas";
                SqlCommand command = new SqlCommand(query, connection);

                // Asigna los valores a los parámetros de la sentencia SQL
                command.Parameters.AddWithValue("@NombreAct", nombreActividad);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Instructor", instructor);
                command.Parameters.AddWithValue("@Plazas", plazas);

                // Abre la conexión y ejecuta la sentencia SQL
                connection.Open();
                int count = (int)command.ExecuteScalar();

                // Si count es mayor que 0, la actividad ya existe
                return count > 0;
            }
        }

        //INSERTAR INSTANCIA DE ACT. en la Tabla.
        public static void InsertarInstanciaActividad(string nombreActividad, string descripcion, string instructor, int plazas, DateTime fecha, TimeSpan hora)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el ID de la actividad
                string actividadQuery = "SELECT IDActividad FROM Actividades WHERE NombreAct = @NombreAct AND Descripcion = @Descripcion AND Instructor = @Instructor AND Plazas = @Plazas";
                SqlCommand actividadCommand = new SqlCommand(actividadQuery, connection);
                actividadCommand.Parameters.AddWithValue("@NombreAct", nombreActividad);
                actividadCommand.Parameters.AddWithValue("@Descripcion", descripcion);
                actividadCommand.Parameters.AddWithValue("@Instructor", instructor);
                actividadCommand.Parameters.AddWithValue("@Plazas", plazas);

                int idActividad = (int)actividadCommand.ExecuteScalar();

                // Insertar en la tabla InstanciasActividad
                string insertInstanciaQuery = "INSERT INTO InstanciasActividad (IDActividad, Fecha, Hora) VALUES (@IDActividad, @Fecha, @Hora)";
                SqlCommand insertInstanciaCommand = new SqlCommand(insertInstanciaQuery, connection);
                insertInstanciaCommand.Parameters.AddWithValue("@IDActividad", idActividad);
                insertInstanciaCommand.Parameters.AddWithValue("@Fecha", fecha);
                insertInstanciaCommand.Parameters.AddWithValue("@Hora", hora);

                insertInstanciaCommand.ExecuteNonQuery();

                connection.Close();
            }
        }


        //INSERTAR ACTIVIDAD en la Tabla.
        public static void InsertarActividad(string nombreActividad, string descripcion, string instructor, int plazas)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Insertar en la tabla Actividades
                string query = "INSERT INTO Actividades (NombreAct, Descripcion, Instructor, Plazas) VALUES (@NombreAct, @Descripcion, @Instructor, @Plazas)";
                SqlCommand command = new SqlCommand(query, connection);

                // Asignar los valores a los parámetros de la sentencia SQL
                command.Parameters.AddWithValue("@NombreAct", nombreActividad);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Instructor", instructor);
                command.Parameters.AddWithValue("@Plazas", plazas);

                // Abrir la conexión y ejecutar la sentencia SQL
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        




        // ************* BTN 2 - LISTA DE ESPERA DE X ACTIVIDAD

        //MOSTRAR LAS ACTIVIDADES en la ComboBox para selecionar luego.
        public DataTable ConsultaActividades()
        {
            
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

        //Obtener la información de la LISTA DE ESPERA de UNA ACTIVIDAD ESPECIFICA
        //función vinculada a DataGridView
        public void MostrarListaEspera(int idActividad, DataGridView dataGridView)
        {
            // Obtener las reservas para la actividad seleccionada
            string queryReservas = "SELECT FechaReserva, HoraReserva, IDCliente, PosicionEnCola FROM Reservas WHERE IDActividad = @IDActividad";
            List<string[]> reservas = new List<string[]>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand commandReservas = new SqlCommand(queryReservas, connection);
                commandReservas.Parameters.AddWithValue("@IDActividad", idActividad);

                SqlDataReader reader = commandReservas.ExecuteReader();
                while (reader.Read())
                {
                    string fecha = reader.GetDateTime(0).ToString("yyyy-MM-dd");
                    string hora = reader.GetTimeSpan(1).ToString();
                    string idCliente = reader.GetInt32(2).ToString();
                    string posicionCola = reader.GetInt32(3).ToString();

                    string[] reserva = { fecha, hora, idCliente, posicionCola };
                    reservas.Add(reserva);
                }
                reader.Close();
            }

            // Limpiar las filas y columnas existentes en la DataGridView
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Agregar las columnas necesarias a la DataGridView
            dataGridView.Columns.Add("FechaReserva", "Fecha Reserva");
            dataGridView.Columns.Add("HoraReserva", "Hora Reserva");
            dataGridView.Columns.Add("IDCliente", "ID Cliente");
            dataGridView.Columns.Add("PosicionEnCola", "Posición en Cola");

            // Mostrar los datos en la DataGridView
            foreach (string[] reserva in reservas)
            {
                dataGridView.Rows.Add(reserva);
            }
        }



        // ******** BTN 3 - CONSULTA LISTA DE RESERVAS DE X ACTIVIDAD

        //Muestra la Tabla RESERVAS
        public static DataTable ObtenerReservas()
        {
            string query = "SELECT * FROM Reservas";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

    }
}
