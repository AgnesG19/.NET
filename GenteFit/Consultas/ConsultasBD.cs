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
using GenteFit.Entidades;
using System.Globalization;
using System.Web;

namespace GenteFit.Consultas
{
    internal class ConsultasBD
    {
       
        //private ConexionBD conexion;
        //private static string connectionString = "Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True";
        //private string connectionString;

        //public ConsultasBD(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //    this.conexion = new ConexionBD(connectionString);
        //}

        private ConexionBD conexion;
        private static string connectionString = "Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True";

        public ConsultasBD()
        {
            this.conexion = new ConexionBD(connectionString); // Inicializa la variable conexion con una instancia de ConexionBD
        }




        //******* FORMS-INICIO APP *******//
        //Comprueba si ya existe el Mail y la Contraseña en las tablas CLIENTE Y ADMINISTRADOR (INICIO SESION)
        public bool VerificarExistencia(string email, string contrasena)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM (SELECT MailCli AS Mail, ContrasenaPerfil AS Contrasena FROM CLIENTE UNION SELECT MailAdmin AS Mail, ContrasenaAdmin AS Contrasena FROM ADMINISTRADOR) AS Usuarios WHERE Mail = @Email AND Contrasena = @Contrasena", connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Actualizar la columna SesionIniciada a true
                        SqlCommand updateCommand = new SqlCommand("UPDATE Cliente SET SesionIniciada = 1 WHERE MailCli = @Email", connection);
                        updateCommand.Parameters.AddWithValue("@Email", email);
                        updateCommand.ExecuteNonQuery();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        //MOSTRAR LAS ACTIVIDADES en la Tabla para selecionar luego.
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


        //*******************************************************************************************//


        //******* FORMS-MENU CLIENTE *******//

        // ************* BTN 1 ACTIVIDAD
        //LISTA de la Tabla INSTANCIASACT para que el cliente pueda reservar
        public List<InstanciasActividad> ObtenerInstanciasActividadesDisponibles()
        {
            List<InstanciasActividad> instanciasDisponibles = new List<InstanciasActividad>();
            bool error = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT IA.IDInstanciaActividad, IA.IDActividad, IA.Fecha, IA.Hora, A.NombreAct, A.Descripcion, A.Instructor, A.Plazas " +
                                   "FROM InstanciasActividad IA " +
                                   "INNER JOIN Actividades A ON IA.IDActividad = A.IDActividad ";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idInstanciaActividad = (int)reader["IDInstanciaActividad"];
                        int idActividad = (int)reader["IDActividad"];
                        DateTime fecha = (DateTime)reader["Fecha"];
                        TimeSpan hora = (TimeSpan)reader["Hora"];
                        string nombreActividad = reader.GetString(reader.GetOrdinal("NombreAct"));
                        string descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));
                        string instructor = reader.GetString(reader.GetOrdinal("Instructor"));
                        int plazas = reader.GetInt32(reader.GetOrdinal("Plazas"));

                        InstanciasActividad instancia = new InstanciasActividad
                        {
                            IdInstanciaActividad = idInstanciaActividad,
                            IdActividad = idActividad,
                            Fecha = fecha,
                            Hora = hora,
                            NombreAct = nombreActividad,
                            Descripcion = descripcion,
                            Instructor = instructor,
                            Plazas = plazas
                        };

