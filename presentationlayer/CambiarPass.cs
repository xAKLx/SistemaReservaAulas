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
    public partial class CambiarPass : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        public CambiarPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ContraTB.UseSystemPasswordChar)
            {
                ContraTB.UseSystemPasswordChar = false;
                NContraTB.UseSystemPasswordChar = false;
            }
            else
            {
                ContraTB.UseSystemPasswordChar = true;
                NContraTB.UseSystemPasswordChar = true;
            }
                
        }

        private void nombreUsuarioTB_TextChanged(object sender, EventArgs e)
        {
            if (ContraTB.TextLength > 3 && NContraTB.TextLength > 3)
                btnAceptar.Enabled = true;
            else
                btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            VO_UserAdministrador temp = null;
            if(logic.User != null && typeof(VO_UserAdministrador) == logic.User.GetType())
                temp = (VO_UserAdministrador) logic.User;
            
            if(null != temp)
            try
            {
                logic.editarAdministrador(temp.NombreUsuario, ContraTB.Text, NContraTB.Text);
            }
            catch (Exception) { }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
