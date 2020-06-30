namespace Ing_SW_B
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.bPedido = new System.Windows.Forms.Button();
            this.bReportes = new System.Windows.Forms.Button();
            this.bVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mACliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mAProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mBCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mBProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mBProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mPClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mPProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRespaldar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.bPedidosCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dRespaldar = new System.Windows.Forms.SaveFileDialog();
            this.dImportar = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bPedido
            // 
            this.bPedido.AutoSize = true;
            this.bPedido.BackColor = System.Drawing.Color.Transparent;
            this.bPedido.BackgroundImage = global::Ing_SW_B.Properties.Resources.Pedidos;
            this.bPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPedido.Location = new System.Drawing.Point(231, 235);
            this.bPedido.Name = "bPedido";
            this.bPedido.Size = new System.Drawing.Size(124, 121);
            this.bPedido.TabIndex = 2;
            this.bPedido.UseVisualStyleBackColor = false;
            this.bPedido.Click += new System.EventHandler(this.bPedido_Click);
            // 
            // bReportes
            // 
            this.bReportes.AutoSize = true;
            this.bReportes.BackgroundImage = global::Ing_SW_B.Properties.Resources.Reportes;
            this.bReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReportes.Location = new System.Drawing.Point(438, 235);
            this.bReportes.Name = "bReportes";
            this.bReportes.Size = new System.Drawing.Size(124, 121);
            this.bReportes.TabIndex = 1;
            this.bReportes.UseVisualStyleBackColor = true;
            this.bReportes.Click += new System.EventHandler(this.bReportes_Click);
            // 
            // bVenta
            // 
            this.bVenta.BackgroundImage = global::Ing_SW_B.Properties.Resources.Venta;
            this.bVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVenta.Location = new System.Drawing.Point(24, 235);
            this.bVenta.Name = "bVenta";
            this.bVenta.Size = new System.Drawing.Size(124, 121);
            this.bVenta.TabIndex = 0;
            this.bVenta.UseVisualStyleBackColor = true;
            this.bVenta.Click += new System.EventHandler(this.bVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reportes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "P. Proveedores";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mClientes,
            this.toolStripSeparator1,
            this.mProveedores,
            this.toolStripSeparator3,
            this.mProductos});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // mClientes
            // 
            this.mClientes.Name = "mClientes";
            this.mClientes.Size = new System.Drawing.Size(162, 24);
            this.mClientes.Text = "Clientes";
            this.mClientes.Click += new System.EventHandler(this.mClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // mProveedores
            // 
            this.mProveedores.Name = "mProveedores";
            this.mProveedores.Size = new System.Drawing.Size(162, 24);
            this.mProveedores.Text = "Proveedores";
            this.mProveedores.Click += new System.EventHandler(this.mProveedores_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // mProductos
            // 
            this.mProductos.Name = "mProductos";
            this.mProductos.Size = new System.Drawing.Size(162, 24);
            this.mProductos.Text = "Productos";
            this.mProductos.Click += new System.EventHandler(this.mProductos_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mACliente,
            this.toolStripSeparator2,
            this.mAProveedor});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 23);
            this.toolStripMenuItem1.Text = "&Altas";
            // 
            // mACliente
            // 
            this.mACliente.Name = "mACliente";
            this.mACliente.Size = new System.Drawing.Size(162, 24);
            this.mACliente.Text = "Clientes";
            this.mACliente.Click += new System.EventHandler(this.mACliente_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // mAProveedor
            // 
            this.mAProveedor.Name = "mAProveedor";
            this.mAProveedor.Size = new System.Drawing.Size(162, 24);
            this.mAProveedor.Text = "Proveedores";
            this.mAProveedor.Click += new System.EventHandler(this.mAProveedor_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.consultasToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(586, 27);
            this.menuPrincipal.TabIndex = 6;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBCliente,
            this.toolStripSeparator4,
            this.mBProveedor,
            this.toolStripSeparator5,
            this.mBProducto});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 23);
            this.toolStripMenuItem2.Text = "&Bajas";
            // 
            // mBCliente
            // 
            this.mBCliente.Name = "mBCliente";
            this.mBCliente.Size = new System.Drawing.Size(162, 24);
            this.mBCliente.Text = "Clientes";
            this.mBCliente.Click += new System.EventHandler(this.mBCliente_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // mBProveedor
            // 
            this.mBProveedor.Name = "mBProveedor";
            this.mBProveedor.Size = new System.Drawing.Size(162, 24);
            this.mBProveedor.Text = "Proveedores";
            this.mBProveedor.Click += new System.EventHandler(this.mBProveedor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(159, 6);
            // 
            // mBProducto
            // 
            this.mBProducto.Name = "mBProducto";
            this.mBProducto.Size = new System.Drawing.Size(162, 24);
            this.mBProducto.Text = "Productos";
            this.mBProducto.Click += new System.EventHandler(this.mBProducto_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPClientes,
            this.toolStripSeparator6,
            this.mPProveedores});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 23);
            this.toolStripMenuItem3.Text = "&Pedidos";
            // 
            // mPClientes
            // 
            this.mPClientes.Name = "mPClientes";
            this.mPClientes.Size = new System.Drawing.Size(213, 24);
            this.mPClientes.Text = "P. de Clientes";
            this.mPClientes.Visible = false;
            this.mPClientes.Click += new System.EventHandler(this.mPClientes_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(210, 6);
            this.toolStripSeparator6.Visible = false;
            // 
            // mPProveedores
            // 
            this.mPProveedores.Name = "mPProveedores";
            this.mPProveedores.Size = new System.Drawing.Size(213, 24);
            this.mPProveedores.Text = "Pedir a Proveedores";
            this.mPProveedores.Click += new System.EventHandler(this.bPedido_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRespaldar,
            this.toolStripSeparator7,
            this.menuImportar});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(91, 23);
            this.toolStripMenuItem4.Text = "&Respaldos";
            // 
            // menuRespaldar
            // 
            this.menuRespaldar.Name = "menuRespaldar";
            this.menuRespaldar.Size = new System.Drawing.Size(147, 24);
            this.menuRespaldar.Text = "Respaldar";
            this.menuRespaldar.Click += new System.EventHandler(this.menuRespaldar_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(144, 6);
            // 
            // menuImportar
            // 
            this.menuImportar.Name = "menuImportar";
            this.menuImportar.Size = new System.Drawing.Size(147, 24);
            this.menuImportar.Text = "Importar";
            this.menuImportar.Click += new System.EventHandler(this.menuImportar_Click);
            // 
            // bPedidosCliente
            // 
            this.bPedidosCliente.BackgroundImage = global::Ing_SW_B.Properties.Resources.telefono;
            this.bPedidosCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPedidosCliente.Location = new System.Drawing.Point(26, 235);
            this.bPedidosCliente.Name = "bPedidosCliente";
            this.bPedidosCliente.Size = new System.Drawing.Size(124, 121);
            this.bPedidosCliente.TabIndex = 7;
            this.bPedidosCliente.UseVisualStyleBackColor = true;
            this.bPedidosCliente.Visible = false;
            this.bPedidosCliente.Click += new System.EventHandler(this.mPClientes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "P. Clientes";
            this.label4.Visible = false;
            // 
            // dImportar
            // 
            this.dImportar.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ing_SW_B.Properties.Resources.abarrotestr;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::Ing_SW_B.Properties.Resources.abarrotestr;
            this.pictureBox1.Location = new System.Drawing.Point(79, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 182);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(586, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPedido);
            this.Controls.Add(this.bReportes);
            this.Controls.Add(this.bVenta);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bPedidosCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVenta;
        private System.Windows.Forms.Button bReportes;
        private System.Windows.Forms.Button bPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mProveedores;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mACliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mAProveedor;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mProductos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mBCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mBProveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mBProducto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mPClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mPProveedores;
        private System.Windows.Forms.Button bPedidosCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuRespaldar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuImportar;
        private System.Windows.Forms.SaveFileDialog dRespaldar;
        private System.Windows.Forms.OpenFileDialog dImportar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

