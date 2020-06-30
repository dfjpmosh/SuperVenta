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

namespace Ing_SW_B
{
    public partial class FormAltaProductos : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private List<CProveedores> lP;
        private List<CExistencias> lE;
        private List<CExistencias> lEAux;
        private CProveedores proveedor;
        private CExistencias producto;

        public FormAltaProductos()
        {
            InitializeComponent();
            
        }

        private void FormAltaProductos_Load(object sender, EventArgs e)
        {
            lP = new List<CProveedores>();
            dgvProveedor.Rows.Clear();
            leerRegistro();

            if (lP.Count > 0)
                foreach (CProveedores p in lP)
                    dgvProveedor.Rows.Add(p.idTelefono, p.nombre);
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
                    MessageBox.Show("No se Encontraron datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }

        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
        {
            int ins = dgvProveedor.CurrentRow.Index;
            string ind = dgvProveedor[0, ins].Value.ToString();
            lE = new List<CExistencias>();
            dgvProductos.Rows.Clear();
            dgvPrecio.Rows.Clear();
            dgvCantidad.Rows.Clear();
            leerRegistroExistencias(ind);

            if (lE.Count > 0)
            {
                foreach (CExistencias p in lE)
                {
                    dgvProductos.Rows.Add(p.idProducto, p.nombre, p.cantidad);
                    dgvPrecio.Rows.Add(p.precio.ToString("C2"));
                    dgvCantidad.Rows.Add("0");
                    /*char[] separador = { '.' };
                    string[] valores = Convert.ToString(p.precio).Split(separador);
                    if (valores.LongLength == 2 && valores[1].Length > 0)
                    {
                        dgvPrecio.Rows.Add(p.precio+"0");
                    }
                    else
                    {
                        dgvPrecio.Rows.Add(p.precio+".00");
                    }*/
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
                    bAgregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No Se Encontraron Productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bAgregar.Enabled = false;
                }
                reader.Close();
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            int ins = dgvProveedor.CurrentRow.Index;
            string ind = dgvProveedor[0, ins].Value.ToString();
            lE = new List<CExistencias>();
            lEAux = new List<CExistencias>();
            int i, ip=dgvProductos.CurrentRow.Index;
            bool lleno = checaCeldas();
            leerRegistroExistencias(ind);

            if (lleno)
            {
                for (i = 0; i < dgvProductos.RowCount; i++)
                {
                    producto = new CExistencias();

                    producto.cantidad = lE[ip].cantidad;

                    producto.idProducto = Convert.ToInt64(dgvProductos[0, i].Value.ToString());
                    producto.nombre = dgvProductos[1, i].Value.ToString();
                    producto.precio = Convert.ToSingle(dgvPrecio[0, i].Value.ToString().Substring(1));
                    producto.cantidad += Convert.ToInt32(dgvCantidad[0, i].Value.ToString());
                    producto.idProveedor = Convert.ToInt64(dgvProveedor[0, ins].Value.ToString());

                    lEAux.Add(producto);
                }

                /*Antes guardar en la base hay que abrirla y sacar la cantidad del prod y 
                 * sumarla con la cantidad nueva para que cuadren la existencias*/
                foreach (CExistencias ex in lEAux)
                {
                    using (OleDbConnection cn = new OleDbConnection(conexion))
                    {
                        string query = "UPDATE Existencias SET [Precio] = @precio, [Cantidad] = @cantidad WHERE IdProducto=@Id";
                        OleDbCommand cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@precio", Convert.ToString(ex.precio));
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToString(ex.cantidad));
                        cmd.Parameters.AddWithValue("@Id", Convert.ToString(ex.idProducto));

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                //MessageBox.Show("Los Productos se han dado de alta exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mensaje();
                limpiaCeldas();
            }
            else
                MessageBox.Show("Existen Celdas Vacias\n" + "Rellene Todas Celdas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        public bool checaCeldas()
        {
            int i;

            for (i = 0; i < dgvPrecio.RowCount; i++)
                if (dgvPrecio[0, i].Value == null || dgvPrecio[0, i].Value.ToString().Length == 0)
                    return false;

            for (i = 0; i < dgvCantidad.RowCount; i++)
                if (dgvCantidad[0, i].Value == null || dgvCantidad[0, i].Value.ToString().Length == 0)
                    return false;

            return true;
        }

        private void limpiaCeldas()
        {
            int i = 0;

            for (i = 0; i < dgvCantidad.RowCount; i++)
                dgvCantidad[0, i].Value = "0";
        }

        private void dgvPrecio_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i, cero=0;
            bool punto = false, error=false;
            if (dgvPrecio[0, e.RowIndex].Value == null)
                dgvPrecio[0, e.RowIndex].Value = 00.00;
            string s = dgvPrecio[0, e.RowIndex].Value.ToString();
            for(i=0; i< s.Length; i++)
            {
                if (Char.IsNumber(s.ElementAt(i)) == false)
                {
                    if (Char.IsPunctuation(s.ElementAt(i)))
                    {
                        if (Convert.ToChar(s.ElementAt(i)) != '.')
                        {
                            MessageBox.Show("La Celda\nSolo Puede Contener Valores Numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvPrecio[0, e.RowIndex].Value = cero.ToString("C2");
                            error = true;
                            break;
                        }
                        else
                        {
                            if (!punto)
                                punto = true;
                            else
                            {
                                MessageBox.Show("La Celda\nSolo Puede Contener Un Punto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dgvPrecio[0, e.RowIndex].Value = cero.ToString("C2");
                                error = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (Char.IsLetter(s.ElementAt(i)))
                        {
                            MessageBox.Show("La Celda\nSolo Puede Contener Valores Numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvPrecio[0, e.RowIndex].Value = cero.ToString("C2");
                            error = true;
                            break;
                        }
                    }
                }
            }

            char[] separador = {'.'};
            string[] valores = s.Split(separador);
            if (valores.LongLength == 2 && !error && valores[1].Length > 0)
            {
                //dgvPrecio[0, e.RowIndex].Value = valores[0] + "." + valores[1].Substring(0, 1)+"0";
                dgvPrecio[0, e.RowIndex].Value = Convert.ToSingle(dgvPrecio[0, e.RowIndex].Value.ToString()).ToString("C2");
            }
            else
            {
                if(!error)
                    dgvPrecio[0, e.RowIndex].Value = Convert.ToSingle(dgvPrecio[0, e.RowIndex].Value.ToString()).ToString("C2");
                    //dgvPrecio[0, e.RowIndex].Value = valores[0] + "." + "00";
            }

        }

        private void dgvCantidad_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvCantidad[0, e.RowIndex].Value == null)
                dgvCantidad[0, e.RowIndex].Value = 0;
            string s = dgvCantidad[0, e.RowIndex].Value.ToString();
            for (i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s.ElementAt(i)) == false)
                {
                    MessageBox.Show("La Celda\nSolo Puede Contener Valores Numericos Enteros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvCantidad[0, e.RowIndex].Value = "0";
                    break;
                }
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
