namespace CapaPresentacion
{
    partial class VerProductos
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
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProductos
            // 
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Location = new System.Drawing.Point(206, 46);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.Size = new System.Drawing.Size(535, 278);
            this.grillaProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCTOS";
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.Location = new System.Drawing.Point(21, 46);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(160, 39);
            this.btnGestionProductos.TabIndex = 2;
            this.btnGestionProductos.Text = "Gestionar Productos";
            this.btnGestionProductos.UseVisualStyleBackColor = true;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // VerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaProductos);
            this.Name = "VerProductos";
            this.Text = "VerProductos";
            this.Load += new System.EventHandler(this.VerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionProductos;
    }
}