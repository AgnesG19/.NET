//*Importamos para que puda leer los metodos
using GenteFit.BBDD;
using GenteFit.Consultas;
using System;
using System.Windows.Forms;

namespace GenteFit
{
    public partial class Inicio : Form
    {
        public Inicio()
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

            button1_Acceder.Visible = true;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = textBox2_Email.Text;
            string contrasena = textBox3_Contrasena.Text;

            ConsultasBD consultas = new ConsultasBD("tu cadena de conexión a la base de datos aquí");

            if (consultas.VerificarExistencia(email, contrasena))
            {
                // Si los datos existen en la base de datos, nos llevara al menú principal
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo electrónico o contraseña incorrectos");
            }

        }
    }
}
