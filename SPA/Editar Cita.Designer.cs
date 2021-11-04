
namespace SPA
{
    partial class Editar_Cita
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.FechaCita = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxHora = new System.Windows.Forms.ComboBox();
            this.btonAcep = new System.Windows.Forms.Button();
            this.btonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 139);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(175, 169);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 25);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha de creación:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(101, 203);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 25);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "label5";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(101, 238);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 25);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "label6";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(101, 276);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(59, 25);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "label7";
            // 
            // FechaCita
            // 
            this.FechaCita.CustomFormat = "yyyy-MM-dd";
            this.FechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCita.Location = new System.Drawing.Point(306, 14);
            this.FechaCita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaCita.Name = "FechaCita";
            this.FechaCita.Size = new System.Drawing.Size(284, 31);
            this.FechaCita.TabIndex = 25;
            this.FechaCita.ValueChanged += new System.EventHandler(this.FechaCita_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hora :";
            // 
            // cboxHora
            // 
            this.cboxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHora.FormattingEnabled = true;
            this.cboxHora.Location = new System.Drawing.Point(369, 55);
            this.cboxHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxHora.Name = "cboxHora";
            this.cboxHora.Size = new System.Drawing.Size(221, 33);
            this.cboxHora.TabIndex = 26;
            // 
            // btonAcep
            // 
            this.btonAcep.Location = new System.Drawing.Point(457, 203);
            this.btonAcep.Name = "btonAcep";
            this.btonAcep.Size = new System.Drawing.Size(133, 47);
            this.btonAcep.TabIndex = 28;
            this.btonAcep.Text = "Aceptar";
            this.btonAcep.UseVisualStyleBackColor = true;
            this.btonAcep.Click += new System.EventHandler(this.btonAcep_Click);
            // 
            // btonCancel
            // 
            this.btonCancel.Location = new System.Drawing.Point(457, 254);
            this.btonCancel.Name = "btonCancel";
            this.btonCancel.Size = new System.Drawing.Size(133, 47);
            this.btonCancel.TabIndex = 29;
            this.btonCancel.Text = "Cancelar";
            this.btonCancel.UseVisualStyleBackColor = true;
            // 
            // Editar_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 315);
            this.Controls.Add(this.btonCancel);
            this.Controls.Add(this.btonAcep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxHora);
            this.Controls.Add(this.FechaCita);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Editar_Cita";
            this.Text = "Editar_Cita";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DateTimePicker FechaCita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxHora;
        private System.Windows.Forms.Button btonAcep;
        private System.Windows.Forms.Button btonCancel;
    }
}