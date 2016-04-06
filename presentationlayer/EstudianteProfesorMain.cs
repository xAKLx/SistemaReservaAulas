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
    public partial class EstudianteProfesorMain : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        public EstudianteProfesorMain()
        {
            InitializeComponent();
            Updatedgv();
        }

        private bool Updatedgv()
        {
            var listaGrupo = logic.getUserGroups();
            var listaHorario = new List<VO_HorarioGrupo>();
            foreach(VO_Grupo grupo in listaGrupo)
            {
                listaHorario.AddRange(grupo.getHorarios(logic));
            }

            dgvLista.RowCount = listaHorario.Count;

            int index = 0;
            foreach(var horario in listaHorario)
            {
                dgvLista.Rows[index].Cells["Grupo"].Value = horario.CodigoAsignatura + "-" + horario.NumeroGrupo.ToString();

                try
                {
                    dgvLista.Rows[index].Cells["Horario"].Value =
                        new System.Globalization.CultureInfo("es-DO").DateTimeFormat.GetDayName(new DateTime(1, 1, horario.Dia, 0, 0, 0).DayOfWeek)
                        + " " +
                        horario.HoraInicio.Hours + ":" + horario.HoraInicio.Minutes
                        + " - " +
                        horario.HoraFin.Hours + ":" + horario.HoraFin.Minutes;
                    dgvLista.Rows[index].Cells["Aula"].Value = horario.IdAula;
                }
                catch (Exception) { }

                index++;
            }

            return true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            logic.logout();
            Close();
        }
    }
}
