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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void erroresEnNuestraPajinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devolucionesYCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resistencias Resistencias = new Resistencias();
            Resistencias.ShowDialog();
        }

        private void capasitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capacitores Capacitores = new Capacitores();
            Capacitores.ShowDialog();
        }

        private void circuitosIntegradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circuitos_Integrados Circuitos_Integrados = new Circuitos_Integrados();
            Circuitos_Integrados.ShowDialog();
        }

        private void atencionAlClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transistores Transistores = new Transistores();
            Transistores.ShowDialog();
        }

        private void componenetesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_De Acerca_De = new Acerca_De();
            Acerca_De.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda Ayuda = new Ayuda();
            Ayuda.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void resistenciasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void verOfertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resistencias Resistencias = new Resistencias();
            Resistencias.ShowDialog();
        }

        private void verOfertasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Capacitores Capacitores = new Capacitores();
            Capacitores.ShowDialog();
        }

        private void verOfertasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Circuitos_Integrados Circuitos_Integrados = new Circuitos_Integrados();
            Circuitos_Integrados.ShowDialog();
        }

        private void verOfertasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Transistores Transistores = new Transistores();
            Transistores.ShowDialog();
        }
    }
}
