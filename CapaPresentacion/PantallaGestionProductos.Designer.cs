namespace CapaPresentacion
{
    partial class PantallaGestionProductos
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
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnProductosProveedor = new System.Windows.Forms.Button();
            this.btnModificarProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(26, 50);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(137, 50);
            this.btnAgregarProductos.TabIndex = 0;
            this.btnAgregarProductos.Text = "Agregar productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Location = new System.Drawing.Point(26, 116);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(137, 52);
            this.btnEliminarProductos.TabIndex = 1;
            this.btnEliminarProductos.Text = "Eliminar productos";
            this.btnEliminarProductos.UseVisualStyleBackColor = true;
            // 
            // btnProductosProveedor
            // 
            this.btnProductosProveedor.Location = new System.Drawing.Point(26, 258);
            this.btnProductosProveedor.Name = "btnProductosProveedor";
            this.btnProductosProveedor.Size = new System.Drawing.Size(137, 55);
            this.btnProductosProveedor.TabIndex = 2;
            this.btnProductosProveedor.Text = "Productos y proveedores";
            this.btnProductosProveedor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProductos
            // 
            this.btnModificarProductos.Location = new System.Drawing.Point(26, 186);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(137, 52);
            this.btnModificarProductos.TabIndex = 3;
            this.btnModificarProductos.Text = "Modificar productos";
            this.btnModificarProductos.UseVisualStyleBackColor = true;
            // 
            // PantallaGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificarProductos);
            this.Controls.Add(this.btnProductosProveedor);
            this.Controls.Add(this.btnEliminarProductos);
            this.Controls.Add(this.btnAgregarProductos);
            this.Name = "PantallaGestionProductos";
            this.Text = "PantallaGestionProductos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnProductosProveedor;
        private System.Windows.Forms.Button btnModificarProductos;
    }
}