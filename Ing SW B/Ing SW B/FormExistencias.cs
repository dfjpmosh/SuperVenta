using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.Drawing.Printing;
using System.IO;

namespace Ing_SW_B
{
    public partial class FormReportes : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private List<CProveedores> lP;
        private List<CExistencias> lE;
        private CProveedores proveedor;
        private CExistencias producto;
        DateTime inicial;
        DateTime final;
        private Font Fuente;
        private StreamReader streamParaImp;

        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            lP = new List<CProveedores>();
            dgvProveedores.Rows.Clear();
            leerRegistro();
            leerRegistroPedidos();

            if (lP.Count > 0)
                foreach (CProveedores p in lP)
                    dgvProveedores.Rows.Add(p.idTelefono, p.nombre);
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
            leerRegistroExistencias(ind);

            if (lE.Count > 0)
            {
                foreach (CExistencias p in lE)
                {
                    dgvProductos.Rows.Add(p.idProducto, p.nombre, p.cantidad);
                }
            }
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
                        producto.cantidad = reader.GetInt16(3);
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

        private void bBuscarPeriodo_Click(object sender, EventArgs e)
        {
            string dia = dtpPeriodo.Value.DayOfWeek.ToString();
            int iDia = dtpPeriodo.Value.Day;
            int iMes = dtpPeriodo.Value.Month;
            int iAño = dtpPeriodo.Value.Year;
            inicial = new DateTime();
            final = new DateTime();

            if (rbDia.Checked == true)
            {
                inicial = new DateTime(iAño, iMes, iDia, 0, 0, 0);
                final = new DateTime(iAño, iMes, iDia, 23, 59, 59); ;
            }
            
            if (rbSemana.Checked == true)
            {
                inicial = mcSemana.SelectionStart;
                dia = mcSemana.SelectionEnd.ToShortDateString() + " 11:59:59 p.m.";
                final = Convert.ToDateTime(dia);
            }

            if (rbMes.Checked == true)
            {
                inicial = new DateTime(iAño, iMes, 1, 0, 0, 0);
                switch (iMes)
                {
                    case 1:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        final = new DateTime(iAño, iMes, 31, 23, 59, 59);
                        break;
                    case 3:
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        final = new DateTime(iAño, iMes, 30, 23, 59, 59);
                        break;
                    case 2:
                        final = new DateTime(iAño, iMes, 28, 23, 59, 59);
                        break;
                }
            }

            if (rbAño.Checked == true)
            {
                inicial = new DateTime(iAño, 12, 31, 23, 59, 59);
                final = new DateTime(iAño, 12, 31, 23, 59, 59); ;
            }

            /*Ya teniendo el periodo, sacar una lista de ventas que esten entre la fecha
             llenar el data y sacar el total de la venta y tal ves dar opcion de ver 
             el detalle de venta del folio seleccionado todo esto en nuevos metodos*/
            iDia = dtpPeriodo.Value.Day;
            iMes = dtpPeriodo.Value.Month;
            iAño = dtpPeriodo.Value.Year;
            inicial = new DateTime(iAño, iMes, iDia, 0, 0, 0);
            iDia = dtpPeridoFinal.Value.Day;
            iMes = dtpPeridoFinal.Value.Month;
            iAño = dtpPeridoFinal.Value.Year;
            final = new DateTime(iAño, iMes, iDia, 23, 59, 59);
            muestraVentas(inicial, final);
        }

