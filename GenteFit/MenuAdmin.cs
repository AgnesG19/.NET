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

        //******** BTN Lista de Espera y se muestran los botones con las Actividades y la Grid
        private void button1_ListaEspera_Click(object sender, EventArgs e)
        {
            //comboBox1_Actividades.Visible = true;
            label1_Titulo.Visible = true;
            dataGridView1.Visible = true;

            button_Boxing.Visible = true;
            button_Pilates.Visible = true;
            button_Spinning.Visible = true;
            button_Crossfit.Visible = true;

            // Obtener las actividades desde la base de datos y configurar la ComboBox1
            ConsultasBD consultasBD = new ConsultasBD(connectionString);
            DataTable dt = consultasBD.ConsultaActividades();
            //comboBox1_Actividades.DataSource = dt;
            //comboBox1_Actividades.DisplayMember = "NombreAct";
            //comboBox1_Actividades.ValueMember = "IDActividad";
        }

        //********* BOTONES con las ACTIVIDADES Y CARGA LA FUNCION DE LISTA DE ESPERA de las ACTIVIDADES
        private void button_boxing_Click(object sender, EventArgs e)
        {
            int idActividad = 1; // El ID de la actividad Boxing

            ConsultasBD consultasBD = new ConsultasBD(connectionString);
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }

        private void button1_Pilates_Click(object sender, EventArgs e)
        {
            int idActividad = 2; // El ID de la actividad Pilates

            ConsultasBD consultasBD = new ConsultasBD(connectionString);
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }

        private void button1_Spinning_Click(object sender, EventArgs e)
        {
            int idActividad = 3; // El ID de la actividad Spinning

            ConsultasBD consultasBD = new ConsultasBD(connectionString);
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }
        private void button1_Crossfit_Click(object sender, EventArgs e)
        {
            int idActividad = 4; // El ID de la actividad Crossfit

            ConsultasBD consultasBD = new ConsultasBD(connectionString);
            consultasBD.MostrarListaEspera(idActividad, dataGridView1);
        }



        //*************** BTN PARA CERRAR SESION
        private void button3_salir_Click(object sender, EventArgs e)
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
