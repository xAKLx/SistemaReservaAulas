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
    public partial class AddAula : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        int id = 0;

        public AddAula()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                logic.addAula(new VO_Aula(id, tbCaracteristicas.Text));
            }
            catch (Exception) { }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbIdentificador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(tbIdentificador.Text);

                if (null == VO_Aula.getAula(id, logic))
                    btnAceptar.Enabled = true;
                else
                    btnAceptar.Enabled = false;
            }
            catch (Exception) { btnAceptar.Enabled = false; }
        }
    }
}
