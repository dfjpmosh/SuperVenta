namespace Ing_SW_B
{
    partial class FormAltaPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaPP));
            this.tbTelefono2 = new System.Windows.Forms.TextBox();
            this.lApellido = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.tbIdTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTelefono2
            // 
            this.tbTelefono2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono2.Location = new System.Drawing.Point(120, 91);
            this.tbTelefono2.MaxLength = 10;
            this.tbTelefono2.Name = "tbTelefono2";
            this.tbTelefono2.Size = new System.Drawing.Size(196, 29);
            this.tbTelefono2.TabIndex = 3;
            this.tbTelefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono2_KeyPress);
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApellido.Location = new System.Drawing.Point(9, 94);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(100, 22);
            this.lApellido.TabIndex = 36;
            this.lApellido.Text = "Telefono 2:";
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(12, 187);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(81, 31);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(437, 187);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(81, 31);
            this.bAceptar.TabIndex = 5;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(120, 51);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(196, 29);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(14, 54);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(81, 22);
            this.lCliente.TabIndex = 35;
            this.lCliente.Text = "Nombre:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(120, 131);
            this.tbDireccion.MaxLength = 50;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(398, 29);
            this.tbDireccion.TabIndex = 4;
            this.tbDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.Location = new System.Drawing.Point(9, 134);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(99, 22);
            this.lDireccion.TabIndex = 34;
            this.lDireccion.Text = "Dirección: ";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(9, 14);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(105, 22);
            this.lTelefono.TabIndex = 33;
            this.lTelefono.Text = "Teléfono 1: ";
            // 
            // tbIdTelefono
            // 
            this.tbIdTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdTelefono.Location = new System.Drawing.Point(120, 12);
            this.tbIdTelefono.MaxLength = 10;
            this.tbIdTelefono.Name = "tbIdTelefono";
            this.tbIdTelefono.Size = new System.Drawing.Size(196, 29);
            this.tbIdTelefono.TabIndex = 1;
            this.tbIdTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIdTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdTelefono_KeyPress);
            // 
            // FormAltaPP
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ing_SW_B.Properties.Resources.Fondo_con_Borde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(532, 230);
            this.Controls.Add(this.tbIdTelefono);
            this.Controls.Add(this.tbTelefono2);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.lTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAltaPP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAltaPP_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbTelefono2;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lCliente;
        public System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label lTelefono;
        public System.Windows.Forms.TextBox tbIdTelefono;
    }
}