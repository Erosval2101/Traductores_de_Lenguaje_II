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
            txtResultado.Text = "";
            txtErrores.Text = "";
            txtExpresion.Text = "";
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (txtExpresion.Text != "")
            {
                AnalizadorLexico analizador = new AnalizadorLexico();

                analizador.Analizador(txtExpresion.Text.ToString());

                txtResultado.Text = analizador.dameListaToken();
                txtErrores.Text = analizador.dameListaErrores();
            } else {
                MessageBox.Show("El cuadro de texto está vacío");
            }
        }

        private void txtExpresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnAnalizar_Click(sender, e);
            }
        }
    }
}
