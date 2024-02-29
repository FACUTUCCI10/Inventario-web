namespace Gestor_de_negocio
{
    partial class NuevaCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCateogoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAceptarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarCategoria.Location = new System.Drawing.Point(16, 188);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCategoria.TabIndex = 1;
            this.btnAceptarCategoria.Text = "Aceptar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = false;
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // btnCancelarCateogoria
            // 
            this.btnCancelarCateogoria.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelarCateogoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarCateogoria.Location = new System.Drawing.Point(164, 188);
            this.btnCancelarCateogoria.Name = "btnCancelarCateogoria";
            this.btnCancelarCateogoria.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCateogoria.TabIndex = 2;
            this.btnCancelarCateogoria.Text = "Cancelar";
            this.btnCancelarCateogoria.UseVisualStyleBackColor = false;
            this.btnCancelarCateogoria.Click += new System.EventHandler(this.btnCancelarCateogoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(66, 88);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(173, 20);
            this.txtCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // NuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnCancelarCateogoria);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NuevaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarCategoria;
        private System.Windows.Forms.Button btnCancelarCateogoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label2;
    }
}