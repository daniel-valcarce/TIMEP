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
    public partial class Iniciomedico : Form
    {
        public Iniciomedico()
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

        private void Agregar_paciente_Click(object sender, EventArgs e)
        {
            AgregarPaciente newpacient = new AgregarPaciente();
            newpacient.Show();
        }

        private void btn_buscarp_Click(object sender, EventArgs e)
        {
            DataTable datos = CRUD.todos1(int.Parse(txt_buscarp.Text));
            dtg_visualizarp.DataSource = datos;
        }

        private void btn_eliminarp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro d eelinar este usuario", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            { 
            dtg_visualizarp.Rows[0].Selected = true;
            int IDValor1 = int.Parse(dtg_visualizarp.Rows[0].Cells["numero_identificacion"].Value.ToString());
            MessageBox.Show(IDValor1.ToString());
            int valor = CRUD.eliminarp(IDValor1);
            if (valor > 0)
            {
                //MessageBox.Show("Se elimino correctamente");

                if (MessageBox.Show("Se elimino correctamente", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    return;
                }

            }
            }

            else
            {
                return;
                //MessageBox.Show("Ha ocurrido un error");
            }
        }
        private void Iniciomedico_Load(object sender, EventArgs e)
        {

        }
    }
}
