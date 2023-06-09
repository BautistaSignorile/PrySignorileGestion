﻿namespace pryGestion
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDetalleActividad = new System.Windows.Forms.TextBox();
            this.lblTipoActividad = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoActividad = new System.Windows.Forms.ComboBox();
            this.lblDetalleActividad = new System.Windows.Forms.Label();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositor = new System.Windows.Forms.CheckBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reunión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDetalleActividad
            // 
            this.txtDetalleActividad.Location = new System.Drawing.Point(15, 131);
            this.txtDetalleActividad.Multiline = true;
            this.txtDetalleActividad.Name = "txtDetalleActividad";
            this.txtDetalleActividad.Size = new System.Drawing.Size(235, 112);
            this.txtDetalleActividad.TabIndex = 1;
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Location = new System.Drawing.Point(9, 58);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(75, 13);
            this.lblTipoActividad.TabIndex = 2;
            this.lblTipoActividad.Text = "Tipo Actividad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(15, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(235, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // cboTipoActividad
            // 
            this.cboTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoActividad.FormattingEnabled = true;
            this.cboTipoActividad.Items.AddRange(new object[] {
            "Relevamiento",
            "Propuesta",
            "Diagnostico",
            "Analisis",
            "Diagrama de base de datos",
            "Programacion"});
            this.cboTipoActividad.Location = new System.Drawing.Point(15, 74);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(235, 21);
            this.cboTipoActividad.TabIndex = 5;
            // 
            // lblDetalleActividad
            // 
            this.lblDetalleActividad.AutoSize = true;
            this.lblDetalleActividad.Location = new System.Drawing.Point(12, 115);
            this.lblDetalleActividad.Name = "lblDetalleActividad";
            this.lblDetalleActividad.Size = new System.Drawing.Size(86, 13);
            this.lblDetalleActividad.TabIndex = 6;
            this.lblDetalleActividad.Text = "Detalle actividad";
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.rdbNo);
            this.mrcReunion.Controls.Add(this.rdbSi);
            this.mrcReunion.Location = new System.Drawing.Point(15, 252);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(235, 58);
            this.mrcReunion.TabIndex = 7;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(141, 19);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Checked = true;
            this.rdbSi.Location = new System.Drawing.Point(65, 19);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 17);
            this.rdbSi.TabIndex = 0;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkRepositor);
            this.mrcTareas.Location = new System.Drawing.Point(15, 316);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(241, 100);
            this.mrcTareas.TabIndex = 8;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(131, 56);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(61, 17);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(31, 56);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(92, 17);
            this.chkNotasReunion.TabIndex = 2;
            this.chkNotasReunion.Text = "Notas reuniòn";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(131, 33);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositor
            // 
            this.chkRepositor.AutoSize = true;
            this.chkRepositor.Location = new System.Drawing.Point(31, 33);
            this.chkRepositor.Name = "chkRepositor";
            this.chkRepositor.Size = new System.Drawing.Size(79, 17);
            this.chkRepositor.TabIndex = 0;
            this.chkRepositor.Text = "Repositorio";
            this.chkRepositor.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(96, 437);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 9;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(15, 437);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.AllowUserToAddRows = false;
            this.dtgvRegistro.AllowUserToDeleteRows = false;
            this.dtgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRegistro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.TipoActividad,
            this.DetalleActividad,
            this.Reunión,
            this.Tareas});
            this.dtgvRegistro.Location = new System.Drawing.Point(269, 131);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersVisible = false;
            this.dtgvRegistro.Size = new System.Drawing.Size(521, 285);
            this.dtgvRegistro.TabIndex = 11;
            this.dtgvRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRegistro_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // TipoActividad
            // 
            this.TipoActividad.HeaderText = "Tipo Actividad";
            this.TipoActividad.Name = "TipoActividad";
            this.TipoActividad.ReadOnly = true;
            // 
            // DetalleActividad
            // 
            this.DetalleActividad.HeaderText = "Detalle Actividad";
            this.DetalleActividad.Name = "DetalleActividad";
            this.DetalleActividad.ReadOnly = true;
            // 
            // Reunión
            // 
            this.Reunión.HeaderText = "Reunión";
            this.Reunión.Name = "Reunión";
            this.Reunión.ReadOnly = true;
            // 
            // Tareas
            // 
            this.Tareas.HeaderText = "Tareas";
            this.Tareas.Name = "Tareas";
            this.Tareas.ReadOnly = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::pryGestion.Properties.Resources.pngwing_com__2_;
            this.picLogo.Location = new System.Drawing.Point(439, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 105);
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(703, 437);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 471);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.lblDetalleActividad);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.txtDetalleActividad);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Actividad";
            this.Click += new System.EventHandler(this.frmRegistrar_Click);
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDetalleActividad;
        private System.Windows.Forms.Label lblTipoActividad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoActividad;
        private System.Windows.Forms.Label lblDetalleActividad;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositor;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reunión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tareas;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCerrar;
    }
}