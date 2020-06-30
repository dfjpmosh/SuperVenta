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
    public partial class DClientes : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private List<CClientes> lC;
        private CClientes cliente;

        public DClientes()
        {
            InitializeComponent();
        }

        private void DClientes_Load(object sender, EventArgs e)
        {
            lC = new List<CClientes>();
            dgvClientes.Rows.Clear();
            leerRegistro();

            if (lC.Count > 0)
                foreach (CClientes c in lC)
                    dgvClientes.Rows.Add(c.idTelefono, c.nombre, c.apellido, c.direccion);
        }

        private void leerRegistro()
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT IdTelefono, Nombre, Apellido, Direccion FROM Cliente";
                OleDbCommand cmd = new OleDbCommand(query, cn);

                cn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cliente = new CClientes();
                        cliente.idTelefono = Convert.ToInt64(reader.GetString(0));
                        cliente.nombre = reader.GetString(1);
                        cliente.apellido = reader.GetString(2);
                        cliente.direccion = reader.GetString(3);

                        lC.Add(cliente);
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

            if(tbCliente.Text.Length > 0)
                clave = Convert.ToInt64(tbCliente.Text);

            /*foreach (CClientes c in lC)
            {
                if (clave == c.idTelefono)
                {
                    dgvClientes.Rows.Add(c.idTelefono, c.nombre, c.apellido, c.direccion);
                    b = true;
                    break;
                }
            }*/
            for (i = 0; i < dgvClientes.RowCount; i++)
            {
                if (clave == Convert.ToInt64(dgvClientes[0,i].Value.ToString()))
                {
                    dgvClientes.CurrentCell = dgvClientes[0, i];
                    
                    b = true;
                    break;
                }
            }
            if (!b)
            {
                MessageBox.Show("No se Encontro el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dgvClientes.Rows.Clear();
            }
        }

        private void tbCliente_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
