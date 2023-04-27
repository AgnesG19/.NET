namespace GenteFit
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_InicioSes = new System.Windows.Forms.Button();
            this.button2_Regis = new System.Windows.Forms.Button();
            this.label1_Title = new System.Windows.Forms.Label();
            this.label2_Email = new System.Windows.Forms.Label();
            this.label2_Contrasena = new System.Windows.Forms.Label();
            this.textBox2_Email = new System.Windows.Forms.TextBox();
            this.textBox3_Contrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1_InicioSes
            // 
            this.button1_InicioSes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_InicioSes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1_InicioSes.FlatAppearance.BorderSize = 199;
            this.button1_InicioSes.Font = new System.Drawing.Font("Myriad Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_InicioSes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1_InicioSes.Location = new System.Drawing.Point(565, 715);
            this.button1_InicioSes.Name = "button1_InicioSes";
            this.button1_InicioSes.Size = new System.Drawing.Size(342, 70);
            this.button1_InicioSes.TabIndex = 1;
            this.button1_InicioSes.Tag = "Start";
            this.button1_InicioSes.Text = "INICIAR SESIÓN";
            this.button1_InicioSes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1_InicioSes.UseVisualStyleBackColor = false;
            this.button1_InicioSes.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_Regis
            // 
            this.button2_Regis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2_Regis.Font = new System.Drawing.Font("Myriad Arabic", 20.25F, System.Drawing.FontStyle.Bold);
            this.button2_Regis.Location = new System.Drawing.Point(565, 822);
            this.button2_Regis.Name = "button2_Regis";
            this.button2_Regis.Size = new System.Drawing.Size(342, 70);
            this.button2_Regis.TabIndex = 2;
            this.button2_Regis.Tag = "Start";
            this.button2_Regis.Text = "REGISTRARSE";
            this.button2_Regis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2_Regis.UseVisualStyleBackColor = false;
            // 
            // label1_Title
            // 
            this.label1_Title.AutoSize = true;
            this.label1_Title.BackColor = System.Drawing.Color.DarkOrange;
            this.label1_Title.Font = new System.Drawing.Font("Tw Cen MT", 80F, System.Drawing.FontStyle.Bold);
            this.label1_Title.ForeColor = System.Drawing.Color.White;
            this.label1_Title.Location = new System.Drawing.Point(508, 86);
            this.label1_Title.Name = "label1_Title";
            this.label1_Title.Size = new System.Drawing.Size(483, 123);
            this.label1_Title.TabIndex = 3;
            this.label1_Title.Text = "GENTEFIT";
            this.label1_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2_Email
            // 
            this.label2_Email.AutoSize = true;
            this.label2_Email.BackColor = System.Drawing.Color.Transparent;
            this.label2_Email.Font = new System.Drawing.Font("Myriad Arabic", 25F, System.Drawing.FontStyle.Bold);
            this.label2_Email.ForeColor = System.Drawing.Color.White;
            this.label2_Email.Location = new System.Drawing.Point(456, 363);
            this.label2_Email.Name = "label2_Email";
            this.label2_Email.Size = new System.Drawing.Size(83, 50);
            this.label2_Email.TabIndex = 4;
            this.label2_Email.Text = "Email";
            this.label2_Email.Visible = false;
            // 
            // label2_Contrasena
            // 
            this.label2_Contrasena.AutoSize = true;
            this.label2_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.label2_Contrasena.Font = new System.Drawing.Font("Myriad Arabic", 25F, System.Drawing.FontStyle.Bold);
            this.label2_Contrasena.ForeColor = System.Drawing.Color.White;
            this.label2_Contrasena.Location = new System.Drawing.Point(393, 479);
            this.label2_Contrasena.Name = "label2_Contrasena";
            this.label2_Contrasena.Size = new System.Drawing.Size(146, 50);
            this.label2_Contrasena.TabIndex = 5;
            this.label2_Contrasena.Text = "Contraseña";
            this.label2_Contrasena.Visible = false;
            this.label2_Contrasena.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2_Email
            // 
            this.textBox2_Email.Location = new System.Drawing.Point(582, 363);
            this.textBox2_Email.Multiline = true;
            this.textBox2_Email.Name = "textBox2_Email";
            this.textBox2_Email.Size = new System.Drawing.Size(432, 50);
            this.textBox2_Email.TabIndex = 6;
            this.textBox2_Email.Visible = false;
            // 
            // textBox3_Contrasena
            // 
            this.textBox3_Contrasena.Location = new System.Drawing.Point(582, 479);
            this.textBox3_Contrasena.Multiline = true;
            this.textBox3_Contrasena.Name = "textBox3_Contrasena";
            this.textBox3_Contrasena.Size = new System.Drawing.Size(432, 50);
            this.textBox3_Contrasena.TabIndex = 7;
            this.textBox3_Contrasena.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GenteFit.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1440, 1023);
            this.Controls.Add(this.textBox3_Contrasena);
            this.Controls.Add(this.textBox2_Email);
            this.Controls.Add(this.label2_Contrasena);
            this.Controls.Add(this.label2_Email);
            this.Controls.Add(this.label1_Title);
            this.Controls.Add(this.button2_Regis);
            this.Controls.Add(this.button1_InicioSes);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_InicioSes;
        private System.Windows.Forms.Button button2_Regis;
        private System.Windows.Forms.Label label1_Title;
        private System.Windows.Forms.Label label2_Email;
        private System.Windows.Forms.Label label2_Contrasena;
        private System.Windows.Forms.TextBox textBox2_Email;
        private System.Windows.Forms.TextBox textBox3_Contrasena;
    }
}

