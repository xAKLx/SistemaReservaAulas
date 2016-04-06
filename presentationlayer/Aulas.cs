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
    public partial class Aulas : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        public Aulas()
        {
            InitializeComponent();
            refrescarDGV();
        }

        private void addAula_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AddAula().ShowDialog();
            refrescarDGV();
            this.Visible = true;
        }

        private void tsbrefrescar_Click(object sender, EventArgs e)
        {
            if (cbAplicarFiltro.Checked)
                if (TimeIsValid())
                    refrescarDGV(
                        logic.getAulaDisponible(
                        new TimeSpan(int.Parse(tbHoraI.Text), int.Parse(tbMinI.Text), 0),
                        new TimeSpan(int.Parse(tbHoraF.Text), int.Parse(tbMinF.Text), 0),
                        dayToInt(tscbDia.SelectedItem.ToString())
                        ));
                else
                    refrescarDGV();
        }

        private void refrescarDGV()
        {
            var listaAulas = logic.getAulas();

            dgvAulas.RowCount = listaAulas.Count;

            int index = 0;
            foreach (var aula in listaAulas)
            {
                dgvAulas.Rows[index].Cells["Aula"].Value = aula.ID.ToString();
                index++;
            }
        }

        private void refrescarDGV(List<VO_Aula> lista)
        {
            var listaAulas = lista;

            dgvAulas.RowCount = listaAulas.Count;

            int index = 0;
            foreach (var aula in listaAulas)
            {
                dgvAulas.Rows[index].Cells["Aula"].Value = aula.ID.ToString();
                index++;
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            DataGridViewCell temp = null;
            foreach (var aula in dgvAulas.SelectedCells)
            {
                temp = (DataGridViewCell) aula;
                break;
            }

            if (null != temp)
            {
                this.Visible = false;
                new EditarAula(int.Parse(temp.Value.ToString())).ShowDialog();
                refrescarDGV();
                this.Visible = true;
            }
            
        }

        private void tsbVerDetalles_Click(object sender, EventArgs e)
        {
            DataGridViewCell temp = null;
            foreach (var aula in dgvAulas.SelectedCells)
            {
                temp = (DataGridViewCell)aula;
                break;
            }

            if (null != temp)
            {
                this.Visible = false;
                new EditarAula(int.Parse(temp.Value.ToString()), false).ShowDialog();
                refrescarDGV();
                this.Visible = true;
            }
        }

        private void dgvAulas_SelectionChanged(object sender, EventArgs e)
        {
            switch (dgvAulas.SelectedCells.Count)
            {
                case 1:
                    tsbEliminar.Enabled = tsbEditar.Enabled = tsbVerDetalles.Enabled = true;
                    break;
                default:
                    tsbEliminar.Enabled = tsbEditar.Enabled = tsbVerDetalles.Enabled = false;
                    break;
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCell temp = null;
            foreach (var aula in dgvAulas.SelectedCells)
            {
                temp = (DataGridViewCell)aula;
                break;
            }

            if (null != temp)
            {
                try
                {
                    logic.eliminarAula( VO_Aula.getAula( int.Parse( temp.Value.ToString() ), logic ) );
                }catch(Exception){ }
                
            }

            refrescarDGV();
        }

        private void rdAplicarFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAplicarFiltro.Checked)
            {
                if (TimeIsValid())
                    refrescarDGV(
                        logic.getAulaDisponible(
                        new TimeSpan(int.Parse(tbHoraI.Text), int.Parse(tbMinI.Text), 0),
                        new TimeSpan(int.Parse(tbHoraF.Text), int.Parse(tbMinF.Text), 0),
                        dayToInt(tscbDia.SelectedItem.ToString())
                        ));
            }
            else
                refrescarDGV();
            
        }

        private bool TimeIsValid()
        {
            try
            {
                short horaI = short.Parse(tbHoraI.Text),
                        minI = short.Parse(tbMinI.Text),
                        horaF = short.Parse(tbHoraF.Text),
                        minF = short.Parse(tbMinF.Text);

                TimeSpan time = new TimeSpan(horaI, minI, 0);

                int dia;

                if(tscbDia.SelectedItem != null)
                    try 
	                {	        
		                dia = dayToInt(tscbDia.SelectedItem.ToString());
	                }
	                catch (Exception)
	                {
		
		                return false;
	                }
                else
                    return false;

                if (horaI <= 23 && horaI >= 0 &&
                    horaF <= 23 && horaF >= 0 &&
                    minI <= 59 && minI >= 0 &&
                    minF <= 59 && minF >= 0 &&
                    time.CompareTo(new TimeSpan(horaF, minF, 0)) < 0 &&
                    tscbDia.SelectedItem != null &&
                    dia != 7)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private byte dayToInt(String dia)
        {
            if (dia.CompareTo("Lunes") == 0)
                return 1;
            else if (dia.CompareTo("Martes") == 0)
                return 2;
            else if (dia.CompareTo("Miercoles") == 0)
                return 3;
            else if (dia.CompareTo("Jueves") == 0)
                return 4;
            else if (dia.CompareTo("Viernes") == 0)
                return 5;
            else if (dia.CompareTo("Sabado") == 0)
                return 6;
            else if (dia.CompareTo("Domingo") == 0)
                return 7;
            else
                throw new ArgumentException("dia");
        }

        private void tbHoraI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void tbHoraI_TextChanged(object sender, EventArgs e)
        {
            cbAplicarFiltro.Enabled = TimeIsValid();
            if (!cbAplicarFiltro.Enabled)
                cbAplicarFiltro.Checked = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbGenerarReporte_Click(object sender, EventArgs e)
        {
            DataGridViewCell temp = null;
            foreach (var aula in dgvAulas.SelectedCells)
            {
                temp = (DataGridViewCell)aula;
                break;
            }

            if (null != temp)
            {
                try
                {
                    new ReporteHorariosGruposConAula(VO_Aula.getAula(int.Parse(temp.Value.ToString()), logic)).Show();
                }
                catch (Exception) { }

            }

            refrescarDGV();
        }
    }
}
