namespace pryGestion
{
    partial class frmMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrar));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnIngresarActividad = new System.Windows.Forms.Button();
            this.btnVerActividad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(38, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(102, 107);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnIngresarActividad
            // 
            this.btnIngresarActividad.Location = new System.Drawing.Point(12, 153);
            this.btnIngresarActividad.Name = "btnIngresarActividad";
            this.btnIngresarActividad.Size = new System.Drawing.Size(148, 52);
            this.btnIngresarActividad.TabIndex = 1;
            this.btnIngresarActividad.Text = "Ingresar Actividad";
            this.btnIngresarActividad.UseVisualStyleBackColor = true;
            this.btnIngresarActividad.Click += new System.EventHandler(this.btnIngresarActividad_Click);
            // 
            // btnVerActividad
            // 
            this.btnVerActividad.Location = new System.Drawing.Point(12, 239);
            this.btnVerActividad.Name = "btnVerActividad";
            this.btnVerActividad.Size = new System.Drawing.Size(148, 52);
            this.btnVerActividad.TabIndex = 2;
            this.btnVerActividad.Text = "Ver Actividad";
            this.btnVerActividad.UseVisualStyleBackColor = true;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 310);
            this.Controls.Add(this.btnVerActividad);
            this.Controls.Add(this.btnIngresarActividad);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrar";
            this.Text = "Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnIngresarActividad;
        private System.Windows.Forms.Button btnVerActividad;
    }
}