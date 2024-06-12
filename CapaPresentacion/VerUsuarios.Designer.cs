namespace CapaPresentacion
{
    partial class VerUsuarios
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
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaUsuarios
            // 
            this.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaUsuarios.Location = new System.Drawing.Point(242, 53);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.Size = new System.Drawing.Size(502, 255);
            this.grillaUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIOS DEL SISTEMA";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(45, 70);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(135, 36);
            this.btnAgregarUsuario.TabIndex = 2;
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(45, 137);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(135, 36);
            this.btnModificarUsuario.TabIndex = 3;
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(45, 208);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(135, 36);
            this.btnEliminarUsuario.TabIndex = 4;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaUsuarios);
            this.Name = "VerUsuarios";
            this.Text = "VerUsuarios";
            this.Load += new System.EventHandler(this.VerUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
    }
}