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
    public partial class AdministradorMain : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        public AdministradorMain()
        {
            InitializeComponent();
        }

        private void btnManejarAulas_Click(object sender, EventArgs e)
        {
            var aulas = new Aulas();
            this.Visible = false;
            aulas.ShowDialog();
            this.Visible = true;
        }

        private void btnAsignarAulas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new HorarioGrupo().ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logic.logout();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var admin = new Administradores();
            this.Visible = false;
            admin.ShowDialog();
            this.Visible = true;
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new CambiarPass().ShowDialog();
            this.Visible = true;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            var reporte = new ReporteHorariosGruposConAula();
            reporte.Show();
        }
    }
}
