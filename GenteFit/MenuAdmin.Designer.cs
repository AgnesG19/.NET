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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.button1_ListaEspera = new System.Windows.Forms.Button();
            this.button_ConsultarReservas = new System.Windows.Forms.Button();
            this.label1_AdminSesion = new System.Windows.Forms.Label();
            this.button_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1_Titulo = new System.Windows.Forms.Label();
            this.button_Boxing = new System.Windows.Forms.Button();
            this.button_Pilates = new System.Windows.Forms.Button();
            this.button_Spinning = new System.Windows.Forms.Button();
            this.button_Crossfit = new System.Windows.Forms.Button();
            this.button_CrearAct = new System.Windows.Forms.Button();
            this.label_NombreAct = new System.Windows.Forms.Label();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Instructor = new System.Windows.Forms.Label();
            this.label_Plazas = new System.Windows.Forms.Label();
            this.textBox_NombreAct = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.textBox_Instructor = new System.Windows.Forms.TextBox();
            this.textBox_Plazas = new System.Windows.Forms.TextBox();
            this.label_CrearAct = new System.Windows.Forms.Label();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.label_Hora = new System.Windows.Forms.Label();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Reservas = new System.Windows.Forms.DataGridView();
            this.label_MostrarReservas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservas)).BeginInit();
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
            // button_ConsultarReservas
            // 
            this.button_ConsultarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_ConsultarReservas.Location = new System.Drawing.Point(23, 458);
            this.button_ConsultarReservas.Name = "button_ConsultarReservas";
            this.button_ConsultarReservas.Size = new System.Drawing.Size(185, 80);
            this.button_ConsultarReservas.TabIndex = 1;
            this.button_ConsultarReservas.Text = "Consultar Reservas";
            this.button_ConsultarReservas.UseVisualStyleBackColor = true;
            this.button_ConsultarReservas.Click += new System.EventHandler(this.button_ConsultarReservas_Click);
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
            // 
            // button_salir
            // 
            this.button_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_salir.Location = new System.Drawing.Point(1326, 15);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(91, 28);
            this.button_salir.TabIndex = 3;
            this.button_salir.Text = "Cerrar Sesión";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 470);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // label1_Titulo
            // 
            this.label1_Titulo.AutoSize = true;
            this.label1_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.label1_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1_Titulo.Location = new System.Drawing.Point(598, 89);
            this.label1_Titulo.Name = "label1_Titulo";
            this.label1_Titulo.Size = new System.Drawing.Size(459, 39);
            this.label1_Titulo.TabIndex = 6;
            this.label1_Titulo.Text = "SELECIONA LA ACTIVIDAD";
            this.label1_Titulo.Visible = false;
            // 
            // button_Boxing
            // 
            this.button_Boxing.AllowDrop = true;
            this.button_Boxing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_Boxing.Location = new System.Drawing.Point(404, 169);
            this.button_Boxing.Name = "button_Boxing";
            this.button_Boxing.Size = new System.Drawing.Size(177, 53);
            this.button_Boxing.TabIndex = 7;
            this.button_Boxing.Text = "BOXING";
            this.button_Boxing.UseVisualStyleBackColor = true;
            this.button_Boxing.Visible = false;
            this.button_Boxing.Click += new System.EventHandler(this.button_boxing_Click);
            // 
            // button_Pilates
            // 
            this.button_Pilates.AllowDrop = true;
            this.button_Pilates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_Pilates.Location = new System.Drawing.Point(631, 169);
            this.button_Pilates.Name = "button_Pilates";
            this.button_Pilates.Size = new System.Drawing.Size(177, 53);
            this.button_Pilates.TabIndex = 8;
            this.button_Pilates.Text = "PILATES";
            this.button_Pilates.UseVisualStyleBackColor = true;
            this.button_Pilates.Visible = false;
            this.button_Pilates.Click += new System.EventHandler(this.button1_Pilates_Click);
            // 
            // button_Spinning
            // 
            this.button_Spinning.AllowDrop = true;
            this.button_Spinning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_Spinning.Location = new System.Drawing.Point(856, 169);
            this.button_Spinning.Name = "button_Spinning";
            this.button_Spinning.Size = new System.Drawing.Size(177, 53);
            this.button_Spinning.TabIndex = 9;
            this.button_Spinning.Text = "SPINNING";
            this.button_Spinning.UseVisualStyleBackColor = true;
            this.button_Spinning.Visible = false;
            this.button_Spinning.Click += new System.EventHandler(this.button1_Spinning_Click);
            // 
            // button_Crossfit
            // 
            this.button_Crossfit.AllowDrop = true;
            this.button_Crossfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_Crossfit.Location = new System.Drawing.Point(1081, 169);
            this.button_Crossfit.Name = "button_Crossfit";
            this.button_Crossfit.Size = new System.Drawing.Size(177, 53);
            this.button_Crossfit.TabIndex = 10;
            this.button_Crossfit.Text = "CROSSFIT";
            this.button_Crossfit.UseVisualStyleBackColor = true;
            this.button_Crossfit.Visible = false;
            this.button_Crossfit.Click += new System.EventHandler(this.button1_Crossfit_Click);
            // 
            // button_CrearAct
            // 
            this.button_CrearAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_CrearAct.Location = new System.Drawing.Point(23, 136);
            this.button_CrearAct.Name = "button_CrearAct";
            this.button_CrearAct.Size = new System.Drawing.Size(185, 75);
            this.button_CrearAct.TabIndex = 11;
            this.button_CrearAct.Text = "Crear Actividad";
            this.button_CrearAct.UseVisualStyleBackColor = true;
            this.button_CrearAct.Click += new System.EventHandler(this.button_CrearAct_Click);
            // 
            // label_NombreAct
            // 
            this.label_NombreAct.AutoSize = true;
            this.label_NombreAct.BackColor = System.Drawing.Color.Transparent;
            this.label_NombreAct.Font = new System.Drawing.Font("Myriad Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.label_NombreAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_NombreAct.Location = new System.Drawing.Point(338, 317);
            this.label_NombreAct.Name = "label_NombreAct";
            this.label_NombreAct.Size = new System.Drawing.Size(130, 29);
            this.label_NombreAct.TabIndex = 12;
            this.label_NombreAct.Text = "Nombre Actividad";
            this.label_NombreAct.Visible = false;
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.label_Descripcion.Font = new System.Drawing.Font("Myriad Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.label_Descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Descripcion.Location = new System.Drawing.Point(338, 400);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(87, 29);
            this.label_Descripcion.TabIndex = 13;
            this.label_Descripcion.Text = "Descripcion";
            this.label_Descripcion.Visible = false;
            // 
            // label_Instructor
            // 
            this.label_Instructor.AutoSize = true;
            this.label_Instructor.BackColor = System.Drawing.Color.Transparent;
            this.label_Instructor.Font = new System.Drawing.Font("Myriad Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.label_Instructor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Instructor.Location = new System.Drawing.Point(853, 317);
            this.label_Instructor.Name = "label_Instructor";
            this.label_Instructor.Size = new System.Drawing.Size(73, 29);
            this.label_Instructor.TabIndex = 14;
            this.label_Instructor.Text = "Instructor";
            this.label_Instructor.Visible = false;
            // 
            // label_Plazas
            // 
            this.label_Plazas.AutoSize = true;
            this.label_Plazas.BackColor = System.Drawing.Color.Transparent;
            this.label_Plazas.Font = new System.Drawing.Font("Myriad Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.label_Plazas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Plazas.Location = new System.Drawing.Point(862, 400);
            this.label_Plazas.Name = "label_Plazas";
            this.label_Plazas.Size = new System.Drawing.Size(54, 29);
            this.label_Plazas.TabIndex = 15;
            this.label_Plazas.Text = "Plazas";
            this.label_Plazas.Visible = false;
            // 
            // textBox_NombreAct
            // 
            this.textBox_NombreAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBox_NombreAct.Location = new System.Drawing.Point(500, 317);
            this.textBox_NombreAct.Multiline = true;
            this.textBox_NombreAct.Name = "textBox_NombreAct";
            this.textBox_NombreAct.Size = new System.Drawing.Size(287, 32);
            this.textBox_NombreAct.TabIndex = 16;
            this.textBox_NombreAct.Visible = false;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBox_Descripcion.Location = new System.Drawing.Point(500, 394);
            this.textBox_Descripcion.Multiline = true;
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(287, 109);
            this.textBox_Descripcion.TabIndex = 17;
            this.textBox_Descripcion.Visible = false;
            // 
            // textBox_Instructor
            // 
            this.textBox_Instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBox_Instructor.Location = new System.Drawing.Point(947, 314);
            this.textBox_Instructor.Multiline = true;
            this.textBox_Instructor.Name = "textBox_Instructor";
            this.textBox_Instructor.Size = new System.Drawing.Size(287, 32);
            this.textBox_Instructor.TabIndex = 18;
            this.textBox_Instructor.Visible = false;
            // 
            // textBox_Plazas
            // 
            this.textBox_Plazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBox_Plazas.Location = new System.Drawing.Point(947, 394);
            this.textBox_Plazas.Multiline = true;
            this.textBox_Plazas.Name = "textBox_Plazas";
            this.textBox_Plazas.Size = new System.Drawing.Size(287, 32);
            this.textBox_Plazas.TabIndex = 19;
            this.textBox_Plazas.Visible = false;
            // 
            // label_CrearAct
            // 
            this.label_CrearAct.AutoSize = true;
            this.label_CrearAct.BackColor = System.Drawing.Color.Transparent;
            this.label_CrearAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label_CrearAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_CrearAct.Location = new System.Drawing.Point(660, 69);
            this.label_CrearAct.Name = "label_CrearAct";
            this.label_CrearAct.Size = new System.Drawing.Size(332, 39);
            this.label_CrearAct.TabIndex = 20;
            this.label_CrearAct.Text = "CREAR ACTIVIDAD";
            this.label_CrearAct.Visible = false;
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_Fecha.Font = new System.Drawing.Font("Myriad Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.label_Fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Fecha.Location = new System.Drawing.Point(338, 571);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(51, 29);
            this.label_Fecha.TabIndex = 21;
            this.label_Fecha.Text = "Fecha";
            this.label_Fecha.Visible = false;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(500, 567);
            this.dateTimePicker_Date.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(229, 29);
            this.dateTimePicker_Date.TabIndex = 40;
            this.dateTimePicker_Date.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker_Date.Visible = false;
            // 
            // button_Guardar
            // 
            this.button_Guardar.AllowDrop = true;
            this.button_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar.Location = new System.Drawing.Point(1011, 898);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(177, 53);
            this.button_Guardar.TabIndex = 41;
            this.button_Guardar.Text = "GUARDAR";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Visible = false;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // label_Hora
            // 
            this.label_Hora.AutoSize = true;
            this.label_Hora.BackColor = System.Drawing.Color.Transparent;
            this.label_Hora.Font = new System.Drawing.Font("Myriad Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.label_Hora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Hora.Location = new System.Drawing.Point(862, 567);
            this.label_Hora.Name = "label_Hora";
            this.label_Hora.Size = new System.Drawing.Size(44, 29);
            this.label_Hora.TabIndex = 42;
            this.label_Hora.Text = "Hora";
            this.label_Hora.Visible = false;
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Time.Location = new System.Drawing.Point(947, 571);
            this.dateTimePicker_Time.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Size = new System.Drawing.Size(229, 29);
            this.dateTimePicker_Time.TabIndex = 43;
            this.dateTimePicker_Time.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker_Time.Visible = false;
            // 
            // dataGridView_Reservas
            // 
            this.dataGridView_Reservas.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Reservas.Location = new System.Drawing.Point(395, 298);
            this.dataGridView_Reservas.Name = "dataGridView_Reservas";
            this.dataGridView_Reservas.Size = new System.Drawing.Size(901, 294);
            this.dataGridView_Reservas.TabIndex = 44;
            this.dataGridView_Reservas.Visible = false;
            // 
            // label_MostrarReservas
            // 
            this.label_MostrarReservas.AutoSize = true;
            this.label_MostrarReservas.BackColor = System.Drawing.Color.Transparent;
            this.label_MostrarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label_MostrarReservas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_MostrarReservas.Location = new System.Drawing.Point(639, 108);
            this.label_MostrarReservas.Name = "label_MostrarReservas";
            this.label_MostrarReservas.Size = new System.Drawing.Size(385, 39);
            this.label_MostrarReservas.TabIndex = 45;
            this.label_MostrarReservas.Text = "MOSTRAR RESERVAS";
            this.label_MostrarReservas.Visible = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenteFit.Properties.Resources.bg_menu;
            this.ClientSize = new System.Drawing.Size(1440, 1023);
            this.Controls.Add(this.label_MostrarReservas);
            this.Controls.Add(this.dataGridView_Reservas);
            this.Controls.Add(this.dateTimePicker_Time);
            this.Controls.Add(this.label_Hora);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label_Fecha);
            this.Controls.Add(this.label_CrearAct);
            this.Controls.Add(this.textBox_Plazas);
            this.Controls.Add(this.textBox_Instructor);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.textBox_NombreAct);
            this.Controls.Add(this.label_Plazas);
            this.Controls.Add(this.label_Instructor);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.label_NombreAct);
            this.Controls.Add(this.button_CrearAct);
            this.Controls.Add(this.button_Crossfit);
            this.Controls.Add(this.button_Spinning);
            this.Controls.Add(this.button_Pilates);
            this.Controls.Add(this.button_Boxing);
            this.Controls.Add(this.label1_Titulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.label1_AdminSesion);
            this.Controls.Add(this.button_ConsultarReservas);
            this.Controls.Add(this.button1_ListaEspera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.Text = "MenúAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_ListaEspera;
        private System.Windows.Forms.Button button_ConsultarReservas;
        private System.Windows.Forms.Label label1_AdminSesion;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1_Titulo;
        private System.Windows.Forms.Button button_Boxing;
        private System.Windows.Forms.Button button_Pilates;
        private System.Windows.Forms.Button button_Spinning;
        private System.Windows.Forms.Button button_Crossfit;
        private System.Windows.Forms.Button button_CrearAct;
        private System.Windows.Forms.Label label_NombreAct;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Instructor;
        private System.Windows.Forms.Label label_Plazas;
        private System.Windows.Forms.TextBox textBox_NombreAct;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.TextBox textBox_Instructor;
        private System.Windows.Forms.TextBox textBox_Plazas;
        private System.Windows.Forms.Label label_CrearAct;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label label_Hora;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.DataGridView dataGridView_Reservas;
        private System.Windows.Forms.Label label_MostrarReservas;
    }
}