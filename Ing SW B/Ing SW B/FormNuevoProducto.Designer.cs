namespace Ing_SW_B
{
    partial class FormNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoProducto));
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.tbIdProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdProducto.Location = new System.Drawing.Point(130, 54);
            this.tbIdProducto.MaxLength = 10;
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(184, 29);
            this.tbIdProducto.TabIndex = 2;
            this.tbIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdProducto_KeyPress);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(11, 142);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(77, 28);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(237, 142);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(77, 28);
            this.bAceptar.TabIndex = 4;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(99, 93);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(215, 29);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.BackColor = System.Drawing.Color.White;
            this.lCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(12, 96);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(81, 22);
            this.lCliente.TabIndex = 42;
            this.lCliente.Text = "Nombre:";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.BackColor = System.Drawing.Color.White;
            this.lTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(7, 56);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(117, 22);
            this.lTelefono.TabIndex = 41;
            this.lTelefono.Text = "Id Producto: ";
            // 
            // tbIdProveedor
            // 
            this.tbIdProveedor.Enabled = false;
            this.tbIdProveedor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdProveedor.Location = new System.Drawing.Point(140, 16);
            this.tbIdProveedor.MaxLength = 10;
            this.tbIdProveedor.Name = "tbIdProveedor";
            this.tbIdProveedor.Size = new System.Drawing.Size(173, 29);
            this.tbIdProveedor.TabIndex = 6;
            this.tbIdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdProveedor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Id Proveedor:";
            // 
            // FormNuevoProducto
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ing_SW_B.Properties.Resources.Fondo_con_Borde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(325, 177);
            this.Controls.Add(this.tbIdProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.lTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNuevoProducto_FormClosing);
            this.Load += new System.EventHandler(this.FormNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label lTelefono;
        public System.Windows.Forms.TextBox tbIdProveedor;
        private System.Windows.Forms.Label label1;
    }
}