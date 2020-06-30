namespace Ing_SW_B
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.lTelefono = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubtotales = new System.Windows.Forms.DataGridView();
            this.Subtotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbFolio = new System.Windows.Forms.TextBox();
            this.lFolio = new System.Windows.Forms.Label();
            this.bVDomicilio = new System.Windows.Forms.Button();
            this.bVCaja = new System.Windows.Forms.Button();
            this.bBuscarCli = new System.Windows.Forms.Button();
            this.dgvCantidad = new System.Windows.Forms.DataGridView();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridView();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bVPendiente = new System.Windows.Forms.Button();
            this.bImpPedido = new System.Windows.Forms.Button();
            this.bEliminarProducto = new System.Windows.Forms.Button();
            this.bImpRegVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(561, 35);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(90, 22);
            this.lTelefono.TabIndex = 0;
            this.lTelefono.Text = "Teléfono: ";
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.White;
            this.tbTelefono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(657, 33);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(109, 29);
            this.tbTelefono.TabIndex = 2;
            this.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.Color.White;
            this.tbDireccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(149, 81);
            this.tbDireccion.MaxLength = 50;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ReadOnly = true;
            this.tbDireccion.Size = new System.Drawing.Size(617, 29);
            this.tbDireccion.TabIndex = 3;
            this.tbDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lDireccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.Location = new System.Drawing.Point(44, 84);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(99, 22);
            this.lDireccion.TabIndex = 2;
            this.lDireccion.Text = "Dirección: ";
            // 
            // tbCliente
            // 
            this.tbCliente.BackColor = System.Drawing.Color.White;
            this.tbCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(330, 33);
            this.tbCliente.MaxLength = 50;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(225, 29);
            this.tbCliente.TabIndex = 4;
            this.tbCliente.Text = "Venta de Caja";
            this.tbCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.BackColor = System.Drawing.Color.Transparent;
            this.lCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(251, 36);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(73, 22);
            this.lCliente.TabIndex = 4;
            this.lCliente.Text = "Cliente:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.Location = new System.Drawing.Point(16, 153);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(172, 307);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEndEdit);
            this.dgvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellValueChanged);
            // 
            // IdProducto
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.MaxInputLength = 10;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 150;
            // 
            // dgvSubtotales
            // 
            this.dgvSubtotales.AllowUserToAddRows = false;
            this.dgvSubtotales.AllowUserToDeleteRows = false;
            this.dgvSubtotales.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubtotales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubtotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubtotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subtotales});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubtotales.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSubtotales.Location = new System.Drawing.Point(690, 153);
            this.dgvSubtotales.MultiSelect = false;
            this.dgvSubtotales.Name = "dgvSubtotales";
            this.dgvSubtotales.ReadOnly = true;
            this.dgvSubtotales.RowHeadersVisible = false;
            this.dgvSubtotales.Size = new System.Drawing.Size(116, 307);
            this.dgvSubtotales.TabIndex = 7;
            this.dgvSubtotales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubtotales_CellValueChanged);
            this.dgvSubtotales.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSubtotales_RowsAdded);
            this.dgvSubtotales.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSubtotales_RowsRemoved);
            // 
            // Subtotales
            // 
            this.Subtotales.HeaderText = "Subtotales";
            this.Subtotales.Name = "Subtotales";
            this.Subtotales.ReadOnly = true;
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.White;
            this.tbTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(665, 466);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(143, 29);
            this.tbTotal.TabIndex = 9;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(574, 469);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(85, 22);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "TOTAL: ";
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(16, 526);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(124, 30);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "Cancelar Venta";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(682, 526);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(124, 30);
            this.bAceptar.TabIndex = 12;
            this.bAceptar.Text = "Registrar Venta";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tbFolio
            // 
            this.tbFolio.BackColor = System.Drawing.Color.White;
            this.tbFolio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFolio.Location = new System.Drawing.Point(112, 33);
            this.tbFolio.MaxLength = 50;
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.ReadOnly = true;
            this.tbFolio.Size = new System.Drawing.Size(100, 29);
            this.tbFolio.TabIndex = 14;
            this.tbFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lFolio
            // 
            this.lFolio.AutoSize = true;
            this.lFolio.BackColor = System.Drawing.Color.Transparent;
            this.lFolio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFolio.Location = new System.Drawing.Point(44, 36);
            this.lFolio.Name = "lFolio";
            this.lFolio.Size = new System.Drawing.Size(62, 22);
            this.lFolio.TabIndex = 13;
            this.lFolio.Text = "Folio: ";
            // 
            // bVDomicilio
            // 
            this.bVDomicilio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVDomicilio.Location = new System.Drawing.Point(130, 33);
            this.bVDomicilio.Name = "bVDomicilio";
            this.bVDomicilio.Size = new System.Drawing.Size(109, 30);
            this.bVDomicilio.TabIndex = 16;
            this.bVDomicilio.Text = "V. Domicilio";
            this.bVDomicilio.UseVisualStyleBackColor = true;
            this.bVDomicilio.Visible = false;
            this.bVDomicilio.Click += new System.EventHandler(this.bVDomicilio_Click);
            // 
            // bVCaja
            // 
            this.bVCaja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVCaja.Location = new System.Drawing.Point(16, 33);
            this.bVCaja.Name = "bVCaja";
            this.bVCaja.Size = new System.Drawing.Size(109, 30);
            this.bVCaja.TabIndex = 15;
            this.bVCaja.Text = "V. Caja";
            this.bVCaja.UseVisualStyleBackColor = true;
            this.bVCaja.Visible = false;
            this.bVCaja.Click += new System.EventHandler(this.bVCaja_Click);
            // 
            // bBuscarCli
            // 
            this.bBuscarCli.BackgroundImage = global::Ing_SW_B.Properties.Resources.lupa;
            this.bBuscarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscarCli.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarCli.Location = new System.Drawing.Point(772, 32);
            this.bBuscarCli.Name = "bBuscarCli";
            this.bBuscarCli.Size = new System.Drawing.Size(34, 30);
            this.bBuscarCli.TabIndex = 18;
            this.bBuscarCli.UseVisualStyleBackColor = true;
            this.bBuscarCli.Click += new System.EventHandler(this.bBuscarCli_Click);
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.AllowUserToAddRows = false;
            this.dgvCantidad.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCantidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCantidad});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCantidad.Location = new System.Drawing.Point(546, 153);
            this.dgvCantidad.MultiSelect = false;
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.RowHeadersVisible = false;
            this.dgvCantidad.Size = new System.Drawing.Size(122, 307);
            this.dgvCantidad.TabIndex = 3;
            this.dgvCantidad.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCantidad_CellEndEdit);
            this.dgvCantidad.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCantidad_CellValueChanged);
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.MaxInputLength = 3;
            this.CCantidad.Name = "CCantidad";
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.AllowUserToAddRows = false;
            this.dgvDescripcion.AllowUserToDeleteRows = false;
            this.dgvDescripcion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescripcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreP,
            this.PUnitario});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescripcion.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDescripcion.Location = new System.Drawing.Point(210, 153);
            this.dgvDescripcion.MultiSelect = false;
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.RowHeadersVisible = false;
            this.dgvDescripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescripcion.Size = new System.Drawing.Size(314, 307);
            this.dgvDescripcion.TabIndex = 20;
            this.dgvDescripcion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescripcion_CellValueChanged);
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre";
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Width = 200;
            // 
            // PUnitario
            // 
            this.PUnitario.HeaderText = "P. Unitario";
            this.PUnitario.Name = "PUnitario";
            this.PUnitario.ReadOnly = true;
            this.PUnitario.Width = 110;
            // 
            // bVPendiente
            // 
            this.bVPendiente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVPendiente.Location = new System.Drawing.Point(242, 491);
            this.bVPendiente.Name = "bVPendiente";
            this.bVPendiente.Size = new System.Drawing.Size(118, 65);
            this.bVPendiente.TabIndex = 21;
            this.bVPendiente.Text = "Dejar Venta Pendiente y Crear Nueva Venta";
            this.bVPendiente.UseVisualStyleBackColor = true;
            this.bVPendiente.Visible = false;
            this.bVPendiente.Click += new System.EventHandler(this.bVPendiente_Click);
            // 
            // bImpPedido
            // 
            this.bImpPedido.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bImpPedido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImpPedido.Location = new System.Drawing.Point(369, 491);
            this.bImpPedido.Name = "bImpPedido";
            this.bImpPedido.Size = new System.Drawing.Size(86, 65);
            this.bImpPedido.TabIndex = 10;
            this.bImpPedido.Text = "Imprimir Pedido";
            this.bImpPedido.UseVisualStyleBackColor = true;
            this.bImpPedido.Visible = false;
            this.bImpPedido.Click += new System.EventHandler(this.bImpPedido_Click);
            // 
            // bEliminarProducto
            // 
            this.bEliminarProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminarProducto.Location = new System.Drawing.Point(16, 465);
            this.bEliminarProducto.Name = "bEliminarProducto";
            this.bEliminarProducto.Size = new System.Drawing.Size(172, 30);
            this.bEliminarProducto.TabIndex = 22;
            this.bEliminarProducto.Text = "Eliminar Producto";
            this.bEliminarProducto.UseVisualStyleBackColor = true;
            this.bEliminarProducto.Click += new System.EventHandler(this.bEliminarProducto_Click);
            // 
            // bImpRegVenta
            // 
            this.bImpRegVenta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bImpRegVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImpRegVenta.Location = new System.Drawing.Point(462, 491);
            this.bImpRegVenta.Name = "bImpRegVenta";
            this.bImpRegVenta.Size = new System.Drawing.Size(118, 65);
            this.bImpRegVenta.TabIndex = 23;
            this.bImpRegVenta.Text = "Imprimir y Registrar Venta";
            this.bImpRegVenta.UseVisualStyleBackColor = true;
            this.bImpRegVenta.Click += new System.EventHandler(this.bImpRegVenta_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ing_SW_B.Properties.Resources.abarrotestr;
            this.ClientSize = new System.Drawing.Size(824, 568);
            this.Controls.Add(this.bImpRegVenta);
            this.Controls.Add(this.bEliminarProducto);
            this.Controls.Add(this.bVPendiente);
            this.Controls.Add(this.dgvDescripcion);
            this.Controls.Add(this.dgvCantidad);
            this.Controls.Add(this.bBuscarCli);
            this.Controls.Add(this.tbFolio);
            this.Controls.Add(this.lFolio);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bImpPedido);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dgvSubtotales);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.bVDomicilio);
            this.Controls.Add(this.bVCaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvSubtotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotales;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dgvCantidad;
        private System.Windows.Forms.DataGridView dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.Button bEliminarProducto;
        public System.Windows.Forms.TextBox tbTelefono;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.TextBox tbCliente;
        public System.Windows.Forms.Button bCancelar;
        public System.Windows.Forms.Button bAceptar;
        public System.Windows.Forms.TextBox tbFolio;
        public System.Windows.Forms.Label lFolio;
        public System.Windows.Forms.Button bVDomicilio;
        public System.Windows.Forms.Button bVCaja;
        public System.Windows.Forms.Button bBuscarCli;
        public System.Windows.Forms.Button bVPendiente;
        public System.Windows.Forms.Button bImpPedido;
        public System.Windows.Forms.Button bImpRegVenta;
    }
}