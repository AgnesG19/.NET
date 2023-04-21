using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//archivo que tiene la funcion
using GenteFit.XML;

namespace GenteFit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.button_Borrar = new System.Windows.Forms.Button();
            this.button_ListaClientes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(413, 628);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(143, 31);
            this.button_Borrar.TabIndex = 0;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ListaClientes
            // 
            this.button_ListaClientes.Location = new System.Drawing.Point(39, 39);
            this.button_ListaClientes.Name = "button_ListaClientes";
            this.button_ListaClientes.Size = new System.Drawing.Size(150, 38);
            this.button_ListaClientes.TabIndex = 1;
            this.button_ListaClientes.Text = "Lista Clientes";
            this.button_ListaClientes.UseVisualStyleBackColor = true;
            this.button_ListaClientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1: Se muestra.
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(848, 459);
            this.listBox1.TabIndex = 2;
            //this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(939, 694);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_ListaClientes);
            this.Controls.Add(this.button_Borrar);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar los elementos en la ListBox
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpiamos la lista antes de agregar los elementos por si queda algo de una vista anterior.
            ClientesXML cliXML = new ClientesXML(@"A:\Program Files\Code\NET\.NET\GenteFit\XML\Clientes.xml");
            List<Cliente> clientes = cliXML.LeerClientes();
            foreach (Cliente cliente in clientes)
            {
                listBox1.Items.Add(cliente.IDCliente + " - " + cliente.NombreCli + " " + cliente.ApellidoCli + " - " + cliente.TelefonoCli + " - " + cliente.MailCli + " - " + cliente.ContrasenaPerfil + " - " + cliente.ReservasActivas + " - " + cliente.ColaReserva);
            }
        }
        
    }
}
