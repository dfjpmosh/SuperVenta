using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;

namespace Ing_SW_B
{
    public partial class FormVenta : Form
    {
        /*=======================================================================
         * Instancias de la clase
         *=======================================================================*/
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private CExistencias producto;
        private CVentas venta;
        private List<int> lfolios = new List<int>();
        private int indC;
        private Font Fuente;
        private StreamReader streamParaImp;

        /*=======================================================================
         * Constructor de la clase
         *=======================================================================*/
        public FormVenta()
        {
            InitializeComponent();
            leerRegistroVentas();
            ponerFolio();
            
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            
        }

        /*=======================================================================
         * Este metodo activa o desactiva controles en el formulario
         *=======================================================================*/
        private void bVCaja_Click(object sender, EventArgs e)
        {
            tbTelefono.Enabled = false;
            bBuscarCli.Enabled = false;
            tbDireccion.Enabled = false;
            tbCliente.Text = "Venta de Caja";
            tbTelefono.Text = "";
            tbDireccion.Text = "";
            dgvProductos.Focus();
        }

        /*=======================================================================
         * Este metodo activa o desactiva controles en el formulario
         *=======================================================================*/
        private void bVDomicilio_Click(object sender, EventArgs e)
        {
            tbTelefono.Enabled = true;
            bBuscarCli.Enabled = true;
            tbDireccion.Enabled = true;
            tbCliente.Text = "";
            tbTelefono.Focus();
        }

