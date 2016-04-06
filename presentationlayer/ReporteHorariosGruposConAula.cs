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
    public partial class ReporteHorariosGruposConAula : Form
    {
        public ReporteHorariosGruposConAula(VO_Aula aula = null)
        {
            InitializeComponent();

            if (null != aula)
            {
                // TODO: This line of code loads data into the 'SistemaReservasDataSet.HorarioGruposConAulas' table. You can move, or remove it, as needed.
                this.HorarioGruposConAulasTableAdapter.FillByAula(this.SistemaReservasDataSet.HorarioGruposConAulas, aula.ID);
            }
            else
            {
                // TODO: This line of code loads data into the 'SistemaReservasDataSet.HorarioGruposConAulas' table. You can move, or remove it, as needed.
                this.HorarioGruposConAulasTableAdapter.Fill(this.SistemaReservasDataSet.HorarioGruposConAulas);
            }
            this.reportViewer1.RefreshReport();
        }

        private void ReporteHorariosGruposConAula_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
