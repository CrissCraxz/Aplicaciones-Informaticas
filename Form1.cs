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

        //abrir un formulario en un panel o contendor

        private Form currentForm = null;
        private void openChildForm(Form childForm)
        {
            if (currentForm != null)
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
        }



    }
}
