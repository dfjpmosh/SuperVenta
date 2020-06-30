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
    public partial class FormPedidos : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private List<CProveedores> lP;
        private List<CExistencias> lE;
        private CProveedores proveedor;
        private CExistencias producto;
        private Font Fuente;
        private StreamReader streamParaImp;
        
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            lP = new List<CProveedores>();
            dgvProveedores.Rows.Clear();
            leerRegistro();

            if (lP.Count > 0)
            {
                foreach (CProveedores p in lP)
                    dgvProveedores.Rows.Add(p.idTelefono, p.nombre);
            }
            else
            {
                bAceptar.Enabled = false;
                bNProducto.Enabled = false;
                bAProducto.Enabled = false;
            }
        }

        private void leerRegistro()
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT IdProveedor, Nombre, Telefono, Direccion FROM Proveedores";
                OleDbCommand cmd = new OleDbCommand(query, cn);

                cn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        proveedor = new CProveedores();
                        proveedor.idTelefono = Convert.ToInt64(reader.GetString(0));
                        proveedor.nombre = reader.GetString(1);
                        proveedor.telefono2 = Convert.ToInt64(reader.GetString(2));
                        proveedor.direccion = reader.GetString(3);

                        lP.Add(proveedor);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            int ins = dgvProveedores.CurrentRow.Index;
            string ind = dgvProveedores[0, ins].Value.ToString();
            lE = new List<CExistencias>();
            dgvProductos.Rows.Clear();
            dgvCP.Rows.Clear();
            leerRegistroExistencias(ind);

            if (lE.Count > 0)
            {
                foreach (CExistencias p in lE)
                {
                    dgvProductos.Rows.Add(p.idProducto, p.nombre, p.cantidad);
                    dgvCP.Rows.Add("0");
                }
                bAceptar.Enabled = true;
            }
            else
                bAceptar.Enabled = false;
        }

        private void leerRegistroExistencias(string id)
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT IdProducto, Nombre, Precio, Cantidad, IdProveedor FROM Existencias WHERE IdProveedor=@Id";
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
                        producto.cantidad = reader.GetInt16(3);// .GetInt32(3);
                        producto.idProveedor = Convert.ToInt64(reader.GetString(4));

                        lE.Add(producto);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
        }

        private void bNProveedor_Click(object sender, EventArgs e)
        {
            FormAltaPP fnp = new FormAltaPP();

            if (fnp.ShowDialog() == DialogResult.OK)
                FormPedidos_Load(sender, e);
        }

        private void bNProducto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto fnp = new FormNuevoProducto();
            int ins = dgvProveedores.CurrentRow.Index;
            string idP= dgvProveedores[0, ins].Value.ToString();

            lP.Clear();
            leerRegistro();

            foreach (CProveedores p in lP)
                if (p.idTelefono == Convert.ToInt64(idP))//Aqui seria mejor checar entre id's, pero se necesita agregar al data para poder campturarlo
                {
                    fnp.tbIdProveedor.Text = Convert.ToString(p.idTelefono);
                    break;
                }
            fnp.ShowDialog();
            FormPedidos_Load(null, null);
        }

        private void bAProducto_Click(object sender, EventArgs e)
        {
            FormAltaProductos fap = new FormAltaProductos();

            fap.ShowDialog();
            FormPedidos_Load(null, null);
        }

        private void dgvCP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvCP[0, e.RowIndex].Value == null)
                dgvCP[0, e.RowIndex].Value = 0;
            string s = dgvCP[0, e.RowIndex].Value.ToString();
            for (i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s.ElementAt(i)) == false)
                {
                    MessageBox.Show("La Celda\nSolo Puede Contener Valores Numericos Enteros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvCP[0, e.RowIndex].Value = "0";
                    break;
                }
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
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
                    RegistraPedido();
                }
                finally
                {
                    streamParaImp.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Puede Imprimir\n"+ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                File.Delete("C:\\temporalSW\\ejemplo.txt");
            }
        }

        private void crearArchivo()
        {
            int x=0;
            int ins = dgvProveedores.CurrentRow.Index;
            
            try
            {
                StreamWriter sw = new StreamWriter("C:\\temporalSW\\ejemplo.txt", true, Encoding.ASCII);

                sw.WriteLine("              LISTA DE PRODUCTOS A PEDIR DEL PROVEEDOR");
                sw.WriteLine("");
                sw.WriteLine("Id: " + lP[ins].idTelefono + "                    " + "Nombre: " + lP[ins].nombre);
                sw.WriteLine("Tel1: " + lP[ins].idTelefono + "                  " + "Tel2: " + lP[ins].telefono2);
                sw.WriteLine("Direccion: " + lP[ins].direccion);
                sw.WriteLine("");
                sw.WriteLine("Fecha: "+ DateTime.Now.ToLongDateString());
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("========================================================================");
                sw.WriteLine("   [Id]   "+"                     [Nombre]               "+"[Cantidad a Pedir]");
                sw.WriteLine("========================================================================");
                foreach (CExistencias p in lE)
                {
                    sw.WriteLine(" "+p.idProducto + " " + " " + calculaEspacio(p.idProducto.ToString(), 15) + " " + " " +
                                 p.nombre + " " + " " + calculaEspacio(p.nombre, 40) + " " + " " +
                                 dgvCP[0, x].Value.ToString());
                    x++;
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
                ev.Graphics.DrawString(linea, Fuente, Brushes.Black,  margenIzquierda, yPos, new StringFormat());
                count++;
            }

            if (linea != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void RegistraPedido()
        {
            string proveedor = dgvProveedores[0, dgvProveedores.CurrentRow.Index].Value.ToString();
            for(int i=0; i<dgvCP.RowCount; i++)
                if (Convert.ToInt32(dgvCP[0, i].Value.ToString()) > 0)
                {
                    try
                    {
                        OleDbConnection cnn = new OleDbConnection(conexion);
                        const string insert = @"insert into Pedidos(IdProveedor, IdProducto, Cantidad, FechaPedido)values (@iventa, @dventa, @tventa, @fventa)";
                        OleDbCommand cmd = new OleDbCommand(insert, cnn);
                        cmd.Parameters.AddWithValue("@iventa", proveedor);
                        cmd.Parameters.AddWithValue("@dventa", dgvProductos[0, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@tventa", dgvCP[0, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@fventa", DateTime.Today.ToString("d") + " " + DateTime.Now.ToLongTimeString());
                        cnn.Open();
                        int exe = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    catch (OleDbException)
                    {
                        MessageBox.Show("Ocurrió un error al insertar: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }
    }
}
