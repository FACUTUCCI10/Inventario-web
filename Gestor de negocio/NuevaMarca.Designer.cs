namespace Gestor_de_negocio
{
    partial class NuevaMarca
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
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Location = new System.Drawing.Point(12, 98);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMarca.TabIndex = 8;
            this.lblNombreMarca.Text = "Nombre:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(65, 95);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(173, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarMarca.Location = new System.Drawing.Point(163, 198);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 6;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAceptarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarMarca.Location = new System.Drawing.Point(15, 198);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMarca.TabIndex = 5;
            this.btnAceptarMarca.Text = "Aceptar";
            this.btnAceptarMarca.UseVisualStyleBackColor = false;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // NuevaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 228);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NuevaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnAceptarMarca;
    }
}