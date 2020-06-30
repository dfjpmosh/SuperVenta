namespace Ing_SW_B
{
    partial class FormReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bImpReportes = new System.Windows.Forms.Button();
            this.rbDia = new System.Windows.Forms.RadioButton();
            this.rbSemana = new System.Windows.Forms.RadioButton();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbAño = new System.Windows.Forms.RadioButton();
            this.gBPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.bBuscarPeriodo = new System.Windows.Forms.Button();
            this.mcSemana = new System.Windows.Forms.MonthCalendar();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bImpVentas = new System.Windows.Forms.Button();
            this.bDetalleVenta = new System.Windows.Forms.Button();
            this.dtpPeridoFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.IdProveedorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProductoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.gBPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
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
            this.IdProduct,
            this.NomProducto,
            this.Existencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.Location = new System.Drawing.Point(234, 286);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(479, 128);
            this.dgvProductos.TabIndex = 16;
            // 
            // IdProduct
            // 
            this.IdProduct.HeaderText = "Id";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            // 
            // NomProducto
            // 
            this.NomProducto.HeaderText = "Producto";
            this.NomProducto.Name = "NomProducto";
            this.NomProducto.ReadOnly = true;
            this.NomProducto.Width = 250;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.NomProveedor});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 286);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(225, 128);
            this.dgvProveedores.TabIndex = 15;
            this.dgvProveedores.SelectionChanged += new System.EventHandler(this.dgvProveedores_SelectionChanged);
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "Id";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            // 
            // NomProveedor
            // 
            this.NomProveedor.HeaderText = "Proveedor";
            this.NomProveedor.Name = "NomProveedor";
            this.NomProveedor.ReadOnly = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.Total,
            this.Fecha});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.Location = new System.Drawing.Point(390, 12);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(323, 210);
            this.dgvVentas.TabIndex = 20;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.BackColor = System.Drawing.Color.White;
            this.lCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(12, 3);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(64, 22);
            this.lCliente.TabIndex = 21;
            this.lCliente.Text = "Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Venta Total del Periodo";
            // 
            // tbVenta
            // 
            this.tbVenta.BackColor = System.Drawing.Color.White;
            this.tbVenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVenta.Location = new System.Drawing.Point(600, 228);
            this.tbVenta.Name = "tbVenta";
            this.tbVenta.ReadOnly = true;
            this.tbVenta.Size = new System.Drawing.Size(113, 29);
            this.tbVenta.TabIndex = 23;
            this.tbVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Existencias";
            // 
            // bImpReportes
            // 
            this.bImpReportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImpReportes.Location = new System.Drawing.Point(265, 417);
            this.bImpReportes.Name = "bImpReportes";
            this.bImpReportes.Size = new System.Drawing.Size(195, 46);
            this.bImpReportes.TabIndex = 25;
            this.bImpReportes.Text = "Imprimir Reporte de Existencias del Proveedor";
            this.bImpReportes.UseVisualStyleBackColor = true;
            this.bImpReportes.Click += new System.EventHandler(this.bImpReportes_Click);
            // 
            // rbDia
            // 
            this.rbDia.AutoSize = true;
            this.rbDia.BackColor = System.Drawing.Color.White;
            this.rbDia.Checked = true;
            this.rbDia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDia.Location = new System.Drawing.Point(9, 25);
            this.rbDia.Name = "rbDia";
            this.rbDia.Size = new System.Drawing.Size(51, 23);
            this.rbDia.TabIndex = 26;
            this.rbDia.TabStop = true;
            this.rbDia.Text = "Dia";
            this.rbDia.UseVisualStyleBackColor = false;
            this.rbDia.CheckedChanged += new System.EventHandler(this.rbDia_CheckedChanged);
            // 
            // rbSemana
            // 
            this.rbSemana.AutoSize = true;
            this.rbSemana.BackColor = System.Drawing.Color.White;
            this.rbSemana.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSemana.Location = new System.Drawing.Point(66, 20);
            this.rbSemana.Name = "rbSemana";
            this.rbSemana.Size = new System.Drawing.Size(80, 23);
            this.rbSemana.TabIndex = 27;
            this.rbSemana.Text = "Semana";
            this.rbSemana.UseVisualStyleBackColor = false;
            this.rbSemana.CheckedChanged += new System.EventHandler(this.rbSemana_CheckedChanged);
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.BackColor = System.Drawing.Color.White;
            this.rbMes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMes.Location = new System.Drawing.Point(142, 25);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(58, 23);
            this.rbMes.TabIndex = 28;
            this.rbMes.Text = "Mes";
            this.rbMes.UseVisualStyleBackColor = false;
            this.rbMes.CheckedChanged += new System.EventHandler(this.rbMes_CheckedChanged);
            // 
            // rbAño
            // 
            this.rbAño.AutoSize = true;
            this.rbAño.BackColor = System.Drawing.Color.White;
            this.rbAño.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAño.Location = new System.Drawing.Point(200, 25);
            this.rbAño.Name = "rbAño";
            this.rbAño.Size = new System.Drawing.Size(54, 23);
            this.rbAño.TabIndex = 29;
            this.rbAño.Text = "Año";
            this.rbAño.UseVisualStyleBackColor = false;
            this.rbAño.CheckedChanged += new System.EventHandler(this.rbAño_CheckedChanged);
            // 
            // gBPeriodo
            // 
            this.gBPeriodo.BackColor = System.Drawing.Color.White;
            this.gBPeriodo.Controls.Add(this.rbSemana);
            this.gBPeriodo.Controls.Add(this.rbDia);
            this.gBPeriodo.Controls.Add(this.rbAño);
            this.gBPeriodo.Controls.Add(this.rbMes);
            this.gBPeriodo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPeriodo.Location = new System.Drawing.Point(16, 24);
            this.gBPeriodo.Name = "gBPeriodo";
            this.gBPeriodo.Size = new System.Drawing.Size(261, 65);
            this.gBPeriodo.TabIndex = 30;
            this.gBPeriodo.TabStop = false;
            this.gBPeriodo.Text = "Periodo";
            this.gBPeriodo.Visible = false;
            // 
            // dtpPeriodo
            // 
            this.dtpPeriodo.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeriodo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeriodo.Location = new System.Drawing.Point(16, 104);
            this.dtpPeriodo.MinDate = new System.DateTime(2000, 12, 25, 23, 59, 59, 0);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.Size = new System.Drawing.Size(221, 22);
            this.dtpPeriodo.TabIndex = 31;
            // 
            // bBuscarPeriodo
            // 
            this.bBuscarPeriodo.BackgroundImage = global::Ing_SW_B.Properties.Resources.lupa;
            this.bBuscarPeriodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscarPeriodo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarPeriodo.Location = new System.Drawing.Point(292, 24);
            this.bBuscarPeriodo.Name = "bBuscarPeriodo";
            this.bBuscarPeriodo.Size = new System.Drawing.Size(71, 65);
            this.bBuscarPeriodo.TabIndex = 32;
            this.bBuscarPeriodo.UseVisualStyleBackColor = true;
            this.bBuscarPeriodo.Click += new System.EventHandler(this.bBuscarPeriodo_Click);
            // 
            // mcSemana
            // 
            this.mcSemana.Font = new System.Drawing.Font("Times New Roman", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcSemana.Location = new System.Drawing.Point(16, 102);
            this.mcSemana.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.mcSemana.Name = "mcSemana";
            this.mcSemana.ShowToday = false;
            this.mcSemana.TabIndex = 33;
            this.mcSemana.Visible = false;
            // 
            // IdProducto
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProducto.DefaultCellStyle = dataGridViewCellStyle7;
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.Name = "IdProducto";
            // 
            // bImpVentas
            // 
            this.bImpVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImpVentas.Location = new System.Drawing.Point(271, 188);
            this.bImpVentas.Name = "bImpVentas";
            this.bImpVentas.Size = new System.Drawing.Size(92, 65);
            this.bImpVentas.TabIndex = 34;
            this.bImpVentas.Text = "Imprimir Reporte de Ventas";
            this.bImpVentas.UseVisualStyleBackColor = true;
            this.bImpVentas.Click += new System.EventHandler(this.bImpVentas_Click);
            // 
            // bDetalleVenta
            // 
            this.bDetalleVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetalleVenta.Location = new System.Drawing.Point(271, 104);
            this.bDetalleVenta.Name = "bDetalleVenta";
            this.bDetalleVenta.Size = new System.Drawing.Size(92, 65);
            this.bDetalleVenta.TabIndex = 35;
            this.bDetalleVenta.Text = "Ver Detalle de Venta";
            this.bDetalleVenta.UseVisualStyleBackColor = true;
            this.bDetalleVenta.Click += new System.EventHandler(this.bDetalleVenta_Click);
            // 
            // dtpPeridoFinal
            // 
            this.dtpPeridoFinal.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeridoFinal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeridoFinal.Location = new System.Drawing.Point(16, 167);
            this.dtpPeridoFinal.MinDate = new System.DateTime(2000, 12, 25, 23, 59, 59, 0);
            this.dtpPeridoFinal.Name = "dtpPeridoFinal";
            this.dtpPeridoFinal.Size = new System.Drawing.Size(221, 22);
            this.dtpPeridoFinal.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Pedidos";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedorP,
            this.IdProductoP,
            this.CantidadP,
            this.FechaP});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 498);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(575, 135);
            this.dgvPedidos.TabIndex = 40;
            // 
            // IdProveedorP
            // 
            this.IdProveedorP.HeaderText = "IdProveedor";
            this.IdProveedorP.Name = "IdProveedorP";
            this.IdProveedorP.ReadOnly = true;
            // 
            // IdProductoP
            // 
            this.IdProductoP.HeaderText = "IdProducto";
            this.IdProductoP.Name = "IdProductoP";
            this.IdProductoP.ReadOnly = true;
            // 
            // CantidadP
            // 
            this.CantidadP.HeaderText = "Cantidad";
            this.CantidadP.Name = "CantidadP";
            this.CantidadP.ReadOnly = true;
            // 
            // FechaP
            // 
            this.FechaP.HeaderText = "Fecha";
            this.FechaP.Name = "FechaP";
            this.FechaP.ReadOnly = true;
            this.FechaP.Width = 250;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ing_SW_B.Properties.Resources.abarrotestr;
            this.ClientSize = new System.Drawing.Size(725, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpPeridoFinal);
            this.Controls.Add(this.bDetalleVenta);
            this.Controls.Add(this.bImpVentas);
            this.Controls.Add(this.bBuscarPeriodo);
            this.Controls.Add(this.dtpPeriodo);
            this.Controls.Add(this.bImpReportes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.gBPeriodo);
            this.Controls.Add(this.mcSemana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.gBPeriodo.ResumeLayout(false);
            this.gBPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bImpReportes;
        private System.Windows.Forms.RadioButton rbDia;
        private System.Windows.Forms.RadioButton rbSemana;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbAño;
        private System.Windows.Forms.GroupBox gBPeriodo;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.Button bBuscarPeriodo;
        private System.Windows.Forms.MonthCalendar mcSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button bImpVentas;
        private System.Windows.Forms.Button bDetalleVenta;
        private System.Windows.Forms.DateTimePicker dtpPeridoFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaP;
    }
}