namespace GenteFit
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.button1_ListaEspera = new System.Windows.Forms.Button();
            this.button2_ConsultarReservas = new System.Windows.Forms.Button();
            this.label1_AdminSesion = new System.Windows.Forms.Label();
            this.button3_salir = new System.Windows.Forms.Button();
            this.comboBox1_Actividades = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_ListaEspera
            // 
            this.button1_ListaEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1_ListaEspera.Location = new System.Drawing.Point(23, 298);
            this.button1_ListaEspera.Name = "button1_ListaEspera";
            this.button1_ListaEspera.Size = new System.Drawing.Size(185, 75);
            this.button1_ListaEspera.TabIndex = 0;
            this.button1_ListaEspera.Text = "Lista de Espera";
            this.button1_ListaEspera.UseVisualStyleBackColor = true;
            this.button1_ListaEspera.Click += new System.EventHandler(this.button1_ListaEspera_Click);
            // 
            // button2_ConsultarReservas
            // 
            this.button2_ConsultarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2_ConsultarReservas.Location = new System.Drawing.Point(23, 458);
            this.button2_ConsultarReservas.Name = "button2_ConsultarReservas";
            this.button2_ConsultarReservas.Size = new System.Drawing.Size(185, 80);
            this.button2_ConsultarReservas.TabIndex = 1;
            this.button2_ConsultarReservas.Text = "Consultar Reservas";
            this.button2_ConsultarReservas.UseVisualStyleBackColor = true;
            // 
            // label1_AdminSesion
            // 
            this.label1_AdminSesion.AutoSize = true;
            this.label1_AdminSesion.BackColor = System.Drawing.Color.Transparent;
            this.label1_AdminSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1_AdminSesion.Location = new System.Drawing.Point(1202, 24);
            this.label1_AdminSesion.Name = "label1_AdminSesion";
            this.label1_AdminSesion.Size = new System.Drawing.Size(105, 13);
            this.label1_AdminSesion.TabIndex = 2;
            this.label1_AdminSesion.Text = "Sesión Administrador";
            this.label1_AdminSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3_salir
            // 
            this.button3_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3_salir.Location = new System.Drawing.Point(1326, 15);
            this.button3_salir.Name = "button3_salir";
            this.button3_salir.Size = new System.Drawing.Size(91, 28);
            this.button3_salir.TabIndex = 3;
            this.button3_salir.Text = "Cerrar Sesión";
            this.button3_salir.UseVisualStyleBackColor = true;
            // 
            // comboBox1_Actividades
            // 
            this.comboBox1_Actividades.AccessibleName = "";
            this.comboBox1_Actividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1_Actividades.FormattingEnabled = true;
            this.comboBox1_Actividades.Location = new System.Drawing.Point(690, 150);
            this.comboBox1_Actividades.Name = "comboBox1_Actividades";
            this.comboBox1_Actividades.Size = new System.Drawing.Size(255, 28);
            this.comboBox1_Actividades.TabIndex = 4;
            this.comboBox1_Actividades.Visible = false;
            this.comboBox1_Actividades.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenteFit.Properties.Resources.bg_menu;
            this.ClientSize = new System.Drawing.Size(1440, 1023);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1_Actividades);
            this.Controls.Add(this.button3_salir);
            this.Controls.Add(this.label1_AdminSesion);
            this.Controls.Add(this.button2_ConsultarReservas);
            this.Controls.Add(this.button1_ListaEspera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.Text = "MenúAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_ListaEspera;
        private System.Windows.Forms.Button button2_ConsultarReservas;
        private System.Windows.Forms.Label label1_AdminSesion;
        private System.Windows.Forms.Button button3_salir;
        private System.Windows.Forms.ComboBox comboBox1_Actividades;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}