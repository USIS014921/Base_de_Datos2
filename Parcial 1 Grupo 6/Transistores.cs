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
    public partial class Transistores : Form
    {
        public Transistores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado", "Compra de Transistor de pequeña señal NPN", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado", "Compra de Transistor de pequeña señal Bipolar NPN", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado", "Compra de Transistor de Potenia NPN", MessageBoxButtons.OK);
        }
    }
}
