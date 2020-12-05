using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analizadorLexico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResLexico.Text = "";
            txtErroresLexico.Text = "";
            txtExpresion.Text = "";
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (txtExpresion.Text != "")
            {
                AnalizadorLexico analizador = new AnalizadorLexico();

                analizador.Analizador(txtExpresion.Text.ToString());

                txtResLexico.Text = analizador.dameListaToken();
                txtErroresLexico.Text = analizador.dameListaErrores();
                mostrarSintactico(analizador.dameListaSintactico(), analizador.dameSalida());
            } else {
                MessageBox.Show("El cuadro de texto está vacío");
            }
        }

        private void mostrarSintactico(List<String> lista, List<String> salida)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                dgvSintactico.Rows.Add(lista[i], salida[i]);
            }
        }

        private void txtExpresion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
