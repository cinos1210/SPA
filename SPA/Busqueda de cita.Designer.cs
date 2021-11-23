
namespace SPA
{
    partial class Busqueda_de_cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda_de_cita));
            this.label1 = new System.Windows.Forms.Label();
            this.tboxid = new System.Windows.Forms.TextBox();
            this.btonBusca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el codigo de su cita, por favor";
            // 
            // tboxid
            // 
            this.tboxid.BackColor = System.Drawing.Color.Wheat;
            this.tboxid.Location = new System.Drawing.Point(113, 53);
            this.tboxid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxid.Name = "tboxid";
            this.tboxid.Size = new System.Drawing.Size(106, 23);
            this.tboxid.TabIndex = 1;
            this.tboxid.TextChanged += new System.EventHandler(this.tboxid_TextChanged);
            // 
            // btonBusca
            // 
            this.btonBusca.BackColor = System.Drawing.Color.Wheat;
            this.btonBusca.Location = new System.Drawing.Point(125, 81);
            this.btonBusca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btonBusca.Name = "btonBusca";
            this.btonBusca.Size = new System.Drawing.Size(78, 30);
            this.btonBusca.TabIndex = 2;
            this.btonBusca.Text = "Buscar";
            this.btonBusca.UseVisualStyleBackColor = false;
            this.btonBusca.Click += new System.EventHandler(this.btonBusca_Click);
            // 
            // Busqueda_de_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(326, 122);
            this.Controls.Add(this.btonBusca);
            this.Controls.Add(this.tboxid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Busqueda_de_cita";
            this.Text = "Busqueda_de_cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxid;
        private System.Windows.Forms.Button btonBusca;
    }
}