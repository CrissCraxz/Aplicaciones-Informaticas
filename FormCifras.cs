using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCifras
{
    public partial class FormCifras : Form
    {
        public FormCifras()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    ClasCifras ob = new ClasCifras(int.Parse(textBox1.Text));
                    labelRespuesta.Text = " El número " +  textBox1.Text + " tiene " + ob.operacion().ToString() + " cifras" ;
                    textBox1.Focus();
                    textBox1.Text = null;

                }

            } catch {
                MessageBox.Show("Número no ingresado", "Campo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = null;
                textBox1.Focus();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
