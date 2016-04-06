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
    public partial class EliminarAdministrador : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        String usuario = null;
        public EliminarAdministrador(String nombreUsuario)
        {
            if (null == nombreUsuario)
                throw new ArgumentNullException("nombreUsuario");

            InitializeComponent();
            usuario = nombreUsuario;
            lNombreUsuario.Text += nombreUsuario;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                logic.eliminarAdministrador(usuario, ContraTB.Text);
            }
            catch (Exception) { }
            Close();
        }
    }
}
