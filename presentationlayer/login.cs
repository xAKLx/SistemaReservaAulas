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
    public partial class login : Form
    {
        BLL logic = BLLClassForSql.getUniqueInstance();
        enum TipoLogin
        {
            Estudiante,
            Profesor,
            Administrador
        };

        LinkedList<TipoLogin> listLogin = new LinkedList<TipoLogin>();
        LinkedListNode<TipoLogin> Current;

        public login()
        {
            InitializeComponent();

            listLogin.AddLast(TipoLogin.Administrador);
            listLogin.AddLast(TipoLogin.Estudiante);
            listLogin.AddLast(TipoLogin.Profesor);
            Current = listLogin.First;
            UpdateTipo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (ContraTB.UseSystemPasswordChar)
                    ContraTB.UseSystemPasswordChar = false;
                else
                    ContraTB.UseSystemPasswordChar = true;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (null == Current.Next)
                Current = listLogin.First;
            else
                Current = Current.Next;

            UpdateTipo();
        }

        private void Previous_Click(object sender, EventArgs e)
        {

            if (null == Current.Previous)
                Current = listLogin.Last;
            else
                Current = Current.Previous;

            UpdateTipo();
        }

        private void UpdateTipo()
        {
            Tipo.Text = Current.Value.ToString();

            if (Current.Value == TipoLogin.Estudiante)
                identificador.Text = "Matricula";
            else if (Current.Value == TipoLogin.Administrador)
                identificador.Text = "Nombre Usuario";
            else
                identificador.Text = "Cedula";
            identificadorTB.Clear();
            ContraTB.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch(Current.Value)
            {
                case TipoLogin.Estudiante:
                    if (null != logic.loginEstudiante(int.Parse(identificadorTB.Text), ContraTB.Text))
                    {
                        var profForm = new EstudianteProfesorMain();
                        this.Visible = false;
                        profForm.ShowDialog();
                        this.Visible = true;
                        logic.logout();
                        UpdateTipo();
                    }
                    break;
                case TipoLogin.Profesor:
                    if (null != logic.loginProfesor(identificadorTB.Text, ContraTB.Text))
                    {
                        var profForm = new EstudianteProfesorMain();
                        this.Visible = false;
                        profForm.ShowDialog();
                        this.Visible = true;
                        logic.logout();
                        UpdateTipo();
                    }
                    break;
                case TipoLogin.Administrador:
                    if (null != logic.loginAdministrador(identificadorTB.Text, ContraTB.Text))
                    {
                        var adminForm = new AdministradorMain();
                        this.Visible = false;
                        adminForm.ShowDialog();
                        this.Visible = true;
                        logic.logout();
                        UpdateTipo();
                    }
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
