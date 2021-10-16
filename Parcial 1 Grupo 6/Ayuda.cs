using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Grupo_6
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si uno o varios componentes no funcionan de manera correcta se puede comunicar con nosotros para reponerlos.", "Reembolso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si tiene alguan inquietud, duda o pregunta no dude en hacernoslo sabes comunicanse con nosotros ya que estamos disponibles siempre para usted.","Comuniquese con nosotros",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su mensage se ha enviado de manera correcta", "mensage enviado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
