using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertar_productos
{
    public partial class Inicioadmin : Form
    {
        public static DataTable datos;

        public Inicioadmin()
        {
            InitializeComponent();
        }
        public void cargar(DataTable tabla)
        {
            datos = tabla;
            dtg_visualizaru.DataSource = tabla;

            dtg_visualizaru.ClearSelection();
         
        }

            private void dtg_visualizaru_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex > -1)
                {
                    foreach (DataGridViewRow dr in dtg_visualizaru.SelectedRows)
                    {
                       dr.Selected = false;
                   }
                    dtg_visualizaru.Rows[e.RowIndex].Selected = true;
               }   
            }

            private void btn_eliminar_Click(object sender, EventArgs e)
            {
               
                if(MessageBox.Show("Esta seguro de eliminar este usuario","",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation)==DialogResult.Yes)
                 
            {
                int IDValor = int.Parse(dtg_visualizaru.CurrentRow.Cells["numero_identificacion"].Value.ToString());
                //int IDValor = int.Parse(dtg_visualizaru.CurrentRow.Cells["numero_identificacion"].Value.ToString());
                
                    int valor = CRUD.eliminar(IDValor);
                if (valor > 0)
                {
                    MessageBox.Show("Se elimino correctamente");

                    DataTable datoss = CRUD.todos();
                    dtg_visualizaru.DataSource = datoss;
                    dtg_visualizaru.RefreshEdit();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }

                else
                {
                    return;
                    //MessageBox.Show("Ha ocurrido un error");
                }
            }
            public static void recarga_dtg(DataTable dato)
            {
                insertar_productos.Inicioadmin.datos = dato;
               

                
            }
            public void recarga(DataTable valores)
            {
                dtg_visualizaru.DataSource = datos;
                dtg_visualizaru.RefreshEdit();
              
                
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Enabled=false;
              
                AgregarUsuario agregar = new AgregarUsuario("Agregar Usuario");
                agregar.formAnterior = this;

                agregar.Show();
                
            }

            private void button2_Click(object sender, EventArgs e)
            {
              DataTable datoss= CRUD.todos(int.Parse(txt_buscaru.Text));
              dtg_visualizaru.DataSource = datoss;

            }
        /*
            private void Inicioadmin_Activated(object sender, EventArgs e)
            {
                DataTable datoss = CRUD.todos();
                dtg_visualizaru.DataSource = datoss;
                dtg_visualizaru.RefreshEdit();
                MessageBox.Show("Activado");
            }
            private void Inicioadmin_VisibleChanged(object sender, EventArgs e)
            {
                DataTable datoss = CRUD.todos();
                dtg_visualizaru.DataSource = datoss;
                dtg_visualizaru.RefreshEdit();
                MessageBox.Show("Visible");
            }
        */
            private void dtg_visualizaru_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                
            }


            private void Inicioadmin_DoubleClick(object sender, EventArgs e)
            {
         
               
            }

            private void Inicioadmin_EnabledChanged(object sender, EventArgs e)
            {
                DataTable datoss = CRUD.todos();
                dtg_visualizaru.DataSource = datoss;
                dtg_visualizaru.RefreshEdit();
               
            }

            private void btn_editar_Click(object sender, EventArgs e)
            {
             

               
                int IDValor = int.Parse(dtg_visualizaru.CurrentRow.Cells["numero_identificacion"].Value.ToString());
                DataTable datos = CRUD.selec1(IDValor);
                this.Enabled = false;
                AgregarUsuario agregar = new AgregarUsuario("Editar Información", datos);
                agregar.formAnterior = this;
                agregar.accion = "Actualizar";
                agregar.id = IDValor;
                agregar.Show();
            }
                  
            
        
    }
}