        public void muestraVentas(DateTime inicial, DateTime final)
        {
            dgvVentas.Rows.Clear();
            int folio;
            float total, totalventa=0;
            string cadfecha;
            DateTime fecha;
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
                        folio = reader.GetInt32(0);
                        total = reader.GetFloat(3);
                        cadfecha = reader.GetString(1);
                        fecha = Convert.ToDateTime(cadfecha);
                        if (inicial.CompareTo(fecha) <= 0 && final.CompareTo(fecha) >= 0)
                        {
                            dgvVentas.Rows.Add(folio, total.ToString("C2"), fecha);
                            totalventa += total;
                        }
                        
                    }
                    tbVenta.Text = totalventa.ToString("C2");
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
        }

        private void rbSemana_CheckedChanged(object sender, EventArgs e)
        {
            dtpPeriodo.Visible = false;
            mcSemana.Visible = true;
        }

        private void rbDia_CheckedChanged(object sender, EventArgs e)
        {
            dtpPeriodo.Visible = true;
            mcSemana.Visible = false;
        }

        private void rbMes_CheckedChanged(object sender, EventArgs e)
        {
            dtpPeriodo.Visible = true;
            mcSemana.Visible = false;
        }

        private void rbAño_CheckedChanged(object sender, EventArgs e)
        {
            dtpPeriodo.Visible = true;
            mcSemana.Visible = false;
        }

        #region imprimirExistencias
        private void bImpReportes_Click(object sender, EventArgs e)
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
            int ins = dgvProveedores.CurrentRow.Index;

            try
            {
                StreamWriter sw = new StreamWriter("C:\\temporalSW\\ejemplo.txt", true, Encoding.ASCII);

                sw.WriteLine("                 LISTA DE PRODUCTOS DEL PROVEEDOR");
                sw.WriteLine("");
                sw.WriteLine("Id: " + lP[ins].idTelefono + "                    " + "Nombre: " + lP[ins].nombre);
                sw.WriteLine("Tel1: " + lP[ins].idTelefono + "                  " + "Tel2: " + lP[ins].telefono2);
                sw.WriteLine("Direccion: " + lP[ins].direccion);
                sw.WriteLine("");
                sw.WriteLine("Fecha: " + DateTime.Now.ToLongDateString());
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("========================================================================");
                sw.WriteLine("   [Id]   " + "                     [Nombre]               " + "[Existencia]");
                sw.WriteLine("========================================================================");
                foreach (CExistencias p in lE)
                {
                    sw.WriteLine(" " + p.idProducto + " " + " " + calculaEspacio(p.idProducto.ToString(), 15) + " " + " " +
                                 p.nombre + " " + " " + calculaEspacio(p.nombre, 40) + " " + " " +
                                 p.cantidad);
                    x++;
                }

                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se Puede Imprimir\n" + e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

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

        #region imprimirVentas
        private void bImpVentas_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();

            crearArchivoVentas();

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

        private void crearArchivoVentas()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\temporalSW\\ejemplo.txt", true, Encoding.ASCII);

                sw.WriteLine("                    VENTAS POR PERIODO");
                sw.WriteLine("");
                sw.WriteLine("Fecha: " + DateTime.Now.ToLongDateString());
                sw.WriteLine("");
                sw.WriteLine("Periodo: " + inicial.ToShortDateString() +" a " + final.ToShortDateString());
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("========================================================================");
                sw.WriteLine("[Folio]   " + "          [Total]                   " + "[Fecha]");
                sw.WriteLine("========================================================================");
                sw.WriteLine("");
                
                sw.WriteLine("Venta Total del Periodo =   " + cargaVentas(inicial, final, sw).ToString("C2"));

                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se Puede Imprimir\n" + e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public float cargaVentas(DateTime inicial, DateTime final, StreamWriter sw)
        {
            int folio;
            float total, totalventa = 0;
            string cadfecha;
            DateTime fecha;
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
                        folio = reader.GetInt32(0);
                        total = reader.GetFloat(3);
                        cadfecha = reader.GetString(1);
                        fecha = Convert.ToDateTime(cadfecha);
                        if (inicial.CompareTo(fecha) <= 0 && final.CompareTo(fecha) >= 0)
                        {
                            sw.WriteLine(" " + folio + " " + " " + calculaEspacio(folio.ToString(), 15) + " " + " " +
                                 total.ToString("C2") + " " + " " + calculaEspacio(total.ToString(), 15) + " " + " " +
                                 fecha.ToLongDateString());
                            totalventa += total;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            sw.WriteLine("");
            sw.WriteLine("");
            return totalventa;
        }
        #endregion

        #region detalleVenta
        private void bDetalleVenta_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();
            int idVenta=0, ind;
            
            if (dgvVentas.RowCount > 0)
            {
                ind = dgvVentas.CurrentRow.Index;
                idVenta = Convert.ToInt32(dgvVentas[0, ind].Value.ToString());
                                
                crearArchivoDetalleVenta(ind, idVenta);

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
                        //to.Items.RemoveAt(0);
                        f.WindowState = FormWindowState.Maximized;
                        f.ShowDialog();
                        streamParaImp.Close();

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
            else
                MessageBox.Show("Seleccione una Venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void crearArchivoDetalleVenta(int ind, int idVenta)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\temporalSW\\ejemplo.txt", true, Encoding.ASCII);

                sw.WriteLine("                    DETALLE DE VENTA");
                sw.WriteLine("");
                sw.WriteLine("Fecha: " + DateTime.Now.ToLongDateString());
                sw.WriteLine("");
                sw.WriteLine("Folio Venta: " + dgvVentas[0,ind].Value.ToString());
                sw.WriteLine("Fecha: " + dgvVentas[2, ind].Value.ToString());
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("========================================================================");
                sw.WriteLine("[Id]   " + "          [Producto]           [Cantidad][P. Unitario][Subtotal]");
                sw.WriteLine("========================================================================");
                sw.WriteLine("");

                cargaDetalleVenta(idVenta, sw);
                sw.WriteLine("Total = " + dgvVentas[1, ind].Value.ToString());
                
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se Puede Imprimir\n" + e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargaDetalleVenta(int folio, StreamWriter sw)
        {
            string nombre;

            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT * FROM DetalleVenta";
                OleDbCommand cmd = new OleDbCommand(query, cn);

                cn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetInt32(0) == folio)
                        {
                            nombre = buscaProducto(reader.GetString(1));
                            sw.WriteLine(" " + reader.GetString(1) + " " + " " + calculaEspacio(reader.GetString(1), 11) + " " + " " +
                                 nombre + " " + " " + calculaEspacio(nombre, 22) + " " + " " +
                                 reader.GetInt16(2) + " " + " " + calculaEspacio(reader.GetInt16(2).ToString(), 4) + " " + " " +
                                 reader.GetFloat(3).ToString("C2") + " " + " " + calculaEspacio(reader.GetFloat(3).ToString(), 6) + " " + " " +
                                 reader.GetFloat(4).ToString("C2"));
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            sw.WriteLine("");
            sw.WriteLine("");
        }

        private string buscaProducto(string id)
        {
            string nombre = "";
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT * FROM Existencias WHERE IdProducto=@Id";
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
                        nombre = producto.nombre = reader.GetString(1);
                        producto.precio = reader.GetFloat(2);
                        producto.cantidad = reader.GetInt16(3);
                        producto.idProveedor = Convert.ToInt64(reader.GetString(4));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }

            return nombre;
        }
        #endregion

        private void leerRegistroPedidos()
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT * FROM Pedidos";
                OleDbCommand cmd = new OleDbCommand(query, cn);

                cn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvPedidos.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
        }

    }
}
