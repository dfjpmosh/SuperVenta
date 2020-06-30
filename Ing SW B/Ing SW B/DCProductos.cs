using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ing_SW_B
{
    public partial class DCProductos : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private List<CExistencias> lP;
        private CExistencias producto;

        public DCProductos()
        {
            InitializeComponent();
        }

        private void DCProductos_Load(object sender, EventArgs e)
        {
            lP = new List<CExistencias>();
            dgvProductos.Rows.Clear();
            leerRegistro();

            if (lP.Count > 0)
                foreach (CExistencias p in lP)
                    dgvProductos.Rows.Add(p.idProducto, p.nombre, p.precio, p.cantidad, p.idProveedor);
            else
                bElimina.Enabled = false;
        }

        private void leerRegistro()
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT * FROM Existencias";
                OleDbCommand cmd = new OleDbCommand(query, cn);

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

                        lP.Add(producto);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            long clave = 0;
            int i;
            bool b = false;

            if (tbProducto.Text.Length > 0)
                clave = Convert.ToInt64(tbProducto.Text);

            for (i = 0; i < dgvProductos.RowCount; i++)
            {
                if (clave == Convert.ToInt64(dgvProductos[0, i].Value.ToString()))
                {
                    dgvProductos.CurrentCell = dgvProductos[0, i];

                    b = true;
                    break;
                }
            }
            if (!b)
            {
                MessageBox.Show("No Se Encontro El Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dgvProveedores.Rows.Clear();
            }
        }

        private void tbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                bBuscar_Click(null, null);
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                    e.Handled = false;
                else
                {
                    if (!Char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo Debe Contener Numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void bElimina_Click(object sender, EventArgs e)
        {
            int id = dgvProductos.CurrentRow.Index;

            if (MessageBox.Show("Esta Seguro Que Desea Eliminar El Producto?", "Elimnar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (Elimina(dgvProductos[0, id].Value.ToString()))
                    DCProductos_Load(null, null);
        }

        public bool Elimina(string Id)
        {
            bool fl;
            try
            {
                OleDbConnection MyConnection = new OleDbConnection(conexion);
                string query = "DELETE FROM Existencias WHERE IdProducto=@Id";
                OleDbCommand cmd = new OleDbCommand(query, MyConnection);
                cmd.Parameters.AddWithValue("Id", Id);
                OleDbDataAdapter delete = new OleDbDataAdapter();
                MyConnection.Open();
                delete.DeleteCommand = cmd;
                delete.DeleteCommand.ExecuteNonQuery();
                MyConnection.Close();
                fl = true;
            }
            catch { fl = false; }
            return fl;
        }

    }
}
