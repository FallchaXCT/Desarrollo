using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Tutor_detalles : Form
    {
        private BusinessLogicLayer businessLogicLayer;
        private Tutor _tutor;
        public Tutor_detalles()
        {
            InitializeComponent();
            businessLogicLayer = new BusinessLogicLayer();

        }

        private void lbnombres_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.Id_tutor = txtId_tutor.Text;
            tutor.Nombres = txtNombres.Text;
            tutor.Apellido_Paterno = txtApellido_Paterno.Text;
            tutor.Apellido_Materno = txtApellido_Materno.Text;
            tutor.Titulo_Academico = txtTitulo_Academico.Text;

            if (txtId_tutor.Enabled != false)
            {
                businessLogicLayer.GuardarTutor(tutor);
            }
            else
            {
                businessLogicLayer.ModificarTutor(tutor);
            }
            this.Close();
            ((Tutores)this.Owner).PopulateTutores();
        }
        public void CargarTutor(Tutor tutor)
        {
            txtId_tutor.Enabled = false;
            _tutor = tutor;
            if (tutor != null)
            {
                ClearTutor_detalles();

                txtId_tutor.Text = tutor.Id_tutor;
                txtNombres.Text = tutor.Nombres;
                txtApellido_Paterno.Text = tutor.Apellido_Paterno;
                txtApellido_Materno.Text = tutor.Apellido_Materno;
                txtTitulo_Academico.Text = tutor.Titulo_Academico;
            }
        }
        public void ClearTutor_detalles()
        {
            txtId_tutor.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellido_Paterno.Text = string.Empty;
            txtApellido_Materno.Text = string.Empty;
            txtTitulo_Academico.Text = string.Empty;
        }
    }
}
