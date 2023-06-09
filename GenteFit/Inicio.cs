﻿//*Importamos para que puda leer los metodos
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

            //Muestra mensaje si la conexion es correcto o inc.
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
        //BOTON DE INICIO SESION
        private void button1_Click(object sender, EventArgs e)
        {
            //Se muestran los text y botones
            label2_Email.Visible = true;
            textBox2_Email.Visible = true;
            label2_Contrasena.Visible = true;
            textBox3_Contrasena.Visible = true;

            button1_Acceder.Visible = true;

            //se ocultan los botones de Registro
            label1_nombre.Visible = false;
            textBox1_Nombre.Visible = false;
            label2_apellidos.Visible = false;
            textBox2_Apellidos.Visible = false;
            label3_email.Visible = false;
            textBox3_Email.Visible = false;
            label4_telefono.Visible = false;
            textBox4_Telefono.Visible = false;
            label5_contrasena.Visible = false;
            textBox5_Contrasena.Visible = false;

            button1_GuardarDatosRegistro.Visible = false;

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

            ConsultasBD consultas = new ConsultasBD("");

            if (consultas.VerificarExistencia(email, contrasena))
            {
                // Si los datos existen en la base de datos, nos llevara al menú principal
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                textBox1.Text="Correo electrónico o contraseña incorrectos";
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Regis_Click(object sender, EventArgs e)
        {
           //se muestran los botones ocultos anteriormente
            label1_nombre.Visible = true;
            textBox1_Nombre.Visible = true;
            label2_apellidos.Visible = true;
            textBox2_Apellidos.Visible = true;
            label3_email.Visible = true;
            textBox3_Email.Visible = true;
            label4_telefono.Visible = true;
            textBox4_Telefono.Visible = true;
            label5_contrasena.Visible = true;
            textBox5_Contrasena.Visible = true;

            button1_GuardarDatosRegistro.Visible = true;

            //se ocultan los botones de inicio sesion
            label2_Email.Visible = false;
            textBox2_Email.Visible = false;
            label2_Contrasena.Visible = false;
            textBox3_Contrasena.Visible = false;
            button1_Acceder.Visible = false;

        }

        private void button1_GuardarDatosRegistro_Click(object sender, EventArgs e)
        {
            string nombre = textBox1_Nombre.Text;
            string apellido = textBox2_Apellidos.Text;
            string email = textBox3_Email.Text;
            string telefono = textBox4_Telefono.Text;
            string contrasena = textBox5_Contrasena.Text;

            ConsultasBD consultas = new ConsultasBD("");

            if (consultas.RegistrarUsuario(nombre, apellido, email, telefono, contrasena))
            {
                textBox1.Text = "Usuario registrado exitosamente";
            }
            else
            {
                textBox1.Text = "Error al registrar usuario";
            }

            
        }
    }
}
