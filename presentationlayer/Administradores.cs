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
    public partial class Administradores : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        public Administradores()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            refrescarDGV();
        }

        private void tsbAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refrescarDGV()
        {
            var lista = logic.getAdministrador();

            if (null != logic.User && typeof(VO_UserAdministrador) == logic.User.GetType())
                lista.Remove((VO_UserAdministrador)logic.User);
            dgvLista.RowCount = lista.Count;

            int index = 0;
            foreach (var admin in lista)
            {
                dgvLista.Rows[index].Cells["NombreUsuario"].Value = admin.NombreUsuario.ToString();
                index++;
            }
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            refrescarDGV();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new AddAdministrador().ShowDialog();
            refrescarDGV();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow temp = null;
            foreach (var cell in dgvLista.SelectedCells)
            {
                temp = ((DataGridViewCell)cell).OwningRow;
                break;
            }

            if (null != temp)
            {
                try
                {
                    new EliminarAdministrador(temp.Cells[0].Value.ToString()).ShowDialog();
                }
                catch (Exception) { }

            }

            refrescarDGV();
        }
    }
}
