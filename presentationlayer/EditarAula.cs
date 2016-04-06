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
    public partial class EditarAula : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        VO_Aula aula;
        bool escritura;
        public EditarAula(int id, bool escritura = true)
        {
            InitializeComponent();

            try
            {
                aula = VO_Aula.getAula(id, logic);
            }
            catch (Exception) { }
            
            if (null == aula)
                Close();
            identificador.Text = "Identificador: " + id.ToString();
            tbCaracteristicas.Text = aula.Caracteristicas;

            this.escritura = tbCaracteristicas.Enabled = escritura;

            if (!escritura)
                btnCancelar.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(escritura)
            {
                aula.Caracteristicas = tbCaracteristicas.Text;
                try
                {
                    logic.editarAula(new VO_Aula(aula.ID, tbCaracteristicas.Text));
                }
                catch (InvalidOperationException) { }
            }
            
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