        /*=======================================================================
         * Este metodo se encarga de buscar un cliente en la base de datos
         * si lo encutra muestra sus datos, sino da la opción de agregarlo
         *=======================================================================*/
        private void bBuscarCli_Click(object sender, EventArgs e)
        {
            dgvProductos.Focus();
            bool b=false;

            if (tbTelefono.TextLength < 7 || (tbTelefono.TextLength > 7 && tbTelefono.TextLength < 10) || tbTelefono.TextLength > 10)
            {
                MessageBox.Show("El Numero Telefonico No Es Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTelefono.Focus();
            }
            else
            {
                b = buscarRegistro(tbTelefono.Text);

                if (!b)
                {
                    if (MessageBox.Show("El Cliente No Existe, Desea Darlo De Alta?", "El Cliente No Existe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        FormAltaCliente fac = new FormAltaCliente();

                        fac.tbTelefono.Text = tbTelefono.Text;
                        if (fac.ShowDialog() == DialogResult.OK)
                        {
                            tbTelefono.Text = fac.tbTelefono.Text;
                            tbCliente.Text = fac.tbNombre.Text + " " + fac.tbApellido.Text;
                            tbDireccion.Text = fac.tbDireccion.Text;
                        }
                    }
                    else
                    {
                        tbTelefono.Text = "";
                        tbTelefono.Focus();
                    }
                }
                else
                {
                    leerRegistro(tbTelefono.Text);
                }
            }
        }

        /*=======================================================================
         * Este metodo hace la consulta para la busqueda en la base de datos
         *=======================================================================*/
        private bool buscarRegistro(string id)
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT COUNT(*) FROM Cliente WHERE IdTelefono=@Id";
                OleDbCommand cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("Id", id);
                cn.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }

        /*=======================================================================
         * Este metodo busca los datos del cliente
         *=======================================================================*/
        private void leerRegistro(string id)
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT IdTelefono, Nombre, Apellido, Direccion FROM Cliente WHERE IdTelefono=@Id";
                OleDbCommand cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("Id", id);
                cn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tbTelefono.Text = reader.GetString(0);
                    tbCliente.Text = reader.GetString(1);
                    tbCliente.Text +=" "+ reader.GetString(2);
                    tbDireccion.Text = reader.GetString(3);
                }
                cn.Close();
            }
        }

        /*=======================================================================
         * Este metodo actualiza el datagrid de los productos
         *=======================================================================*/
        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Point ind = dgvProductos.CurrentCellAddress;

            if(productoRegistrado(ind) == false)
            if (ind.X == 0 && dgvProductos[ind.X, ind.Y].Value != null)
            {
                string idp = dgvProductos[ind.X, ind.Y].Value.ToString();
                leerRegistroExistencias(idp);

                if (producto != null)
                {
                    dgvDescripcion.Rows.Add();
                    dgvDescripcion[0, ind.Y].Value = producto.nombre;
                    dgvDescripcion[1, ind.Y].Value = producto.precio.ToString("C2");
                    dgvCantidad.Rows.Add();
                    dgvCantidad[0, ind.Y].Value = "1";
                    float precio = Convert.ToSingle(dgvDescripcion[1, ind.Y].Value.ToString().Substring(1));
                    int cantidad = Convert.ToInt32(dgvCantidad[0, ind.Y].Value.ToString());
                    dgvSubtotales[0, ind.Y].Value = (precio * cantidad).ToString("C2"); 
                }
                else
                {
                    MessageBox.Show("No Existen Productos Con La Clave Ingresada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvProductos.Rows.RemoveAt(ind.Y);
                    if (dgvDescripcion.RowCount > ind.Y)
                    {
                        dgvDescripcion.Rows.RemoveAt(ind.Y);
                        dgvCantidad.Rows.RemoveAt(ind.Y);
                        dgvSubtotales.Rows.RemoveAt(ind.Y);
                    }
                    dgvProductos.CurrentCell = dgvProductos[0, dgvProductos.RowCount - 1];
                }
            }
            
        }

        /*=======================================================================
         * Este metodo busca la clave del producto ingresado
         *=======================================================================*/
        private void leerRegistroExistencias(string id)
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT IdProducto, Nombre, Precio, Cantidad, IdProveedor FROM Existencias WHERE IdProducto=@Id";
                OleDbCommand cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("Id", id);

                cn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        producto = new CExistencias();
                        producto.idProducto = Convert.ToInt64(reader.GetString(0));
                        producto.nombre = reader.GetString(1);
                        producto.precio = reader.GetFloat(2);
                        producto.cantidad = reader.GetInt16(3);
                        producto.idProveedor = Convert.ToInt64(reader.GetString(4));

                        //lE.Add(producto);
                    }
                }
                else
                {
                    producto = null;                    
                }
                reader.Close();
            }
        }

        /*=======================================================================
         * Este metodo actualiza los subtotales segun los datos de la
         * columna cantidad
         *=======================================================================*/
        private void dgvCantidad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvCantidad_CellEndEdit(sender, e);
            Point ind = dgvCantidad.CurrentCellAddress;
            if (ind != new Point(-1, -1) && dgvProductos.RowCount - 1 > ind.Y)
            {
                verificaExistencias(e.RowIndex);
                if (dgvCantidad.RowCount /*-1*/> dgvSubtotales.RowCount)
                {
                    float precio = Convert.ToSingle(dgvDescripcion[1, ind.Y].Value.ToString().Substring(1));
                    int cantidad = Convert.ToInt32(dgvCantidad[0, ind.Y].Value.ToString());

                    dgvSubtotales.Rows.Add((precio * cantidad).ToString("C2"));
                }
                else
                {
                    int i = indC;//dgvCantidad.CurrentRow.Index;
                    float precio = Convert.ToSingle(dgvDescripcion[1, i].Value.ToString().Substring(1));
                    int cantidad = Convert.ToInt32(dgvCantidad[0, i].Value.ToString());

                    dgvSubtotales[0, i].Value = (precio * cantidad).ToString("C2");
                }
            }
            else
            {
                if (dgvProductos.RowCount - 1 <= ind.Y)
                    dgvCantidad.Rows.RemoveAt(dgvCantidad.RowCount - 2);
            }
        }

        /*=======================================================================
         * Este metodo actualiza el total cuando se modifica la columna subtotales
         *=======================================================================*/
        private void dgvSubtotales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Point ind = dgvCantidad.CurrentCellAddress;
            int i=0;
            float total=0;

            if (ind != new Point(-1, -1))
            {
                for(i=0;i<dgvSubtotales.RowCount;i++)
                    total+=Convert.ToSingle(dgvSubtotales[0,i].Value.ToString().Substring(1));
            }
            tbTotal.Text = total.ToString("C2");            
        }

        /*=======================================================================
         * Este evento se ejecuta cuando se agrega una fila al datagrid
         * subtotales 
         *=======================================================================*/
        private void dgvSubtotales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Point ind = dgvCantidad.CurrentCellAddress;
            int i = 0;
            float total = 0;

            if (ind != new Point(-1, -1))
            {
                for (i = 0; i < dgvSubtotales.RowCount; i++)
                    total += Convert.ToSingle(dgvSubtotales[0, i].Value.ToString().Substring(1));
            }
            tbTotal.Text = Convert.ToString(total);
        }

        /*=======================================================================
         * Este evento se ejecuto cuando se eliman una fila del datagrid 
         * subtotales
         *=======================================================================*/
        private void dgvSubtotales_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Point ind = dgvCantidad.CurrentCellAddress;
            int i = 0;
            float total = 0;

            if (ind != new Point(-1, -1))
            {
                for (i = 0; i < dgvSubtotales.RowCount; i++)
                    total += Convert.ToSingle(dgvSubtotales[0, i].Value.ToString().Substring(1));
            }
            tbTotal.Text = total.ToString("C2");
        }

        /*=======================================================================
         * Este metodo muestra los datos del produto ingresado
         *=======================================================================*/
        public bool productoRegistrado(Point ind)
        {
            int i, cantidad=0; 
            
            for (i = 0; i < dgvProductos.RowCount - 1; i++)
            {
                if (dgvProductos[0, i].Value != null && dgvProductos[0, ind.Y].Value != null && dgvProductos[0, i].Value.ToString() == dgvProductos[0, ind.Y].Value.ToString() && i != ind.Y)
                {
                    indC = i;
                    cantidad = Convert.ToInt32(dgvCantidad[0, i].Value.ToString());
                    cantidad++;
                    dgvCantidad[0, i].Value = cantidad;
                    dgvProductos.Rows.RemoveAt(ind.Y);
                    if (dgvDescripcion.RowCount > ind.Y)
                    {
                        dgvDescripcion.Rows.RemoveAt(ind.Y);
                        dgvCantidad.Rows.RemoveAt(ind.Y);
                        dgvSubtotales.Rows.RemoveAt(ind.Y);
                    }
                    dgvProductos.CurrentCell = dgvProductos[0, dgvProductos.RowCount - 1];
                    return true;
                }
            }
            return false;
        }

        /*=======================================================================
         * Este metodo lee las ventas para saber cual folio sigue
         *=======================================================================*/
        private void leerRegistroVentas()
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT * FROM Ventas";
                OleDbCommand cmd = new OleDbCommand(query, cn);
                
                cn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        venta = new CVentas();
                        venta.folio = reader.GetInt32(0);
                        venta.fecha = reader.GetString(1);
                        venta.detalleVenta = reader.GetInt32(2);
                        venta.total = reader.GetFloat(3);
                        lfolios.Add(venta.folio);
                    }
                }
                else
                {
                    venta = null;
                }
                reader.Close();
            }
        }

        /*=======================================================================
         * Este valida los datos de la interfaz y si son correctos registra la venta
         *=======================================================================*/
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount > 1)
            {
                int i;
                RegistraVenta();
                actualizaExistencias();

                for (i = 0; i < dgvProductos.RowCount - 1; i++)
                    RegistraDetalleVenta(i);

                Mensaje();
            }
            else
                MessageBox.Show("No hay Productos para Registrar la Venta ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /*=======================================================================
         * Este metodo registra la venta y actualiza las existencias
         * en la base de datos
         *=======================================================================*/
        private void RegistraVenta()
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection(conexion);
                const string insert = @"insert into Ventas(Folio, Fecha, DetalleVenta, Total)values (@iventa, @fventa, @dventa, @tventa)";
                OleDbCommand cmd = new OleDbCommand(insert, cnn);
                cmd.Parameters.AddWithValue("@iventa", tbFolio.Text);
                cmd.Parameters.AddWithValue("@fventa", DateTime.Today.ToString("d") + " " + DateTime.Now.ToLongTimeString());
                cmd.Parameters.AddWithValue("@dventa", tbFolio.Text);
                cmd.Parameters.AddWithValue("@tventa", tbTotal.Text);
                cnn.Open();
                int exe = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Ocurrió un error al insertar: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /*=======================================================================
         * Este metod actualiza las existencias en la base de datos
         *=======================================================================*/
        private void actualizaExistencias()
        {
            int i;
            List<CExistencias> lEAux = new List<CExistencias>();
            List<CExistencias> lE = new List<CExistencias>();

            for (i = 0; i < dgvCantidad.RowCount; i++ )
            {
                leerRegistroExistencias(dgvProductos[0, i].Value.ToString());
                using (OleDbConnection cn = new OleDbConnection(conexion))
                {
                    string query = "UPDATE Existencias SET [Cantidad] = @cantidad WHERE IdProducto=@Id";
                    OleDbCommand cmd = new OleDbCommand(query, cn);
                    cmd.Parameters.AddWithValue("@cantidad", producto.cantidad - Convert.ToInt32(dgvCantidad[0, i].Value.ToString()));
                    cmd.Parameters.AddWithValue("@Id", dgvProductos[0, i].Value.ToString());

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        /*=======================================================================
         * Este metodo registra el Detalle de Venta en la base de datos
         *=======================================================================*/
        private void RegistraDetalleVenta(int i)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection(conexion);
                const string insert = @"insert into DetalleVenta(Folio, idProducto, Cantidad, PrecioUnitario, Subtotal)values (@fo, @ip, @ca, @pu, @st)";
                OleDbCommand cmd = new OleDbCommand(insert, cnn);
                cmd.Parameters.AddWithValue("@fo", tbFolio.Text);
                cmd.Parameters.AddWithValue("@ip", dgvProductos[0, i].Value.ToString());
                cmd.Parameters.AddWithValue("@ca", Convert.ToInt32(dgvCantidad[0, i].Value.ToString()));
                cmd.Parameters.AddWithValue("@pu", Convert.ToSingle(dgvDescripcion[1, i].Value.ToString().Substring(1)));
                cmd.Parameters.AddWithValue("@st", Convert.ToSingle(dgvSubtotales[0, i].Value.ToString().Substring(1)));
                cnn.Open();
                int exe = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Ocurrió un error al insertar: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bVPendiente_Click(object sender, EventArgs e)
        {
            FormVenta nfv = new FormVenta();

            if (lfolios[lfolios.Count - 1] + 1 == Convert.ToInt32(tbFolio.Text))
                nfv.tbFolio.Text = (Convert.ToInt32(tbFolio.Text) + 1).ToString();
            else
                nfv.tbFolio.Text = Convert.ToString(lfolios[lfolios.Count - 1] + 1);
            nfv.bVPendiente.Visible = false;
            nfv.bImpPedido.Visible = false;
            nfv.ShowDialog();
        }

        private void ponerFolio()
        {
            lfolios.Sort();
            if (venta == null)
                tbFolio.Text = "1";
            else
            {
                if (lfolios[lfolios.Count - 1] == lfolios.Count)
                    tbFolio.Text = Convert.ToString(lfolios[lfolios.Count - 1] + 1);
                else
                {
                    int cont = 1;

                    foreach (int i in lfolios)
                    {
                        if (i != cont)
                        {
                            tbFolio.Text = Convert.ToString(cont.ToString());
                            break;
                        }
                        cont++;
                    }
                }
            }
        }

        /*=======================================================================
         * Este evento se ejecuta cuando se termina de editar un celda
         * en el datagrid Cantidad
         *=======================================================================*/
        private void dgvCantidad_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvCantidad.RowCount > 0)
            {
                if (dgvCantidad[0, e.RowIndex].Value == null)
                    dgvCantidad[0, e.RowIndex].Value = 0;
                string s = dgvCantidad[0, e.RowIndex].Value.ToString();
                for (i = 0; i < s.Length; i++)
                {
                    if (Char.IsNumber(s.ElementAt(i)) == false)
                    {
                        MessageBox.Show("La Celda\nSolo Puede Contener Valores Numericos Enteros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvCantidad[0, e.RowIndex].Value = "1";
                        break;
                    }
                }

                //verificaExistencias(e.RowIndex);
            }
        }

        /*=======================================================================
         * Este metodo se encarga de verificar las existencias
         *=======================================================================*/
        private void verificaExistencias(int indCantidad)
        {
            int i = dgvProductos.CurrentRow.Index;
            string idP = dgvProductos[0, indCantidad].Value.ToString();
            string cantidad = dgvCantidad[0, indCantidad].Value.ToString();
            leerRegistroExistencias(idP);

            if (Convert.ToInt32(cantidad) > producto.cantidad)
            {
                MessageBox.Show("No hay Existencias Suficientes\nSe Modificara la Cantidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvCantidad[0, indCantidad].Value = producto.cantidad;
            }
            
        }

        /*=======================================================================
         * Este metodo se encarga de eliminar el producto seleccionado
         * de la lista
         *=======================================================================*/
        private void bEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow.Index < dgvProductos.RowCount-1)
            {
                dgvDescripcion.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                dgvCantidad.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                dgvSubtotales.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                dgvProductos.Focus();
                dgvProductos.CurrentCell = dgvProductos[0, dgvProductos.RowCount-1];
            }
            else
                MessageBox.Show("Seleccione un Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                bBuscarCli_Click(null, null);
        }

        /*=======================================================================
         * Este metod imprime la lista de productos
         *=======================================================================*/
        private void bImpPedido_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            crearArchivo();

            try
            {
                streamParaImp = new StreamReader("C:\\temporalSW\\ejemplo.txt");
                try
                {
                    Fuente = new Font("Lucida Console", 10);
                    pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    vistaPrevia.Document = pd;

                    Form f = vistaPrevia as Form;
                    Control[] ts = vistaPrevia.Controls.Find("toolStrip1", true);
                    ToolStrip to = ts[0] as ToolStrip;
                    to.Items.RemoveAt(0);
                    f.WindowState = FormWindowState.Maximized;
                    f.ShowDialog();
                    streamParaImp.Close();
                    streamParaImp = new StreamReader("C:\\temporalSW\\ejemplo.txt");
                    pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamParaImp.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Puede Imprimir\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                File.Delete("C:\\temporalSW\\ejemplo.txt");
            }
        }

        private void crearArchivo()
        {
            int x = 0;
            //int ins = dgvProveedores.CurrentRow.Index;

            try
            {
                StreamWriter sw = new StreamWriter("C:\\temporalSW\\ejemplo.txt", true, Encoding.ASCII);

                sw.WriteLine("                         Pedido Del Cliente");
                sw.WriteLine("");
                sw.WriteLine("Id: " + tbTelefono.Text);
                sw.WriteLine("Cliente: " + tbCliente.Text);
                sw.WriteLine("Tel: " + tbTelefono.Text);
                sw.WriteLine("");
                sw.WriteLine("Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("========================================================================");
                sw.WriteLine("[Producto]                         " + "        [Cantidad]");
                sw.WriteLine("========================================================================");
                for (x = 0; x < dgvCantidad.RowCount; x++ )
                {
                    sw.WriteLine(dgvDescripcion[0, x].Value.ToString() + " " + " " + calculaEspacio(dgvDescripcion[0, x].Value.ToString(), 40) + " " + " " +
                                 dgvCantidad[0, x].Value.ToString());
                }

                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se Puede Imprimir\n" + e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string calculaEspacio(string c, int t)
        {
            int x;
            int s = c.Length;
            int es = t - s;
            string cad = "";
            for (x = 0; x < es; x++)
                cad += "-";
            return cad;
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float lineasPorPagina = 0;
            float yPos = 0;
            int count = 0;
            float margenIzquierda = ev.MarginBounds.Left;
            float margenArriba = ev.MarginBounds.Top;
            string linea = null;

            lineasPorPagina = ev.MarginBounds.Height / Fuente.GetHeight(ev.Graphics);

            while (count < lineasPorPagina && ((linea = streamParaImp.ReadLine()) != null))
            {
                yPos = margenArriba + (count * Fuente.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(linea, Fuente, Brushes.Black, margenIzquierda, yPos, new StringFormat());
                count++;
            }

            if (linea != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void bImpRegVenta_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            crearArchivoVenta();

            try
            {
                streamParaImp = new StreamReader("C:\\temporalSW\\ejemplo.txt");
                try
                {
                    Fuente = new Font("Lucida Console", 9);
                    pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    vistaPrevia.Document = pd;

                    Form f = vistaPrevia as Form;
                    Control[] ts = vistaPrevia.Controls.Find("toolStrip1", true);
                    ToolStrip to = ts[0] as ToolStrip;
                    to.Items.RemoveAt(0);
                    f.WindowState = FormWindowState.Maximized;
                    f.ShowDialog();
                    streamParaImp.Close();
                    streamParaImp = new StreamReader("C:\\temporalSW\\ejemplo.txt");
                    pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamParaImp.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Puede Imprimir\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                File.Delete("C:\\temporalSW\\ejemplo.txt");
            }

            bAceptar_Click(null, null);
        }

        private void crearArchivoVenta()
        {
            int x = 0;
            
            try
            {
                StreamWriter sw = new StreamWriter("C:\\temporalSW\\ejemplo.txt", true, Encoding.ASCII);

                sw.WriteLine("Folio: "+tbFolio.Text);
                sw.WriteLine("Id: " + tbTelefono.Text);
                sw.WriteLine("Cliente: " + tbCliente.Text);
                sw.WriteLine("Telefono: " + tbTelefono.Text);
                sw.WriteLine("Direccion: " + tbDireccion.Text);
                sw.WriteLine("");
                sw.WriteLine("Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("==================================================================================");
                sw.WriteLine("  [Id]           [Producto]                    [P. Unitario] [Cantidad] [Subtotal]");
                sw.WriteLine("==================================================================================");
                for (x = 0; x < dgvCantidad.RowCount; x++)
                {
                    sw.WriteLine(dgvProductos[0, x].Value.ToString() + " " + " " + calculaEspacio(dgvProductos[0, x].Value.ToString(), 10) + " " + " " +
                                 dgvDescripcion[0, x].Value.ToString() + " " + " " + calculaEspacio(dgvDescripcion[0, x].Value.ToString(), 30) + " " + " " +
                                 dgvDescripcion[1, x].Value.ToString() + " " + " " + calculaEspacio(dgvDescripcion[1, x].Value.ToString(), 10) + " " + " " +
                                 dgvCantidad[0, x].Value.ToString() + " " + " " + calculaEspacio(dgvCantidad[0, x].Value.ToString(), 10) + " " + " " +
                                 dgvSubtotales[0, x].Value.ToString());
                }
                sw.WriteLine("");
                sw.WriteLine("                                                                  TOTAL = "+tbTotal.Text);
                
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se Puede Imprimir\n" + e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDescripcion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvDescripcion[1, e.RowIndex].Value != null)
            {
                string s = dgvDescripcion[1, e.RowIndex].Value.ToString();
                char[] separador = { '.' };
                string[] valores = s.Split(separador);
                if (valores.LongLength == 2 && valores[1].Length > 0)
                {
                    dgvDescripcion[1, e.RowIndex].Value = valores[0] + "." + valores[1].Substring(0, 1) + "0";
                }
                else
                {
                    dgvDescripcion[1, e.RowIndex].Value = valores[0] + "." + "00";
                }
            }
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            string s = tbTotal.Text;
            char[] separador = { '.' };
            string[] valores = s.Split(separador);
            if (valores.LongLength == 2 && valores[1].Length > 0)
            {
                tbTotal.Text = valores[0] + "." + valores[1].Substring(0, 1) + "0";
            }
            else
            {
                tbTotal.Text = valores[0] + "." + "00";
            }
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProductos[0, e.RowIndex].Value == null)
                if (dgvProductos.CurrentRow.Index < dgvProductos.RowCount - 1)
                {
                    if (dgvProductos.CurrentRow.Index < dgvDescripcion.RowCount)
                    {
                        dgvDescripcion.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                        dgvCantidad.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                        dgvSubtotales.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                    }
                    dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                    dgvProductos.Focus();
                }
        }

        public void Mensaje()
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(SplashScreen));
            t.Start();
            System.Threading.Thread.Sleep(1000);
            t.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new FormMensaje());
        }
        
    }
}
