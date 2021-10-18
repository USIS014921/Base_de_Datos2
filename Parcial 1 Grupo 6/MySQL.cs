using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Parcial_1_Grupo_6
{
    public partial class MySQL : Form
    {
        public string cadena_conexion = "Database=agenda2;Data Source=localhost;User Id=Joan;Password=12902";
        private object myConnection;
        private object myCommand;

        public MySQL()
        {
            InitializeComponent();
        }
        private void bsalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void bentrar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void MySQL_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            txtcorreo.Enabled = false;
            txtcodigo.Enabled = false;
            lstnivel.Enabled = false;
            bguardar.Visible = false;
            bactualizar.Visible = false;
            try
            {
                string consulta = "select * from contactos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "agenda2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda2";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            {
                txtusuario.Enabled = true;
                txtclave.Enabled = true;
                lstnivel.Enabled = true;
                txtcorreo.Enabled = true;
                txtcodigo.Enabled = true;
                txtusuario.Text = "";
                txtclave.Text = "";
                txtcorreo.Text = "";
                txtcodigo.Text = "";
                lstnivel.Text = "Seleccione nivel";
                txtusuario.Focus();
                bnuevo.Visible = false;
                bguardar.Visible = true;
            }
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "INSERT INTO contactos(nombre,clave,nivel,correo,codigo) Values(?nombre,?clave,?nivel,?correo,?codigo)";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 40).Value = txtusuario.Text;
                    myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 45).Value = txtclave.Text;
                    myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 4).Value = lstnivel.Text;
                    myCommand.Parameters.Add("?correo", MySqlDbType.VarChar, 40).Value = txtcorreo.Text;
                    myCommand.Parameters.Add("?codigo", MySqlDbType.Int32, 10).Value = txtcodigo.Text;

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    string consulta = "select * from contactos";
                    
                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "agenda2");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "agenda2";
                }
                catch (MySqlException)
                {
                    MessageBox.Show("El Usuario ya existe en la base de datos", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                bnuevo.Visible = true;
                bguardar.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                txtcorreo.Enabled = false;
                txtcodigo.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo.Focus();
            }
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtcorreo.Enabled = true;
            txtcodigo.Enabled = true;
            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = "Database=agenda2;Data Source=localhost;User Id=Joan;Password=12902";
                }
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string consulta = "select * from contactos where codigo ='" + Convert.ToInt32(txtbuscar.Text) + "' ";
                MySqlCommand myCommand = new MySqlCommand(consulta, myConnection);
                myConnection.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    txtcodigo.Text = (myReader.GetString(0));
                    txtusuario.Text = (myReader.GetString(1));
                    txtclave.Text = (myReader.GetString(2));
                    lstnivel.Text = (myReader.GetString(3));
                    txtcorreo.Text = (myReader.GetString(4));
                }
                else
                {

                }
                myReader.Close();
                myConnection.Close();
            
            }
            catch (MySqlException k)
            {
                MessageBox.Show(k.ToString());
            }
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "DELETE FROM contactos Where codigo =" + txtcodigo.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
               
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("Usuario eliminado con exito", "Usuario Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);

                string consulta = "select * from contactos";
                
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda2";
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error al Eliminar el ususario ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bnuevo.Visible = true;
            bguardar.Visible = true;

            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txtcorreo.Enabled = false;
            txtcodigo.Enabled = false;

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                
                string codigo =txtcodigo.Text.ToString();
                string nombre =txtusuario.Text.ToString();
                string clave =txtclave.Text.ToString();
                string nivel =lstnivel.Text.ToString();
                string correo =txtcorreo.Text.ToString();

                string MyInsertQuery = "UPDATE contactos SET codigo = '" + codigo + "', nombre = '" + nombre + "' clave = '" + clave + "', nivel = '" + nivel + "' correo = '" + correo + "' WHERE codigo ='" + txtcodigo.Text +"'";

                MySqlCommand myCommand = new MySqlCommand(MyInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("Usuario Actializado con exito", "Actualizacon completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from contactos";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda2";
            }
            catch (System.Exception)
            {
                MessageBox.Show("El usuario no se puede actualizar ", " Actualizacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bmodificar.Visible = true;
            bactualizar.Visible = false;

            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txtcorreo.Enabled = false;
            txtcodigo.Enabled = false;

        }
    }
}