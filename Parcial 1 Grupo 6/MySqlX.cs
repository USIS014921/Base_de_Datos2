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
using Parcial_1_Grupo_6;

namespace Segundo_Parcial
{
    public partial class MySqlX : Form
    {
        public string cadena_conexion = "Database = parcial2; DataSource = localhost; User Id = Joan; Password = 12902";
        public string usuario_modificar;
        public string usuario_eliminar;

        public MySqlX()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txttelefono.Enabled = false;
            txtcorreo.Enabled = false;
            lstedad.Enabled = false;
            lstsexo.Enabled = false;
            bactualizar.Visible = false;

            try
            {
                String consulta = "Select * from usuarios ";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "parcial2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "parcial2";

            }

            catch
            {
                MessageBox.Show("Error de Conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txttelefono.Enabled = true;
            txtcorreo.Enabled = true;
            lstedad.Enabled = true;
            lstsexo.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txttelefono.Text = "";
            txtcorreo.Text = "";
            lstedad.Text = "Selecione su genero";
            lstsexo.Text = "Indique su edad";
            txtusuario.Focus();

            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "INSERT INTO usuarios(usuario,clave,nivel,telefono,correo,sexo,edad) Values(?usuario,?clave,?nivel,?telefono,?correo,?sexo,?edad)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?usuario", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 20).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 10).Value = lstnivel.Text;
                myCommand.Parameters.Add("?telefono", MySqlDbType.Int32, 20).Value = txttelefono.Text;
                myCommand.Parameters.Add("?correo", MySqlDbType.VarChar, 40).Value = txtcorreo.Text;
                myCommand.Parameters.Add("?sexo", MySqlDbType.VarChar, 20).Value = lstsexo.Text;
                myCommand.Parameters.Add("?edad", MySqlDbType.Int32, 4).Value = lstedad.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usuarios";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "parcial2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "parcial2";
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se pudo guardar el usuario en la base de datos", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txttelefono.Enabled = false;
            txtcorreo.Enabled = false;
            lstedad.Enabled = false;
            lstsexo.Enabled = false;
            bnuevo.Focus();
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txttelefono.Enabled = true;
            txtcorreo.Enabled = true;
            lstedad.Enabled = true;
            lstsexo.Enabled = true;
            txtusuario.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;
            usuario_modificar = txtusuario.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string usu = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;
                string tel = txttelefono.Text.ToString();
                string cor = txtcorreo.Text.ToString();
                string eda = lstedad.Text;
                string sex = lstsexo.Text;

                string myInsertQuery = "UPDATE usuarios SET usuario = '" + usu + "',clave = '" + cla + "',nivel = '" + niv + "',telefono = '" + tel + "',correo = '" + cor + "',sexo = '" + sex + "',edad = '" + eda + "' WHERE usuario = '" + usuario_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("Usuario Actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usuarios";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "parcial2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "parcial2";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al Actualizar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bmodificar.Visible = true;
            bactualizar.Visible = false;

            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txttelefono.Enabled = false;
            txtcorreo.Enabled = false;
            lstedad.Enabled = false;
            lstsexo.Enabled = false;
            bmodificar.Focus();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "delete from usuarios Where idusuario = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usuarios";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "parcial2");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "parcial2";
            }
            catch
            {
                MessageBox.Show("Error al eliminar el usuario, primero realice búsqueda del usuario y después puede eliminar.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txttelefono.Enabled = false;
            txtcorreo.Enabled = false;
            lstedad.Enabled = false;
            lstsexo.Enabled = false;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txttelefono.Text = "";
            txtcorreo.Text = "";
            lstedad.Text = "Selecione su genero";
            lstsexo.Text = "Indique su edad";
            txtbuscar.Focus();
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {

        }

        private void bentrar_Click(object sender, EventArgs e)
        {

        }

        private void lstedad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bentrar_Click_1(object sender, EventArgs e)
        {

        }

        private void bentrar_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}


