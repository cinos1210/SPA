
namespace SPA
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btonEditarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Wheat;
            this.btnProductos.Location = new System.Drawing.Point(88, 305);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(154, 113);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.Wheat;
            this.btnCitas.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCitas.Location = new System.Drawing.Point(587, 305);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(154, 113);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.Text = "Agendar de cita";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btonEditarCita
            // 
            this.btonEditarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btonEditarCita.BackColor = System.Drawing.Color.Wheat;
            this.btonEditarCita.Location = new System.Drawing.Point(333, 305);
            this.btonEditarCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btonEditarCita.Name = "btonEditarCita";
            this.btonEditarCita.Size = new System.Drawing.Size(154, 113);
            this.btonEditarCita.TabIndex = 2;
            this.btonEditarCita.Text = "Editar cita";
            this.btonEditarCita.UseVisualStyleBackColor = false;
            this.btonEditarCita.Click += new System.EventHandler(this.btonEditarCita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(241, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonEditarCita);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnProductos);
            this.Name = "Inicio";
            this.Text = "Cruz del Sur SPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btonEditarCita;
        private System.Windows.Forms.Label label1;
    }
}

