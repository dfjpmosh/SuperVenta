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
    public partial class FormAltaCliente : Form
    {
        //private string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\DFJPMOSH\\Documents\\Visual Studio 2010\\Projects\\Ing SW B\\BD Sistema de Ventas Minisuper.accdb";
        private string conexion = Properties.Settings.Default.CadenaConexion;
        private bool cerrar;

        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private bool altaCliente()
        {
            if (buscarRegistro(tbTelefono.Text) == false)
            {
                try
                {
                    OleDbConnection cnn = new OleDbConnection(conexion);
                    const string insert = @"insert into Cliente(IdTelefono, Nombre, Apellido, Direccion)values (@iuser, @nuser, @auser, @duser)";
                    OleDbCommand cmd = new OleDbCommand(insert, cnn);
                    cmd.Parameters.AddWithValue("@iuser", tbTelefono.Text);
                    cmd.Parameters.AddWithValue("@nuser", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@auser", tbApellido.Text);
                    cmd.Parameters.AddWithValue("@duser", tbDireccion.Text);
                    cnn.Open();
                    int exe = cmd.ExecuteNonQuery();
                    cnn.Close();
                    Mensaje();
                    //MessageBox.Show("El Cliente se ha Dado de Alta Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Ocurrió un error al insertar: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FormAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!cerrar)
                if ((tbTelefono.TextLength < 7 || (tbTelefono.TextLength > 7 && tbTelefono.TextLength < 10) || tbTelefono.TextLength > 10)
                    || (tbTelefono.TextLength > 0 && tbTelefono.Text.Substring(0, 1) == "0"))
                {
                    MessageBox.Show("El Numero Telefonico no es valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (tbApellido.TextLength < 3)
                        {
                            MessageBox.Show("Ingrese un Apellido Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;
                        }
                        else
                        {
                            if (tbDireccion.TextLength < 3)
                            {
                                MessageBox.Show("Ingrese una Direccion Valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                e.Cancel = true;
                            }
                            else
                            {
                                if (!altaCliente())
                                    e.Cancel = true;
                                else
                                {
                                    tbTelefono.Text = "";
                                    tbNombre.Text = "";
                                    tbApellido.Text = "";
                                    tbDireccion.Text = "";
                                    tbTelefono.Focus();
                                    e.Cancel = true;
                                }
                            }
                        }
                    }
                }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            cerrar = true;
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                    MessageBox.Show("Introducir solo numeros\nEl Telefono Debe Ser Valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
