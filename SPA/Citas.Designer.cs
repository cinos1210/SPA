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
            this.SuspendLayout();
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(707, 215);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(169, 31);
            this.tbxNombre.TabIndex = 0;
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(707, 263);
            this.txbCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(169, 31);
            this.txbCorreo.TabIndex = 1;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(707, 312);
            this.txbTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(169, 31);
            this.txbTelefono.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono :";
            // 
            // btnAgrCita
            // 
            this.btnAgrCita.Location = new System.Drawing.Point(724, 525);
            this.btnAgrCita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgrCita.Name = "btnAgrCita";
            this.btnAgrCita.Size = new System.Drawing.Size(126, 78);
            this.btnAgrCita.TabIndex = 8;
            this.btnAgrCita.Text = "Agregar Cita";
            this.btnAgrCita.UseVisualStyleBackColor = true;
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
            this.FechaCita.CustomFormat = "yyyy-mm-dd";
            this.FechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCita.Location = new System.Drawing.Point(592, 462);
            this.FechaCita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaCita.Name = "FechaCita";
            this.FechaCita.Size = new System.Drawing.Size(284, 31);
            this.FechaCita.TabIndex = 9;
            this.FechaCita.ValueChanged += new System.EventHandler(this.FechaCita_ValueChanged);
            // 
            // cboxHora
            // 
            this.cboxHora.FormattingEnabled = true;
            this.cboxHora.Items.AddRange(new object[] {
            "10:00:00",
            "12:00:00",
            "14:00:00",
            "16:00:00",
            "18:00:00"});
            this.cboxHora.Location = new System.Drawing.Point(707, 353);
            this.cboxHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxHora.Name = "cboxHora";
            this.cboxHora.Size = new System.Drawing.Size(169, 33);
            this.cboxHora.TabIndex = 10;
            this.cboxHora.SelectedIndexChanged += new System.EventHandler(this.cboxHora_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hora:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboxServicio
            // 
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
            "17 - pedicura"});
            this.cboxServicio.Location = new System.Drawing.Point(707, 405);
            this.cboxServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxServicio.Name = "cboxServicio";
            this.cboxServicio.Size = new System.Drawing.Size(169, 33);
            this.cboxServicio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 413);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Servicio:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Citas";
            this.Text = "Citas";
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
    }
}