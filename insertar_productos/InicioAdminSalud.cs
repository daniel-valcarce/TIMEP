using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace insertar_productos
{
    public partial class Inicioadmisalud : Form
    {
        public Inicioadmisalud()
        {
            InitializeComponent();
        }
        public void cargar(DataTable tabla1)
        {
            dtg_visualizarp.DataSource = tabla1;
        }

        private void dtg_visualizarp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                foreach (DataGridViewRow dr in dtg_visualizarp.SelectedRows)
                {
                    dr.Selected = false;
                }
                dtg_visualizarp.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_buscarp_Click_1(object sender, EventArgs e)
        {
            DataTable datos = CRUD.todos1(int.Parse(txt_buscarp.Text));
            dtg_visualizarp.DataSource = datos;
        }

        private void btn_eliminarp_Click_1(object sender, EventArgs e)
        {
            dtg_visualizarp.Rows[0].Selected = true;
            int IDValor = int.Parse(dtg_visualizarp.Rows[0].Cells["numero_identificacion"].Value.ToString());
            MessageBox.Show(IDValor.ToString());
            int valor = CRUD.eliminarp(IDValor);
            if (valor > 0)
            {
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void Agregar_paciente_Click_1(object sender, EventArgs e)
        {
            AgregarPaciente agregar = new AgregarPaciente();
            agregar.form_anterio = this;
            agregar.form_anterio.Enabled = false;
            agregar.Show();
        }
    }
}