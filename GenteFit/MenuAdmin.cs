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

       
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Click en btn Lista de Espera y se muestra ComBox con las Actividades
        private void button1_ListaEspera_Click(object sender, EventArgs e)
        {
            comboBox1_Actividades.Visible = true;

            // Obtener las actividades desde la base de datos y configurar la ComboBox1
            ConsultasBD consultasBD = new ConsultasBD("Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True");
            DataTable dt = consultasBD.ConsultaActividades();
            comboBox1_Actividades.DataSource = dt;
            comboBox1_Actividades.DisplayMember = "NombreAct";
            comboBox1_Actividades.ValueMember = "IDActividad";
        }

        //DESPLEGABLE ACTIVIDADES
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID de la actividad seleccionada en la ComboBox1
            string idActividad = comboBox1_Actividades.SelectedValue.ToString();

            // Obtener los detalles de la actividad desde la base de datos
            ConsultasBD consultasBD = new ConsultasBD("Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True");
            DataTable dt = consultasBD.ConsultaActividades();
        }
        
    }
}
