using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {

        //ocultar menu
        private void hideSubmenu()
        {
            panelSubmenuLeft.Visible = false;
            panelSubmenuRight.Visible = false;

        }

        //mostrar a sub menu
        private void showSubmenu(Panel subpanel)
        {
            if (subpanel.Visible == false)
            {
                hideSubmenu();
                subpanel.Visible = true;
            }else
            {
                subpanel.Visible = false;
            }
        }
        public FormPrincipal()
        {
            InitializeComponent();
          
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void iconButtonLeft_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuLeft);
        }

        private void iconButtonRigth_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuRight);
        }

    

     
        /*
        private void openChildForm(Form childForm)
        {
            if (currentForm !=  null)
            {
                currentForm.Close();
                currentForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(childForm);
                panelContenedor.Tag = childForm;
                //cuando se ponga logo
                // childForm.BringToFront();
                childForm.Show();

            }
        }*/

        private void iconButtonCifras_Click(object sender, EventArgs e)
        {
            AbrirForm<WindowsFormsAppCifras.FormCifras>();
            hideSubmenu();

        }


        //abrir un formulario en un panel o contendor
        private void AbrirForm<Miform>() where Miform : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Miform>().FirstOrDefault();//Busca en la coleccin un formulario
            //Si el form no existe
            if (formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();

            }
        }














    }
}
