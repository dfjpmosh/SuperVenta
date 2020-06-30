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
    public partial class DCProveedores : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private List<CProveedores> lP;
        private CProveedores proveedor;
        
        public DCProveedores()
        {
            InitializeComponent();
        }

        private void DCProveedores_Load(object sender, EventArgs e)
        {
            lP = new List<CProveedores>();
            dgvProveedores.Rows.Clear();
            leerRegistro();

            if (lP.Count > 0)
                foreach (CProveedores p in lP)
                    dgvProveedores.Rows.Add(p.idTelefono, p.nombre, p.telefono2, p.direccion);
            else
                bElimina.Enabled = false;
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

        private void bBuscar_Click(object sender, EventArgs e)
        {
            long clave = 0; 
            int i;
            bool b = false;

            if(tbProveedor.Text.Length > 0)
                clave = Convert.ToInt64(tbProveedor.Text);

            /*foreach (CProveedores p in lP)
            {
                if (clave == p.idTelefono)
                {
                    dgvProveedores.Rows.Add(p.idTelefono, p.nombre, p.telefono2, p.direccion);
                    b = true;
                    break;
                }
            }*/

            for (i = 0; i < dgvProveedores.RowCount; i++)
            {
                if (clave == Convert.ToInt64(dgvProveedores[0, i].Value.ToString()))
                {
                    dgvProveedores.CurrentCell = dgvProveedores[0, i];

                    b = true;
                    break;
                }
            }
            if (!b)
            {
                MessageBox.Show("No Se Encontro El Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dgvProveedores.Rows.Clear();
            }
        }

        private void tbProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
            int id = dgvProveedores.CurrentRow.Index;

            if (MessageBox.Show("Esta Seguro Que Desea Eliminar El Proveedor?", "Elimnar Proveedor", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                if (Elimina(dgvProveedores[0, id].Value.ToString()))
                    DCProveedores_Load(null, null);
        }

        public bool Elimina(string Id)
        {
            bool fl;
            try
            {
                OleDbConnection MyConnection = new OleDbConnection(conexion);
                string query = "DELETE FROM Proveedores WHERE IdProveedor=@Id";
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
