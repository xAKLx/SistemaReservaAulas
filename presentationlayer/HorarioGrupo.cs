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
    public partial class HorarioGrupo : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        public HorarioGrupo()
        {
            InitializeComponent();
            refreshDGV();
        }
        
        private void refreshDGV()
        {
            var horarios = logic.getHorariosGrupos();

            dgvGrupoHorario.RowCount = horarios.Count;

            int index = 0;
            foreach(var horario in horarios)
            {
                dgvGrupoHorario.Rows[index].Cells["Grupo"].Value = horario.CodigoAsignatura + "-" + horario.NumeroGrupo;

                dgvGrupoHorario.Rows[index].Cells["Horario"].Value =
                    new System.Globalization.CultureInfo("es-DO").DateTimeFormat.GetDayName(new DateTime(1, 1, horario.Dia, 0, 0, 0).DayOfWeek)
                    + " " +
                    horario.HoraInicio.Hours + ":" + horario.HoraInicio.Minutes
                        + " - " +
                        horario.HoraFin.Hours + ":" + horario.HoraFin.Minutes;

                dgvGrupoHorario.Rows[index].Cells["No"].Value = horario.HorarioNo;

                if (null == horario.IdAula)
                    dgvGrupoHorario.Rows[index].Cells["Aula"].Value = "No asignado";
                else
                    dgvGrupoHorario.Rows[index].Cells["Aula"].Value = horario.IdAula;
               index++;
            }
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void tsbAsignarAula_Click(object sender, EventArgs e)
        {
            DataGridViewRow temp = null;
            foreach( var aula in dgvGrupoHorario.SelectedCells)
            {
                temp = dgvGrupoHorario.Rows[((DataGridViewCell)aula).RowIndex];
                break;
            }

            if (null != temp)
            {
                String[] split = temp.Cells["Grupo"].Value.ToString().Split('-');

                if (split.Length < 2)
                    return;

                String codigoAsignatura = split[0];

                for (int i = 1; i < split.Length - 1; i++)
                    codigoAsignatura += "-" + split[i];

                try
                {
                    byte noGrupo = byte.Parse(split.Last());
                    byte horarioNo = byte.Parse(temp.Cells["No"].Value.ToString());
                    new AsignarAula(VO_Grupo.getGrupo(codigoAsignatura, noGrupo, logic), horarioNo).ShowDialog();
                }
                catch (Exception) { }
                
                refreshDGV();
            }
            
        }

        private void dgvGrupoHorario_SelectionChanged(object sender, EventArgs e)
        {
            switch (dgvGrupoHorario.SelectedCells.Count)
            {
                case 1:
                    tsbAsignarAula.Enabled = true;
                    break;
                default:
                    tsbAsignarAula.Enabled = false;
                    break;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbRevocarAula_Click(object sender, EventArgs e)
        {
            DataGridViewRow temp = null;
            foreach (var aula in dgvGrupoHorario.SelectedCells)
            {
                temp = dgvGrupoHorario.Rows[((DataGridViewCell)aula).RowIndex];
                break;
            }

            if (null != temp)
            {
                String[] split = temp.Cells["Grupo"].Value.ToString().Split('-');

                if (split.Length < 2)
                    return;

                String codigoAsignatura = split[0];

                for (int i = 1; i < split.Length - 1; i++)
                    codigoAsignatura += "-" + split[i];

                try
                {
                    byte noGrupo = byte.Parse(split.Last());
                    byte horarioNo = byte.Parse(temp.Cells["No"].Value.ToString());
                    logic.RevocarAula(VO_HorarioGrupo.getHorarioGrupo(codigoAsignatura, noGrupo, horarioNo, logic));
                }
                catch (Exception) { }

                refreshDGV();
            }

        }
    }
}
