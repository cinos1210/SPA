
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
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(48, 73);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(220, 188);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(719, 73);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(220, 188);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.Text = "Agendar de cita";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btonEditarCita
            // 
            this.btonEditarCita.Location = new System.Drawing.Point(397, 73);
            this.btonEditarCita.Name = "btonEditarCita";
            this.btonEditarCita.Size = new System.Drawing.Size(220, 188);
            this.btonEditarCita.TabIndex = 2;
            this.btonEditarCita.Text = "Editar cita";
            this.btonEditarCita.UseVisualStyleBackColor = true;
            this.btonEditarCita.Click += new System.EventHandler(this.btonEditarCita_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btonEditarCita);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.Text = "Spa ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btonEditarCita;
    }
}

