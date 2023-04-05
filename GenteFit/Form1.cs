using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*Importamos para que puda leer los metodos
using GenteFit.BBDD;
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
    
    }
}
