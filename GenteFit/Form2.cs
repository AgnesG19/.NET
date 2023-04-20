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

            //Creo instancia de la clase que tiene la funcion
            ClientesXML CliXML = new ClientesXML(@"A:\Program Files\Code\NET\.NET\GenteFit\XML\Clientes.xml");
            CliXML.LeerClientes();


        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lista Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(848, 459);
            this.listBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(939, 694);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_TextChanged(object sender, EventArgs e)
        {
            var clientesXML = new ClientesXML(@"A:\Program Files\Code\NET\.NET\GenteFit\XML\Clientes.xml");
            var clientes = clientesXML.LeerClientes();

            foreach (var cliente in clientes)
            {
                listBox1.Items.Add(cliente.IDCliente + " - " + cliente.NombreCli + " " + cliente.ApellidoCli);
            }
        }
    }
}
