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
        }

           

        //Click en btn Lista de Espera y se muestra ComBox con las Actividades
        private void button1_ListaEspera_Click(object sender, EventArgs e)
        {
            comboBox1_Actividades.Visible = true;
            label1_Titulo.Visible = true;

            // Obtener las actividades desde la base de datos y configurar la ComboBox1
            ConsultasBD consultasBD = new ConsultasBD("Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True");
            DataTable dt = consultasBD.ConsultaActividades();
            comboBox1_Actividades.DataSource = dt;
            comboBox1_Actividades.DisplayMember = "NombreAct";
            comboBox1_Actividades.ValueMember = "IDActividad";
        }

        //DESPLEGABLE con las ACTIVIDADES Y CARGA LA FUNCION DE CONSULTA RESERVAS
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idActividad = Convert.ToInt32(comboBox1_Actividades.SelectedValue);

            try
            {
                ConsultasBD consultasBD = new ConsultasBD("Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True");
                DataTable dt = consultasBD.ConsultaReservasActividad(idActividad);


                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron reservas para la actividad seleccionada");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ocurrió un error al cargar los datos: " + ex.Message);
                MessageBox.Show("Ocurrió un error al cargar los datos. Por favor, inténtelo de nuevo.");
            }
        }




        //DATAGRIDVIEW Actualiza los datos de la tabla.
        //private void ActualizarDataGridView(int idActividad, DataTable dt)
        //{
        //    try
        //    {
        //        // Limpiar la DataGridView
        //        dataGridView1.Rows.Clear();
        //        dataGridView1.Refresh();

        //        // Asignar la fuente de datos
        //        dataGridView1.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Imprimir información adicional sobre la excepción
        //        Debug.WriteLine("Error al asignar la fuente de datos a la DataGridView:");
        //        Debug.WriteLine("Tabla: " + dt.TableName);
        //        Debug.WriteLine("Columna que falta: " + ex.Message);

        //        // Mostrar un mensaje de error al usuario
        //        MessageBox.Show("Ocurrió un error al cargar los datos.");
        //    }
        //}

        //BTN PARA CERRAR SESION
        private void button3_salir_Click(object sender, EventArgs e)
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
