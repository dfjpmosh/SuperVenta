namespace Ing_SW_B
{
    partial class FormAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaCliente));
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(444, 180);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(81, 33);
            this.bAceptar.TabIndex = 5;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(108, 52);
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
            this.lCliente.Location = new System.Drawing.Point(17, 55);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(81, 22);
            this.lCliente.TabIndex = 23;
            this.lCliente.Text = "Nombre:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(108, 132);
            this.tbDireccion.MaxLength = 50;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(417, 29);
            this.tbDireccion.TabIndex = 4;
            this.tbDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.Location = new System.Drawing.Point(8, 135);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(99, 22);
            this.lDireccion.TabIndex = 21;
            this.lDireccion.Text = "Dirección: ";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Enabled = false;
            this.tbTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(108, 12);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(120, 29);
            this.tbTelefono.TabIndex = 1;
            this.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(12, 15);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(90, 22);
            this.lTelefono.TabIndex = 19;
            this.lTelefono.Text = "Teléfono: ";
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(12, 180);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(81, 33);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(108, 92);
            this.tbApellido.MaxLength = 30;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(196, 29);
            this.tbApellido.TabIndex = 3;
            this.tbApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApellido.Location = new System.Drawing.Point(12, 95);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(90, 22);
            this.lApellido.TabIndex = 27;
            this.lApellido.Text = "Apellidos:";
            // 
            // FormAltaCliente
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ing_SW_B.Properties.Resources.Fondo_con_Borde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(542, 225);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAltaCliente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label lDireccion;
        public System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lApellido;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.TextBox tbApellido;
    }
}