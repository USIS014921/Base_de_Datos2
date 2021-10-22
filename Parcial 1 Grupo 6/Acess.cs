using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Parcial_1_Grupo_6
{
    public partial class Acess : Form
    {
        public OleDbConnection miconexion;
        public String usuario_modificar;
        private object SistemaDataSet;
        public Acess()
        {
            miconexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema\Sistema.accdb");
           
            InitializeComponent();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MoveLast();
        }

        private void Acess_Load(object sender, EventArgs e)
        {
            this.sistemaTableAdapter.Fill(this.sistemaDataSet4.Sistema);
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MoveFirst();
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MoveNext();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione el Nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;
                eliminar.CommandText = "DELETE FROM Sistema WHERE usuario = '" + txtusuario.Text.ToString() + "'";
                eliminar.ExecuteNonQuery();

                miconexion.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;
                guardar.CommandText = "INSERT INTO Sistema ([usuario], [contraseña],[nivel]) Values('" + txtusuario.Text.ToString() + "','" + txtclave.Text.ToString() + "','" + lstnivel.Text.ToString() + "')";
                guardar.ExecuteNonQuery();
                miconexion.Close();
                bnuevo.Visible = true;
                bguardar.Visible = false;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo.Focus();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;
            usuario_modificar = txtusuario.Text.ToString();
        }

        private void bentrar_Click(object sender, EventArgs e)
        {
            try
            { 
                OleDbConnection conexion_access = new OleDbConnection();

                conexion_access.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema\Sistema.accdb";

                conexion_access.Open();

                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM Sistema", conexion_access);

                DataSet resultado = new DataSet();
                consulta.Fill(resultado);
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((txtusuario.Text == registro["usuario"].ToString()) && (txtclave.Text == registro["contraseña"].ToString()))
                    {
                        Inicio form1 = new Inicio();
                        form1.Show();
                        this.Hide();
                    }
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
            }

            miconexion.Close();
        }

        private void bentrar_sqlserver_Click(object sender, EventArgs e)
        {

        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;
                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;

                actualizar.CommandText = "UPDATE Sistema SET usuario = '" + nom + "', contraseña = '" + cla + "',nivel = '" + niv + "' WHERE usuario = '" + usuario_modificar + "'";

                actualizar.ExecuteNonQuery();
                miconexion.Close();
                bmodificar.Visible = true;
                bactualizar.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                
                MessageBox.Show("Usuario actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

