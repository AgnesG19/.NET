using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenteFit.Consultas;
using GenteFit.Entidades;

namespace GenteFit
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True";

        private void dataGridView_ReservaAct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value is TimeSpan)
            {
                TimeSpan timeSpan = (TimeSpan)e.Value;
                e.Value = timeSpan.ToString(@"hh\:mm\:ss"); // Especifica el formato deseado para mostrar el TimeSpan
                e.FormattingApplied = true;
            }
        }


        // ******** BTN 1 ACTIVIDADES PARA RESERVAR
        private void button_Actividades_Click(object sender, EventArgs e)
        {
            label_ActividadesReserva.Visible = true;
            dataGridView_ReservaAct.Visible = true;
            label_InfoGenerarReserva.Visible=true;

            //Desactiva la vista del btn 2
            label_ReservasAct.Visible = false;
            dataGridView_ReservaCli.Visible = false;

            ConsultasBD consultasBD = new ConsultasBD();

            // Obtén la lista de instancias de actividades disponibles de la base de datos
            List<InstanciasActividad> instanciasDisponibles = consultasBD.ObtenerInstanciasActividadesDisponibles();

            // Muestra la lista de instancias de actividades en el DataGridView
            dataGridView_ReservaAct.DataSource = instanciasDisponibles;


        }

        //Doble click en la Cell para hacer RESERVA
                //Propiedades > Rayo (opciones de evento)
        private void DataGridView_ReservaAct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_ReservaAct.SelectedRows.Count > 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_ReservaAct.Rows[e.RowIndex];

                    // Obtener los valores de la fila seleccionada
                    int idInstanciaActividad = (int)row.Cells["IdInstanciaActividad"].Value;
                    int idActividad = (int)row.Cells["IdActividad"].Value;
                    DateTime fecha = (DateTime)row.Cells["Fecha"].Value;
                    TimeSpan hora = (TimeSpan)row.Cells["Hora"].Value;

                    // Obtener la instancia de actividad seleccionada en la fila
                    InstanciasActividad instanciaSeleccionada = row.DataBoundItem as InstanciasActividad;

                    // Verificar el cliente que ha iniciado sesión
                    Cliente clienteActual = ConsultasBD.ObtenerClienteActual();

                    if (clienteActual != null)
                    {
                        // Obtener el ID del cliente actual
                        int idCliente = clienteActual.IDCliente;

                        // Obtener fechaReserva y horaReserva
                        DateTime fechaReserva = fecha.Date;
                        TimeSpan horaReserva = hora;

                        // Realizar la reserva con los valores obtenidos
                        bool reservaExitosa = ConsultasBD.RealizarReserva(idCliente, instanciaSeleccionada, fechaReserva, horaReserva);
                        if (reservaExitosa)
                        {
                            MessageBox.Show("La reserva se ha guardado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar la reserva.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La instancia de actividad seleccionada no es válida.");
                    }
                }
            }
        }


        // ******** BTN 2 MOSTRAR RESERVAS DEL CLIENTE
        private void button_MostrarReservasCli_Click(object sender, EventArgs e)
        {
            //Desactiva la vista del btn 1
            label_ActividadesReserva.Visible = false;
            dataGridView_ReservaAct.Visible = false;
            label_InfoGenerarReserva.Visible =false;

            label_ReservasAct.Visible = true;
            dataGridView_ReservaCli.Visible = true;
            // Obtener el cliente actual
            Cliente clienteActual = ConsultasBD.ObtenerClienteActual();

            if (clienteActual != null)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Consulta SQL para obtener las reservas del cliente actual
                        string query = @"SELECT Reservas.IDReserva, Actividades.NombreAct AS NombreActividad,
                            InstanciasActividad.Fecha, InstanciasActividad.Hora
                            FROM Reservas
                            INNER JOIN InstanciasActividad ON Reservas.IDInstanciaActividad = InstanciasActividad.IDInstanciaActividad
                            INNER JOIN Actividades ON Reservas.IDActividad = Actividades.IDActividad
                            WHERE Reservas.IDCliente = @IDCliente";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@IDCliente", clienteActual.IDCliente);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar el DataTable como origen de datos del DataGridView
                        dataGridView_ReservaCli.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar las reservas del cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha iniciado sesión con ningún cliente.");
            }

        }


        //DOBLE CLICK eb la fila de la RESERVA que se quiere ELIMINAR
        private void dataGridView_ReservasCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_ReservaCli.Rows[e.RowIndex];

                // Obtener el ID de la reserva seleccionada
                int idReserva = Convert.ToInt32(row.Cells["IDReserva"].Value);

                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Realizar la eliminación de la reserva
                    bool eliminacionExitosa = ConsultasBD.EliminarReserva(idReserva);

                    if (eliminacionExitosa)
                    {
                        // Obtener el ID del cliente actual
                        int idCliente = ConsultasBD.ObtenerIdCliente();

                        // Actualizar la lista de reservas del cliente
                        ConsultasBD.ActualizarListaReservasCliente(dataGridView_ReservaCli, idCliente);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private void button_salir_Click(object sender, EventArgs e)
        {
            // Mostrar la ventana de inicio de sesión
            Inicio formInicio = new Inicio();
            formInicio.Show();

            // Cerrar esta ventana
            MenuAdmin formAdmin = new MenuAdmin();
            formAdmin.Close();
        }

        
    }
}
