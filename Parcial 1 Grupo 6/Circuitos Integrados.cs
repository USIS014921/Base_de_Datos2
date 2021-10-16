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
    public partial class Circuitos_Integrados : Form
    {
        public Circuitos_Integrados()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado", "Compra de Circuito Integrado TTL Decodificador", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado", "Compra de Circuito Integrado Lineal Temporisador", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado", "Compra de Circuito Integrado Controlador de Motores", MessageBoxButtons.OK);
        }
    }
}
