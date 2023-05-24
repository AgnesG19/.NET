using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenteFit.BBDD;
using GenteFit.Consultas;


namespace GenteFit
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            //comboBox1_Actividades.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private string connectionString = "Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True";

        //************** BTN 1 CREAR ACTIVIDAD ***********************//
        private void button_CrearAct_Click(object sender, EventArgs e)
        {
            //Mostrar texto y textboxes
            label_CrearAct.Visible = true;

            label_NombreAct.Visible = true;
            textBox_NombreAct.Visible = true;

            label_Descripcion.Visible = true;
            textBox_Descripcion.Visible = true;

            label_Instructor.Visible = true;
            textBox_Instructor.Visible = true;

            label_Plazas.Visible = true;
            textBox_Plazas.Visible = true;

            label_Fecha.Visible = true;
            dateTimePicker_Date.Visible = true;

            label_Hora.Visible = true;
            dateTimePicker_Time.Visible = true;

            button_Guardar.Visible = true;

            //FALSE de los otros botones por si se quedan visibles.
            label1_Titulo.Visible = false;
            dataGridView1.Visible = false;
            button_Boxing.Visible = false;
            button_Pilates.Visible = false;
            button_Spinning.Visible = false;
            button_Crossfit.Visible = false;
            dataGridView_Reservas.Visible = false;
            label_MostrarReservas.Visible = false;
            dataGridView_Reservas.Visible = false;
            label_MostrarReservas.Visible = false;

        }

        //************** BTN 2 LISTA DE ESPERA ***********************//
        private void button1_ListaEspera_Click(object sender, EventArgs e)
        {
            //comboBox1_Actividades.Visible = true;
            label1_Titulo.Visible = true;
            dataGridView1.Visible = true;

            button_Boxing.Visible = true;
            button_Pilates.Visible = true;
            button_Spinning.Visible = true;
            button_Crossfit.Visible = true;

            //FALSE de los otros botones por si se quedan visibles.
            label_CrearAct.Visible = false;
            label_NombreAct.Visible = false;
            textBox_NombreAct.Visible = false;
            label_Descripcion.Visible = false;
            textBox_Descripcion.Visible = false;
            label_Instructor.Visible = false;
            textBox_Instructor.Visible = false;
            label_Plazas.Visible = false;
            textBox_Plazas.Visible = false;
            label_Fecha.Visible = false;
            dateTimePicker_Date.Visible = false;
            label_Hora.Visible = false;
            dateTimePicker_Time.Visible = false;
            button_Guardar.Visible = false;
            dataGridView_Reservas.Visible = false;
            label_MostrarReservas.Visible = false;

            // Obtener las actividades desde la base de datos y configurar la ComboBox1
            ConsultasBD consultasBD = new ConsultasBD();
            DataTable dt = consultasBD.ConsultaActividades();
            //comboBox1_Actividades.DataSource = dt;
            //comboBox1_Actividades.DisplayMember = "NombreAct";
            //comboBox1_Actividades.ValueMember = "IDActividad";
        }

        //********* BOTONES con las ACTIVIDADES Y CARGA LA FUNCION DE LISTA DE ESPERA de las ACTIVIDADES
        private void button_boxing_Click(object sender, EventArgs e)
        {
            int idActividad = 1; // El ID de la actividad Boxing

            ConsultasBD consultasBD = new ConsultasBD();
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }

        private void button1_Pilates_Click(object sender, EventArgs e)
        {
            int idActividad = 2; // El ID de la actividad Pilates

            ConsultasBD consultasBD = new ConsultasBD();
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }

        private void button1_Spinning_Click(object sender, EventArgs e)
        {
            int idActividad = 3; // El ID de la actividad Spinning

            ConsultasBD consultasBD = new ConsultasBD();
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }
        private void button1_Crossfit_Click(object sender, EventArgs e)
        {
            int idActividad = 4; // El ID de la actividad Crossfit

            ConsultasBD consultasBD = new ConsultasBD();
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }


        //PARA LIMPIAR LA INFO DE LAS TEXTBOX EN MENU ADMIN - CREAR ACTIVIDAD
        private void LimpiarCampos()
        {
            textBox_NombreAct.Text = string.Empty;
            textBox_Descripcion.Text = string.Empty;
            textBox_Instructor.Text = string.Empty;
            textBox_Plazas.Text = string.Empty;
     
            dateTimePicker_Date.Value = DateTime.Now;
            dateTimePicker_Time.Value = DateTime.Now.Date;
        }

        // BTN Guarda la informacion introducida en las TABLAS Actividad/InstanciasActividad
        private void button_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperar los valores de los controles
                string nombreActividad = textBox_NombreAct.Text;
                string descripcion = textBox_Descripcion.Text;
                string instructor = textBox_Instructor.Text;
                int plazas = int.Parse(textBox_Plazas.Text);
                DateTime fecha = dateTimePicker_Date.Value;
                TimeSpan hora = dateTimePicker_Time.Value.TimeOfDay;

                // Comprobar si la actividad ya existe
                bool actividadExistente = ConsultasBD.ComprobarActividad(nombreActividad, descripcion, instructor, plazas, fecha, hora);

                if (actividadExistente)
                {
                    // La actividad ya existe, insertar en la tabla InstanciasActividad
                    ConsultasBD.InsertarInstanciaActividad(nombreActividad, descripcion, instructor, plazas, fecha, hora);
                }
                else
                {
                    // La actividad no existe, insertar en la tabla Actividades y luego en la tabla InstanciasActividad
                    ConsultasBD.InsertarActividad(nombreActividad, descripcion, instructor, plazas);
                    ConsultasBD.InsertarInstanciaActividad(nombreActividad, descripcion, instructor, plazas, fecha, hora);
                }

                // Limpiar los campos después de guardar
                LimpiarCampos();

                // Mostrar mensaje de éxito
                MessageBox.Show("Los datos se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //************** BTN 3 CONSULTA RESERVAS ***********************//
        private void button_ConsultarReservas_Click(object sender, EventArgs e)
        {
            dataGridView_Reservas.Visible = true;
            label_MostrarReservas.Visible = true;

            //FALSE de los otros botones por si se quedan visibles.
            label_CrearAct.Visible = false;
            label_NombreAct.Visible = false;
            textBox_NombreAct.Visible = false;
            label_Descripcion.Visible = false;
            textBox_Descripcion.Visible = false;
            label_Instructor.Visible = false;
            textBox_Instructor.Visible = false;
            label_Plazas.Visible = false;
            textBox_Plazas.Visible = false;
            label_Fecha.Visible = false;
            dateTimePicker_Date.Visible = false;
            label_Hora.Visible = false;
            dateTimePicker_Time.Visible = false;
            button_Guardar.Visible = false;
            label_CrearAct.Visible = false;
            label_NombreAct.Visible = false;
            textBox_NombreAct.Visible = false;
            label_Descripcion.Visible = false;
            textBox_Descripcion.Visible = false;
            label_Instructor.Visible = false;
            textBox_Instructor.Visible = false;
            label_Plazas.Visible = false;
            textBox_Plazas.Visible = false;
            label_Fecha.Visible = false;
            dateTimePicker_Date.Visible = false;
            label_Hora.Visible = false;
            dateTimePicker_Time.Visible = false;
            button_Guardar.Visible = false;
            label1_Titulo.Visible = false;
            dataGridView1.Visible = false;
            button_Boxing.Visible = false;
            button_Pilates.Visible = false;
            button_Spinning.Visible = false;
            button_Crossfit.Visible = false;

            // Obtener las reservas de la base de datos
            DataTable reservas = ConsultasBD.ObtenerReservas();

            // Asignar los datos al DataGridView
            dataGridView_Reservas.DataSource = reservas;
        }


        //*************** BTN PARA CERRAR SESION
        private void button_salir_Click(object sender, EventArgs e)
        {
            // Mostrar la ventana de inicio de sesión
            Inicio formInicio = new Inicio();
            formInicio.Show();

            // Cerrar esta ventana
            MenuAdmin formAdmin = new MenuAdmin();
            formAdmin.Close();
        }



        //DESPLEGABLE con las ACTIVIDADES Y CARGA LA FUNCION DE CONSULTA RESERVAS (NO FUNCIONO POR CULPA DE LA COMBOBOX)
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string actividadSeleccionada = comboBox1_Actividades.SelectedItem.ToString();

        //    // Obtener el ID de la actividad seleccionada
        //    string queryActividad = "SELECT IDActividad FROM Actividades WHERE NombreAct = @NombreAct";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand commandActividad = new SqlCommand(queryActividad, connection);
        //        commandActividad.Parameters.AddWithValue("@NombreAct", actividadSeleccionada);
        //        object result = commandActividad.ExecuteScalar();

        //        if (result != null && result != DBNull.Value && int.TryParse(result.ToString(), out int idActividad))
        //        {
        //            ConsultasBD consultasBD = new ConsultasBD(connectionString);
        //            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        //        }
        //        else
        //        {
        //            MessageBox.Show("La actividad seleccionada no existe.");
        //            return;
        //        }
        //    }
        //}
    }
}
