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
    public partial class Tutores : Form
    {
        private BusinessLogicLayer businessLogicLayer;
        public Tutores()
        {
            InitializeComponent();
            businessLogicLayer = new BusinessLogicLayer();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            AbrirTutor_detalles();
        }
        #region metodos
        private void AbrirTutor_detalles()
        {
            Tutor_detalles tutor_detalles = new Tutor_detalles();
            tutor_detalles.ShowDialog(this);
        }
        #endregion

        private void Tutores_Load(object sender, EventArgs e)
        {
            PopulateTutores();
        }
        public void PopulateTutores(string texto_buscar=null)
        {
            List<Tutor> tutores = businessLogicLayer.GetTutores(texto_buscar);
            gridTutor.DataSource = tutores;

        }

        private void gridTutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridTutor.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Editar")
            {
                Tutor_detalles tutor_Detalles = new Tutor_detalles();
                tutor_Detalles.CargarTutor(new Tutor
                {
                    Id_tutor = gridTutor.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Nombres = gridTutor.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Apellido_Paterno = gridTutor.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Apellido_Materno = gridTutor.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Titulo_Academico = gridTutor.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                tutor_Detalles.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                businessLogicLayer.EliminarTutor(gridTutor.Rows[e.RowIndex].Cells[0].Value.ToString());
                PopulateTutores();
            }
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            PopulateTutores(txtbusqueda.Text);
        }
    }
}
