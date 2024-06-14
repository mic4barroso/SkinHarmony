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
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Source Code Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Location = new System.Drawing.Point(96, 313);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(105, 51);
            this.btnAgregarProductos.TabIndex = 0;
            this.btnAgregarProductos.Text = "Agregar productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminarProductos.Font = new System.Drawing.Font("Source Code Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProductos.Location = new System.Drawing.Point(259, 313);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(103, 50);
            this.btnEliminarProductos.TabIndex = 1;
            this.btnEliminarProductos.Text = "Eliminar productos";
            this.btnEliminarProductos.UseVisualStyleBackColor = false;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // btnProductosProveedor
            // 
            this.btnProductosProveedor.Font = new System.Drawing.Font("Source Code Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosProveedor.Location = new System.Drawing.Point(571, 313);
            this.btnProductosProveedor.Name = "btnProductosProveedor";
            this.btnProductosProveedor.Size = new System.Drawing.Size(126, 51);
            this.btnProductosProveedor.TabIndex = 2;
            this.btnProductosProveedor.Text = "Productos y proveedores";
            this.btnProductosProveedor.UseVisualStyleBackColor = true;
            this.btnProductosProveedor.Click += new System.EventHandler(this.btnProductosProveedor_Click);
            // 
            // btnModificarProductos
            // 
            this.btnModificarProductos.Font = new System.Drawing.Font("Source Code Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProductos.Location = new System.Drawing.Point(418, 313);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(102, 51);
            this.btnModificarProductos.TabIndex = 3;
            this.btnModificarProductos.Text = "Modificar productos";
            this.btnModificarProductos.UseVisualStyleBackColor = true;
            this.btnModificarProductos.Click += new System.EventHandler(this.btnModificarProductos_Click);
            // 
            // grillaProductos
            // 
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Location = new System.Drawing.Point(41, 80);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.Size = new System.Drawing.Size(747, 203);
            this.grillaProductos.TabIndex = 4;
            this.grillaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProductos_CellContentClick);
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(152, 52);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(100, 20);
            this.tboxID.TabIndex = 5;
            this.tboxID.TextChanged += new System.EventHandler(this.tboxID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID PRODUCTO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PantallaGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.grillaProductos);
            this.Controls.Add(this.btnModificarProductos);
            this.Controls.Add(this.btnProductosProveedor);
            this.Controls.Add(this.btnEliminarProductos);
            this.Controls.Add(this.btnAgregarProductos);
            this.Name = "PantallaGestionProductos";
            this.Text = "PantallaGestionProductos";
            this.Load += new System.EventHandler(this.PantallaGestionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnProductosProveedor;
        private System.Windows.Forms.Button btnModificarProductos;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}