                        instanciasDisponibles.Add(instancia);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                error = true;
                MessageBox.Show("Error al cargar las instancias de actividad: " + ex.Message);
            }

            if (error)
            {
                MessageBox.Show("No se pudieron cargar las instancias de actividad. Por favor, inténtalo de nuevo más tarde.");
            }

            return instanciasDisponibles;
        }


        //Comprueba qué cliente ha iniciado sesion para obtener su mail
        public static Cliente ObtenerClienteActual()
        {
            Cliente clienteActual = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obtener el cliente actualmente conectado
                    string query = "SELECT * FROM Cliente WHERE SesionIniciada = 1";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        clienteActual = new Cliente();
                        clienteActual.IDCliente = Convert.ToInt32(reader["IDCliente"]);
                        clienteActual.MailCli = reader["MailCli"].ToString();
                        
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el cliente actual: " + ex.Message);
            }

            return clienteActual;
        }

        public static int ObtenerIdCliente()
        {
            int idCliente = 0;

            try
            {
                Cliente clienteActual = ObtenerClienteActual();
                if (clienteActual != null)
                {
                    idCliente = clienteActual.IDCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
            }

            return idCliente;
        }
        
        //REALIZAR RESERVAS INSTANCIAS selecionada en la DataGridView
        public static bool RealizarReserva(int idCliente, InstanciasActividad instancia, DateTime fechaReserva, TimeSpan horaReserva)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Reservas (IDCliente, IDActividad, FechaReserva, HoraReserva, IDInstanciaActividad)" +
                        "VALUES (@IDCliente, @IDActividad, @FechaReserva, @HoraReserva, @IDInstanciaActividad)", connection);
                    command.Parameters.AddWithValue("@IDCliente", idCliente);
                    command.Parameters.AddWithValue("@IDActividad", instancia.IdActividad);
                    command.Parameters.AddWithValue("@FechaReserva", fechaReserva);
                    command.Parameters.AddWithValue("@HoraReserva", horaReserva);
                    command.Parameters.AddWithValue("@IDInstanciaActividad", instancia.IdInstanciaActividad);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la reserva: " + ex.Message);
                return false;
            }
        }

        // BTN  2 - MOSTRAR RESERVAS

        //ELIMINA la RESERVA DEL CLIENTE
        public static bool EliminarReserva(int idReserva)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Reservas WHERE IDReserva = @IDReserva", connection);
                    command.Parameters.AddWithValue("@IDReserva", idReserva);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la reserva: " + ex.Message);
                return false;
            }
        }

      
        //ACTUALIZA la DataGrid de Mostrar Reservas 
        public static void ActualizarListaReservasCliente(DataGridView dataGridView_ReservaCli, int idCliente)
        {
            try
            {
                // Limpiar la fuente de datos del DataGridView
                dataGridView_ReservaCli.DataSource = null;

                // Obtener las reservas del cliente
                List<Reserva> reservas = ConsultasBD.ObtenerReservasCliente(idCliente);

                // Asignar las reservas como fuente de datos del DataGridView
                dataGridView_ReservaCli.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las reservas del cliente: " + ex.Message);
            }
        }

        //Obten la lista de Reservas del Cliente en el que estamos la sesion.
        public static List<Reserva> ObtenerReservasCliente(int idCliente)
        {
            List<Reserva> reservas = new List<Reserva>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT Reservas.IDReserva, Actividades.IDActividad, Reservas.IDInstanciaActividad, Reservas.FechaReserva, Reservas.HoraReserva
                             FROM Reservas
                             INNER JOIN Actividades ON Reservas.IDActividad = Actividades.IDActividad
                             WHERE Reservas.IDCliente = @IDCliente";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDCliente", idCliente);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva.IDReserva = Convert.ToInt32(reader["IDReserva"]);
                        reserva.IDCliente = idCliente;
                        reserva.IDActividad = Convert.ToInt32(reader["IDActividad"]);
                        reserva.IDInstanciaActividad = Convert.ToInt32(reader["IDInstanciaActividad"]);
                        reserva.FechaReserva = Convert.ToDateTime(reader["FechaReserva"]);
                        reserva.HoraReserva = TimeSpan.Parse(reader["HoraReserva"].ToString());

                        reservas.Add(reserva);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las reservas del cliente: " + ex.Message);
            }

            return reservas;
        }




        ////Obtener el IDCliente para poder almacenar las Reservas en su perfil
        //public static int ObtenerIdCliente(string correoElectronico)
        //{
        //    int idCliente = 0; // Valor inicial del IDCliente

        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            string query = "SELECT IDCliente FROM Clientes WHERE MailCli = @CorreoElectronico";
        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);

        //            object result = command.ExecuteScalar();
        //            if (result != null && result != DBNull.Value)
        //            {
        //                idCliente = Convert.ToInt32(result);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
        //    }

        //    return idCliente;
        //}




        //public static void ActualizarPosicionesEnCola(int posicionBorrada)
        //{
        //    // Obtener los clientes en cola por debajo de la posición borrada
        //    string query = "SELECT IDCliente, ColaReserva FROM Cliente WHERE ColaReserva > @Posicion ORDER BY ColaReserva ASC";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@Posicion", posicionBorrada);
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            // Actualizar las posiciones en cola de los clientes por debajo
        //            while (reader.Read())
        //            {
        //                int clienteId = (int)reader["IDCliente"];
        //                int posicionCola = (int)reader["ColaReserva"];
        //                int nuevaPosicion = posicionCola - 1;

        //                // Actualizar la posición en cola del cliente en la base de datos
        //                string updateQuery = "UPDATE Cliente SET ColaReserva = @NuevaPosicion WHERE IDCliente = @ClienteID";
        //                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
        //                {
        //                    updateCommand.Parameters.AddWithValue("@NuevaPosicion", nuevaPosicion);
        //                    updateCommand.Parameters.AddWithValue("@ClienteID", clienteId);
        //                    updateCommand.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //    }
        //}


    }
}
