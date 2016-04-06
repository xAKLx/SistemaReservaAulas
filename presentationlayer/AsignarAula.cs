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
    public partial class AsignarAula : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        VO_HorarioGrupo horarioGrupo = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="grupo"></param>
        /// <param name="horarioNo"></param>
        /// <exception cref="System.NullReferenceException">Cuando grupo es null.</exception>
        /// <exception cref="System.InvalidOperationException">Cuando grupo no tiene horarios.</exception>
        /// <exception cref="System.ArgumentException">Cuando el grupo no tiene el horarioNo otorgado.</exception>
        public AsignarAula(VO_Grupo grupo, int horarioNo=0)
        {
            InitializeComponent();

            List<VO_HorarioGrupo> lista = grupo.getHorarios(logic);

            if (lista.Count == 0)
                throw new InvalidOperationException("grupo no tiene horarios.");

            foreach( var horario in grupo.getHorarios(logic))
                if(horario.HorarioNo == horarioNo)
                {
                    horarioGrupo = horario;
                    break;
                }
            if (null == horarioGrupo)
                throw new ArgumentException("horarioNo");

            lGrupo.Text += horarioGrupo.CodigoAsignatura + "-" + horarioGrupo.NumeroGrupo.ToString();
            lHorario.Text += new System.Globalization.CultureInfo("es-DO").DateTimeFormat.GetDayName(new DateTime(1, 1, horarioGrupo.Dia, 0, 0, 0).DayOfWeek)
                    + " " +
                    horarioGrupo.HoraInicio.Hours + ":" + horarioGrupo.HoraInicio.Minutes
                        + " - " +
                        horarioGrupo.HoraFin.Hours + ":" + horarioGrupo.HoraFin.Minutes;
            refrescarDGV();
        }

        private void refrescarDGV()
        {
            var listaAulas = new HashSet<VO_Aula>();

            if (null != horarioGrupo.IdAula)
            {
                var aula = VO_Aula.getAula(horarioGrupo.IdAula.GetValueOrDefault(), logic);
                if (null != aula)
                    listaAulas.Add(aula);
            }

            foreach (var aula in logic.getAulaDisponible( horarioGrupo.HoraInicio, horarioGrupo.HoraFin, horarioGrupo.Dia))
            {
                listaAulas.Add(aula);
            }

            dgvAulas.RowCount = listaAulas.Count;

            int index = 0;
            foreach (var aula in listaAulas)
            {
                dgvAulas.Rows[index].Cells["Aula"].Value = aula.ID.ToString();
                index++;
            }

            dgvAulas.Rows[0].Cells["Aula"].Selected = true;
        }

        private void tsbAsignar_Click(object sender, EventArgs e)
        {
            DataGridViewCell temp = null;
            foreach( var aula in dgvAulas.SelectedCells)
            {
                temp = (DataGridViewCell)aula;
                break;
            }

            if (null != temp)
            {
                try
                {
                    logic.asignarAula(VO_Aula.getAula(int.Parse(temp.Value.ToString()), logic), horarioGrupo);
                }
                catch (Exception) { }
                
                Close();
            }
            refrescarDGV();    
        }

        private void tsbVerDetalles_Click(object sender, EventArgs e)
        {
            DataGridViewCell temp = null;
            foreach( var aula in dgvAulas.SelectedCells)
            {
                temp = (DataGridViewCell)aula;
                break;
            }
            if (null != temp)
                new EditarAula(int.Parse(temp.Value.ToString()), false).ShowDialog();
            refrescarDGV();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAulas_SelectionChanged(object sender, EventArgs e)
        {
            switch(dgvAulas.SelectedCells.Count)
            {
                case 1:
                    tsbAsignar.Enabled = tsbVerDetalles.Enabled = true;
                    break;
                default:
                    tsbAsignar.Enabled = tsbVerDetalles.Enabled = false;
                    break;
            }
        }
    }
}
