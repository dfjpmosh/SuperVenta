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
    public partial class FormNuevoProducto : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private bool cerrar;

        public FormNuevoProducto()
        {
            InitializeComponent();
        }

        private void FormNuevoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!cerrar)
                if (tbIdProducto.TextLength < 0 || (tbIdProducto.TextLength > 0 && tbIdProducto.Text.Substring(0, 1) == "0"))
                {
                    MessageBox.Show("Ingrese Id del Producto\nEl Valor Debe Ser Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                else
                {
                    if (tbNombre.TextLength < 3)
                    {
                        MessageBox.Show("Ingrese un Nombre Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    else
                    {
                        if (!altaProducto())
                            e.Cancel = true;
                        else
                            //if (MessageBox.Show("Desea Dar de Alta Otro Producto del Mismo Proveedor?", "Nuevo Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                tbIdProducto.Text = tbNombre.Text = "";
                                tbIdProducto.Focus();
                                e.Cancel = true;
                            }
                    }
                }
        }

        private bool altaProducto()
        {
            if (buscarRegistro(tbIdProducto.Text) == false)
            {
                try
                {
                    OleDbConnection cnn = new OleDbConnection(conexion);
                    const string insert = @"insert into Existencias(IdProducto, Nombre, Precio, Cantidad, IdProveedor)values (@iprod, @nprod, @pprod, @cprod, @iprov)";
                    OleDbCommand cmd = new OleDbCommand(insert, cnn);
                    cmd.Parameters.AddWithValue("@iprod", tbIdProducto.Text);
                    cmd.Parameters.AddWithValue("@nprod", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@pprod", "0");
                    cmd.Parameters.AddWithValue("@cprod", "0");
                    cmd.Parameters.AddWithValue("@iprov", tbIdProveedor.Text);
                    cnn.Open();
                    int exe = cmd.ExecuteNonQuery();
                    cnn.Close();
                    Mensaje();
                    //MessageBox.Show("El Producto se ha Dado de Alta Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Ocurrió un error al insertar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La Clave ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private bool buscarRegistro(string id)
        {
            using (OleDbConnection cn = new OleDbConnection(conexion))
            {
                string query = "SELECT COUNT(*) FROM Existencias WHERE IdProducto=@Id";
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

        private void bCancelar_Click(object sender, EventArgs e)
        {
            cerrar = true;
        }

        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void tbIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Introducir solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Introducir solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
