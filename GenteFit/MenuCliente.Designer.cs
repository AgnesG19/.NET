namespace GenteFit
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            this.button_Actividades = new System.Windows.Forms.Button();
            this.label_ActividadesReserva = new System.Windows.Forms.Label();
            this.label_ClienteSesion = new System.Windows.Forms.Label();
            this.dataGridView_ReservaAct = new System.Windows.Forms.DataGridView();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_MostrarReservasCli = new System.Windows.Forms.Button();
            this.label_ReservasAct = new System.Windows.Forms.Label();
            this.dataGridView_ReservaCli = new System.Windows.Forms.DataGridView();
            this.label_InfoGenerarReserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReservaAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReservaCli)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Actividades
            // 
            this.button_Actividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Actividades.Location = new System.Drawing.Point(23, 222);
            this.button_Actividades.Name = "button_Actividades";
            this.button_Actividades.Size = new System.Drawing.Size(185, 75);
            this.button_Actividades.TabIndex = 12;
            this.button_Actividades.Text = "Actividades";
            this.button_Actividades.UseVisualStyleBackColor = true;
            this.button_Actividades.Click += new System.EventHandler(this.button_Actividades_Click);
            // 
            // label_ActividadesReserva
            // 
            this.label_ActividadesReserva.AutoSize = true;
            this.label_ActividadesReserva.BackColor = System.Drawing.Color.Transparent;
            this.label_ActividadesReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label_ActividadesReserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_ActividadesReserva.Location = new System.Drawing.Point(562, 109);
            this.label_ActividadesReserva.Name = "label_ActividadesReserva";
            this.label_ActividadesReserva.Size = new System.Drawing.Size(550, 39);
            this.label_ActividadesReserva.TabIndex = 46;
            this.label_ActividadesReserva.Text = "ACTIVIDADES PARA RESERVAR";
            this.label_ActividadesReserva.Visible = false;
            // 
            // label_ClienteSesion
            // 
            this.label_ClienteSesion.AutoSize = true;
            this.label_ClienteSesion.BackColor = System.Drawing.Color.Transparent;
            this.label_ClienteSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_ClienteSesion.Location = new System.Drawing.Point(1211, 21);
            this.label_ClienteSesion.Name = "label_ClienteSesion";
            this.label_ClienteSesion.Size = new System.Drawing.Size(74, 13);
            this.label_ClienteSesion.TabIndex = 47;
            this.label_ClienteSesion.Text = "Sesión Cliente";
            // 
            // dataGridView_ReservaAct
            // 
            this.dataGridView_ReservaAct.AllowUserToAddRows = false;
            this.dataGridView_ReservaAct.AllowUserToDeleteRows = false;
            this.dataGridView_ReservaAct.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView_ReservaAct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ReservaAct.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView_ReservaAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReservaAct.Location = new System.Drawing.Point(324, 193);
            this.dataGridView_ReservaAct.Name = "dataGridView_ReservaAct";
            this.dataGridView_ReservaAct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_ReservaAct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ReservaAct.Size = new System.Drawing.Size(1025, 687);
            this.dataGridView_ReservaAct.TabIndex = 48;
            this.dataGridView_ReservaAct.Visible = false;
            this.dataGridView_ReservaAct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ReservaAct_CellDoubleClick);
            this.dataGridView_ReservaAct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_ReservaAct_CellFormatting);
            // 
            // button_salir
            // 
            this.button_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_salir.Location = new System.Drawing.Point(1304, 12);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(91, 28);
            this.button_salir.TabIndex = 49;
            this.button_salir.Text = "Cerrar Sesión";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // button_MostrarReservasCli
            // 
            this.button_MostrarReservasCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_MostrarReservasCli.Location = new System.Drawing.Point(23, 386);
            this.button_MostrarReservasCli.Name = "button_MostrarReservasCli";
            this.button_MostrarReservasCli.Size = new System.Drawing.Size(185, 75);
            this.button_MostrarReservasCli.TabIndex = 50;
            this.button_MostrarReservasCli.Text = "Mostrar Reservas Activas";
            this.button_MostrarReservasCli.UseVisualStyleBackColor = true;
            this.button_MostrarReservasCli.Click += new System.EventHandler(this.button_MostrarReservasCli_Click);
            // 
            // label_ReservasAct
            // 
            this.label_ReservasAct.AutoSize = true;
            this.label_ReservasAct.BackColor = System.Drawing.Color.Transparent;
            this.label_ReservasAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label_ReservasAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_ReservasAct.Location = new System.Drawing.Point(626, 70);
            this.label_ReservasAct.Name = "label_ReservasAct";
            this.label_ReservasAct.Size = new System.Drawing.Size(362, 39);
            this.label_ReservasAct.TabIndex = 51;
            this.label_ReservasAct.Text = "RESERVAS ACTIVAS";
            this.label_ReservasAct.Visible = false;
            // 
            // dataGridView_ReservaCli
            // 
            this.dataGridView_ReservaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReservaCli.Location = new System.Drawing.Point(345, 271);
            this.dataGridView_ReservaCli.Name = "dataGridView_ReservaCli";
            this.dataGridView_ReservaCli.Size = new System.Drawing.Size(977, 582);
            this.dataGridView_ReservaCli.TabIndex = 52;
            this.dataGridView_ReservaCli.Visible = false;
            this.dataGridView_ReservaCli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ReservasCliente_CellDoubleClick);
            // 
            // label_InfoGenerarReserva
            // 
            this.label_InfoGenerarReserva.AutoSize = true;
            this.label_InfoGenerarReserva.BackColor = System.Drawing.Color.Transparent;
            this.label_InfoGenerarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoGenerarReserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_InfoGenerarReserva.Location = new System.Drawing.Point(360, 901);
            this.label_InfoGenerarReserva.Name = "label_InfoGenerarReserva";
            this.label_InfoGenerarReserva.Size = new System.Drawing.Size(966, 29);
            this.label_InfoGenerarReserva.TabIndex = 53;
            this.label_InfoGenerarReserva.Text = "Para hacer reserva haz DOBLE CLICK en la FILA de la actividad que deseas RESERVAR" +
    ".";
            this.label_InfoGenerarReserva.Visible = false;
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenteFit.Properties.Resources.bg_menu;
            this.ClientSize = new System.Drawing.Size(1440, 1023);
            this.Controls.Add(this.label_InfoGenerarReserva);
            this.Controls.Add(this.dataGridView_ReservaCli);
            this.Controls.Add(this.label_ReservasAct);
            this.Controls.Add(this.button_MostrarReservasCli);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.dataGridView_ReservaAct);
            this.Controls.Add(this.label_ClienteSesion);
            this.Controls.Add(this.label_ActividadesReserva);
            this.Controls.Add(this.button_Actividades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReservaAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReservaCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Actividades;
        private System.Windows.Forms.Label label_ActividadesReserva;
        private System.Windows.Forms.Label label_ClienteSesion;
        private System.Windows.Forms.DataGridView dataGridView_ReservaAct;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_MostrarReservasCli;
        private System.Windows.Forms.Label label_ReservasAct;
        private System.Windows.Forms.DataGridView dataGridView_ReservaCli;
        private System.Windows.Forms.Label label_InfoGenerarReserva;
    }
}