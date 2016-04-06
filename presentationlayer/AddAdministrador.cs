using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class AddAdministrador : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();

        public AddAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ContraTB.UseSystemPasswordChar)
                ContraTB.UseSystemPasswordChar = false;
            else
                ContraTB.UseSystemPasswordChar = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nombreUsuarioTB_TextChanged(object sender, EventArgs e)
        {
            if (nombreUsuarioTB.TextLength > 3 && ContraTB.TextLength > 3)
                btnAceptar.Enabled = true;
            else
                btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                logic.agregarAdministrador(new VO_UserAdministrador(nombreUsuarioTB.Text, ContraTB.Text));
            }
            catch (Exception) { }
            Close();
        }
    }
}
 