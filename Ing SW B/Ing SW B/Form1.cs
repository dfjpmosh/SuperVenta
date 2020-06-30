using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.OleDb;
using System.Globalization;

namespace Ing_SW_B
{
    public partial class FormPrincipal : Form
    {
        /*
         * Cadena de Conexion que se utilizara para manipular la base de Datos
         */
        private string conexion = Properties.Settings.Default.CadenaConexion;

        /*
         * Constructor de clase FormPrincipal
         * Es el primer metodo que se ejecuta, antes de cargar la venta
         * del menu principal, crea y destruye la simulación del cargador
         * de la aplicación
         */
        public FormPrincipal()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(12000);
            t.Abort();
            InitializeComponent();
        }

        /*
         * Este metodo crea un direcctorio en C:
         * con que se trabajara mientras la aplicación esta en ejecución
         */
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("C:\\temporalSW");
        }

        /*
         * Este metodo ejecuta la simulacion del cargador de la aplicación
         */
        public void SplashScreen()
        {
            Application.Run(new FormPreload());
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el botón Venta
         * Crea y muestra la venta de una nueva venta
         */
        private void bVenta_Click(object sender, EventArgs e)
        {
            FormVenta fv = new FormVenta();

            fv.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el botón Pedido
         * Crea y muestra la ventana para hacer un pedido al Proveedor
         */
        private void bPedido_Click(object sender, EventArgs e)
        {
            FormPedidos fp = new FormPedidos();

            fp.ShowDialog();
        }

        /*
         * Este metodos se ejecuto cuando el usuario da clic en el botón Reportes
         * Creo y muestra la ventana de Reportes donde se muestran las ventas
         * de determinado periodo y las existencias
         */
        private void bReportes_Click(object sender, EventArgs e)
        {
            FormReportes fr = new FormReportes();

            fr.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Consulta+Clientes
         * Crea y muestra la interfaz donde se muestran los clientes
         */
        private void mClientes_Click(object sender, EventArgs e)
        {
            DClientes dc = new DClientes();

            dc.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Consulta+Proveedores
         * Crea y muestra la interfaz donde se muestran los porveedores
         */
        private void mProveedores_Click(object sender, EventArgs e)
        {
            DCProveedores dcp = new DCProveedores();

            dcp.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Alta+Clientes
         * Crea y muestra la interfaz donde se ingresaran los datos de un nuevo cliente
         */
        private void mACliente_Click(object sender, EventArgs e)
        {
            FormAltaCliente fac = new FormAltaCliente();

            fac.tbTelefono.Enabled = true;
            fac.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Alta+Proveedor
         * Crea y muestra la interfaz donde se ingresaran los datos de un nuevo Proveedor
         */
        private void mAProveedor_Click(object sender, EventArgs e)
        {
            FormAltaPP fap = new FormAltaPP();

            fap.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Consulta+Productos
         * Crea y muestra la interfaz donde se muestran los productos
         */
        private void mProductos_Click(object sender, EventArgs e)
        {
            DCProductos dcp = new DCProductos();

            dcp.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Baja+Clientes
         */
        private void mBCliente_Click(object sender, EventArgs e)
        {
            FormBajaCliente fbc = new FormBajaCliente();

            fbc.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Baja+Proveedor
         */
        private void mBProveedor_Click(object sender, EventArgs e)
        {
            DCProveedores dcp = new DCProveedores();
            dcp.bElimina.Visible = true;
            dcp.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando el usuario da clic en el menu Baja+Proveedor
         */
        private void mBProducto_Click(object sender, EventArgs e)
        {
            DCProductos dcp = new DCProductos();
            dcp.bElimina.Visible = true;
            dcp.ShowDialog();
        }

        private void mPClientes_Click(object sender, EventArgs e)
        {
            FormVenta fv = new FormVenta();

            fv.tbTelefono.Enabled = true;
            fv.bBuscarCli.Enabled = true;
            fv.tbTelefono.TabIndex = 0;

            fv.bImpRegVenta.Visible = false;
            fv.bVCaja.Visible = false;
            fv.bVDomicilio.Visible = false;
            fv.bVPendiente.Visible = false;
            fv.bCancelar.Visible = false;
            fv.bAceptar.Visible = false;
            fv.bImpPedido.Visible = true;
            fv.lFolio.Visible = false;
            fv.tbFolio.Visible = false;
            fv.tbCliente.Text = "";

            fv.Text = "Tomar Pedido de Cliente";
            fv.ShowDialog();
        }

        /*
         * Este metodo se ejecuta cuando se esta cerrando la aplicacion
         * elimina la carpeta creada al inicio de la aplicacion
         */
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.Directory.Delete("C:\\temporalSW");
        }

        /*
         * Este metodo se encarga de generar los dialgos
         * y respaldar la base de datos con la que se esta trabajando
         */
        private void menuRespaldar_Click(object sender, EventArgs e)
        {
            string miConexion;
            miConexion = conexion.Substring(conexion.LastIndexOf("\\") + 1);
            miConexion = miConexion.Substring(0, miConexion.Length - 1);
            
            dRespaldar.Filter = "ficheros .accdb (*.accdb) | *.accdb";

            if (dRespaldar.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dRespaldar.FileName))
                    MessageBox.Show("No Se Puedo Sobreescribir un respaldo");
                else
                {
                    File.Copy(miConexion, dRespaldar.FileName);
                    MessageBox.Show("El Respaldo Se Ha Realizado Exitosamente");
                }
            }
        }

        /*
         * Este metodo se encarga de recuperar y cargar una base de datos
         * antes respaldada por el usuario
         */
        private void menuImportar_Click(object sender, EventArgs e)
        {
            dImportar.Filter = "ficheros .accdb (*.accdb) | *.accdb";

            if (dImportar.ShowDialog() == DialogResult.OK)
            {
                #region Existencias
                try
                {
                    OleDbConnection MyConnection = new OleDbConnection(conexion);
                    string query = "DELETE FROM Existencias";
                    OleDbCommand cmd = new OleDbCommand(query, MyConnection);
                    OleDbDataAdapter delete = new OleDbDataAdapter();
                    MyConnection.Open();
                    delete.DeleteCommand = cmd;
                    delete.DeleteCommand.ExecuteNonQuery();
                    MyConnection.Close();
                }
                catch { MessageBox.Show("No se Puede"); }

                using (OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= "+dImportar.FileName))
                {
                    string query = "SELECT * FROM Existencias";
                    OleDbCommand cmd = new OleDbCommand(query, cn);
                    
                    cn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            OleDbConnection cnn = new OleDbConnection(conexion);
                            const string insert = @"insert into Existencias(IdProducto, Nombre, Precio, Cantidad, IdProveedor)values (@iprod, @nprod, @pprod, @cprod, @iprov)";
                            OleDbCommand cmd2 = new OleDbCommand(insert, cnn);
                            cmd2.Parameters.AddWithValue("@iprod", reader.GetString(0));
                            cmd2.Parameters.AddWithValue("@nprod", reader.GetString(1));
                            cmd2.Parameters.AddWithValue("@pprod", reader.GetFloat(2));
                            cmd2.Parameters.AddWithValue("@cprod", reader.GetInt16(3));
                            cmd2.Parameters.AddWithValue("@iprov", reader.GetString(4));
                            cnn.Open();
                            int exe = cmd2.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                    reader.Close();
                }
                #endregion 

                #region Clientes
                try
                {
                    OleDbConnection MyConnection = new OleDbConnection(conexion);
                    string query = "DELETE FROM Cliente";
                    OleDbCommand cmd = new OleDbCommand(query, MyConnection);
                    OleDbDataAdapter delete = new OleDbDataAdapter();
                    MyConnection.Open();
                    delete.DeleteCommand = cmd;
                    delete.DeleteCommand.ExecuteNonQuery();
                    MyConnection.Close();
                }
                catch { MessageBox.Show("No se Puede"); }

                using (OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + dImportar.FileName))
                {
                    string query = "SELECT * FROM Cliente";
                    OleDbCommand cmd = new OleDbCommand(query, cn);

                    cn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            OleDbConnection cnn = new OleDbConnection(conexion);
                            const string insert = @"insert into Cliente(IdTelefono, Nombre, Apellido, Direccion, Cuenta)values (@iprod, @nprod, @pprod, @cprod, @iprov)";
                            OleDbCommand cmd2 = new OleDbCommand(insert, cnn);
                            cmd2.Parameters.AddWithValue("@iprod", reader.GetString(0));
                            cmd2.Parameters.AddWithValue("@nprod", reader.GetString(1));
                            cmd2.Parameters.AddWithValue("@pprod", reader.GetString(2));
                            cmd2.Parameters.AddWithValue("@cprod", reader.GetString(3));
                            cmd2.Parameters.AddWithValue("@iprov", "0");
                            cnn.Open();
                            int exe = cmd2.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                    reader.Close();
                }
                #endregion 

                #region Proveedores
                try
                {
                    OleDbConnection MyConnection = new OleDbConnection(conexion);
                    string query = "DELETE FROM Proveedores";
                    OleDbCommand cmd = new OleDbCommand(query, MyConnection);
                    OleDbDataAdapter delete = new OleDbDataAdapter();
                    MyConnection.Open();
                    delete.DeleteCommand = cmd;
                    delete.DeleteCommand.ExecuteNonQuery();
                    MyConnection.Close();
                }
                catch { MessageBox.Show("No se Puede"); }

                using (OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + dImportar.FileName))
                {
                    string query = "SELECT * FROM Proveedores";
                    OleDbCommand cmd = new OleDbCommand(query, cn);

                    cn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            OleDbConnection cnn = new OleDbConnection(conexion);
                            const string insert = @"insert into Proveedores(IdProveedor, Nombre, Telefono, Direccion)values (@iprod, @nprod, @pprod, @cprod)";
                            OleDbCommand cmd2 = new OleDbCommand(insert, cnn);
                            cmd2.Parameters.AddWithValue("@iprod", reader.GetString(0));
                            cmd2.Parameters.AddWithValue("@nprod", reader.GetString(1));
                            cmd2.Parameters.AddWithValue("@pprod", reader.GetString(2));
                            cmd2.Parameters.AddWithValue("@cprod", reader.GetString(3));
                            cnn.Open();
                            int exe = cmd2.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                    reader.Close();
                }
                #endregion 

                #region Ventas
                try
                {
                    OleDbConnection MyConnection = new OleDbConnection(conexion);
                    string query = "DELETE FROM Ventas";
                    OleDbCommand cmd = new OleDbCommand(query, MyConnection);
                    OleDbDataAdapter delete = new OleDbDataAdapter();
                    MyConnection.Open();
                    delete.DeleteCommand = cmd;
                    delete.DeleteCommand.ExecuteNonQuery();
                    MyConnection.Close();
                }
                catch { MessageBox.Show("No se Puede"); }

                using (OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + dImportar.FileName))
                {
                    string query = "SELECT * FROM Ventas";
                    OleDbCommand cmd = new OleDbCommand(query, cn);

                    cn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            OleDbConnection cnn = new OleDbConnection(conexion);
                            const string insert = @"insert into Ventas(Folio, Fecha, DetalleVenta, Total)values (@iprod, @nprod, @pprod, @cprod)";
                            OleDbCommand cmd2 = new OleDbCommand(insert, cnn);
                            cmd2.Parameters.AddWithValue("@iprod", reader.GetInt32(0));
                            cmd2.Parameters.AddWithValue("@nprod", reader.GetString(1));
                            cmd2.Parameters.AddWithValue("@pprod", reader.GetInt32(2));
                            cmd2.Parameters.AddWithValue("@cprod", reader.GetFloat(3));
                            cnn.Open();
                            int exe = cmd2.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                    reader.Close();
                }
                #endregion 

                #region DetalleVenta
                try
                {
                    OleDbConnection MyConnection = new OleDbConnection(conexion);
                    string query = "DELETE FROM DetalleVenta";
                    OleDbCommand cmd = new OleDbCommand(query, MyConnection);
                    OleDbDataAdapter delete = new OleDbDataAdapter();
                    MyConnection.Open();
                    delete.DeleteCommand = cmd;
                    delete.DeleteCommand.ExecuteNonQuery();
                    MyConnection.Close();
                }
                catch { MessageBox.Show("No se Puede"); }

                using (OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + dImportar.FileName))
                {
                    string query = "SELECT * FROM DetalleVenta";
                    OleDbCommand cmd = new OleDbCommand(query, cn);

                    cn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            OleDbConnection cnn = new OleDbConnection(conexion);
                            const string insert = @"insert into DetalleVenta(Folio, IdProducto, Cantidad, PrecioUnitario, Subtotal)values (@iprod, @nprod, @pprod, @cprod, @iprov)";
                            OleDbCommand cmd2 = new OleDbCommand(insert, cnn);
                            cmd2.Parameters.AddWithValue("@iprod", reader.GetInt32(0));
                            cmd2.Parameters.AddWithValue("@nprod", reader.GetString(1));
                            cmd2.Parameters.AddWithValue("@pprod", reader.GetInt16(2));
                            cmd2.Parameters.AddWithValue("@cprod", reader.GetFloat(3));
                            cmd2.Parameters.AddWithValue("@iprov", reader.GetFloat(4));
                            cnn.Open();
                            int exe = cmd2.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                    reader.Close();
                }
                #endregion 

                MessageBox.Show("La Importacion Se Ha Realizado Exitosamente");
            }

            
        }
    }
}
