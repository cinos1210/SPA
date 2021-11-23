﻿
namespace SPA
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgrCita = new System.Windows.Forms.Button();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.FechaCita = new System.Windows.Forms.DateTimePicker();
            this.cboxHora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxServicio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pBImagenes = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.Wheat;
            this.tbxNombre.Location = new System.Drawing.Point(106, 148);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(120, 23);
            this.tbxNombre.TabIndex = 0;
            // 
            // txbCorreo
            // 
            this.txbCorreo.BackColor = System.Drawing.Color.Wheat;
            this.txbCorreo.Location = new System.Drawing.Point(106, 172);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(120, 23);
            this.txbCorreo.TabIndex = 1;
            // 
            // txbTelefono
            // 
            this.txbTelefono.BackColor = System.Drawing.Color.Wheat;
            this.txbTelefono.Location = new System.Drawing.Point(106, 202);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(120, 23);
            this.txbTelefono.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono :";
            // 
            // btnAgrCita
            // 
            this.btnAgrCita.BackColor = System.Drawing.Color.Wheat;
            this.btnAgrCita.Location = new System.Drawing.Point(106, 301);
            this.btnAgrCita.Name = "btnAgrCita";
            this.btnAgrCita.Size = new System.Drawing.Size(88, 47);
            this.btnAgrCita.TabIndex = 8;
            this.btnAgrCita.Text = "Agregar Cita";
            this.btnAgrCita.UseVisualStyleBackColor = false;
            this.btnAgrCita.Click += new System.EventHandler(this.btnAgrCita_Click);
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // FechaCita
            // 
            this.FechaCita.CustomFormat = "yyyy-MM-dd";
            this.FechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCita.Location = new System.Drawing.Point(25, 123);
            this.FechaCita.Name = "FechaCita";
            this.FechaCita.Size = new System.Drawing.Size(200, 23);
            this.FechaCita.TabIndex = 9;
            this.FechaCita.ValueChanged += new System.EventHandler(this.FechaCita_ValueChanged);
            // 
            // cboxHora
            // 
            this.cboxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHora.FormattingEnabled = true;
            this.cboxHora.Location = new System.Drawing.Point(106, 226);
            this.cboxHora.Name = "cboxHora";
            this.cboxHora.Size = new System.Drawing.Size(120, 23);
            this.cboxHora.TabIndex = 10;
            this.cboxHora.SelectedIndexChanged += new System.EventHandler(this.cboxHora_SelectedIndexChanged);
            this.cboxHora.ValueMemberChanged += new System.EventHandler(this.cboxHora_ValueMemberChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hora :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboxServicio
            // 
            this.cboxServicio.BackColor = System.Drawing.Color.Wheat;
            this.cboxServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxServicio.FormattingEnabled = true;
            this.cboxServicio.Items.AddRange(new object[] {
            "01 - Facial Desincrustante",
            "02 - Facial Hidratante",
            "03 - Facial Nutritivo",
            "04 - Facial Oxigenante",
            "05 - Facial Antiedad",
            "06 - Facial Velo de colágeno",
            "07 - Facial Despigmentante",
            "08 - Facial Holistico",
            "09 - Masaje relajante",
            "10 - Masaje antiestrés",
            "11 - Masaje brisa de mar",
            "12 - Masaje holistico",
            "13 - Masaje reductivo",
            "14 - Masaje de pies",
            "15 - Masaje facial ",
            "16 - Manicura",
            "17 - Pedicura"});
            this.cboxServicio.Location = new System.Drawing.Point(106, 257);
            this.cboxServicio.Name = "cboxServicio";
            this.cboxServicio.Size = new System.Drawing.Size(120, 23);
            this.cboxServicio.TabIndex = 12;
            this.cboxServicio.SelectedIndexChanged += new System.EventHandler(this.cboxServicio_SelectedIndexChanged);
            this.cboxServicio.Click += new System.EventHandler(this.cboxServicio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Servicio :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pBImagenes
            // 
            this.pBImagenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBImagenes.Image = ((System.Drawing.Image)(resources.GetObject("pBImagenes.Image")));
            this.pBImagenes.Location = new System.Drawing.Point(273, 28);
            this.pBImagenes.Margin = new System.Windows.Forms.Padding(2);
            this.pBImagenes.Name = "pBImagenes";
            this.pBImagenes.Size = new System.Drawing.Size(471, 289);
            this.pBImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBImagenes.TabIndex = 14;
            this.pBImagenes.TabStop = false;
            this.pBImagenes.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pBImagenes.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pBImagenes_PreviewKeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(767, 359);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pBImagenes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxHora);
            this.Controls.Add(this.FechaCita);
            this.Controls.Add(this.btnAgrCita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbCorreo);
            this.Controls.Add(this.tbxNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgrCita;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.DateTimePicker FechaCita;
        private System.Windows.Forms.ComboBox cboxHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pBImagenes;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}