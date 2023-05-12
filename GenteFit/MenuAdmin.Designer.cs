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
            this.button1_ConsultaReservas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_ConsultaReservas
            // 
            this.button1_ConsultaReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1_ConsultaReservas.Location = new System.Drawing.Point(37, 63);
            this.button1_ConsultaReservas.Name = "button1_ConsultaReservas";
            this.button1_ConsultaReservas.Size = new System.Drawing.Size(216, 64);
            this.button1_ConsultaReservas.TabIndex = 0;
            this.button1_ConsultaReservas.Text = "Consulta Reservas Clintes";
            this.button1_ConsultaReservas.UseVisualStyleBackColor = true;
            // 
            // MenúAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GenteFit.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1440, 1023);
            this.Controls.Add(this.button1_ConsultaReservas);
            this.Name = "MenúAdmin";
            this.Text = "MenúAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_ConsultaReservas;
    }
}