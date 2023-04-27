//*Importamos para que puda leer los metodos
using GenteFit.BBDD;
using System;
using System.Windows.Forms;

namespace GenteFit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //*Muestra mensaje si la conexion es correcto o inc.
            ConexionBD BaseDatos = new ConexionBD();
            if (BaseDatos.Conectar())
            {
                textBox1.Text = "Conexión establecida BBDD";
            }
            else
            {
                textBox1.Text = "Conexión erronea BBDD";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2_Email.Visible = true;
            textBox2_Email.Visible = true;
            label2_Contrasena.Visible = true;
            textBox3_Contrasena.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
