using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace insertar_productos
{
  
    public partial class medicamento_enfermedades : Form
    {
        public  DataTable enfermedades_seleccionadas= new DataTable();
       
          private int id_enfer_o_medi;
        public Form form_anterio;
        //private Array datos_enfer_y_medica[];


        public medicamento_enfermedades()
         
        {
            InitializeComponent();
            mc_enferm.Hide();
            btn_cancel_enfer.Hide();
            btn_guar_fech.Hide();
            enfermedades_seleccionadas.Columns.Add("Nombre", typeof(string));
            enfermedades_seleccionadas.Columns.Add("id", typeof(string));
            enfermedades_seleccionadas.Columns.Add("tipo", typeof(string));
            enfermedades_seleccionadas.Columns.Add("fecha_inicio", typeof(string));
            enfermedades_seleccionadas.Columns.Add("fecha_final", typeof(string));
            /*
            DataTable datos_List = new DataTable();
            datos_List.Columns.Add("id", typeof(string));
            datos_List.Columns.Add("nombre", typeof(string));
            DataRow filas = datos_List.NewRow();
            filas["id"] = "Daniel";
            filas["nombre"] = "Eder Daniel Valcarcel vanegas";
            datos_List.Rows.Add(filas);
            DataRow filas2 = datos_List.NewRow();
            filas2["id"] = "Daniel 2";
            filas2["nombre"] = "Eder Daniel Valcarcel vanegas 222";
            datos_List.Rows.Add(filas2);
            DataRow filas3 = datos_List.NewRow();
            filas3["id"] = "Daniel 33";
            filas3["nombre"] = "Eder Daniel Valcarcel vanegas 333";
            datos_List.Rows.Add(filas3);
            
             lstb_enfer_selec.DataSource = datos_List;
             lstb_enfer_selec.DisplayMember="nombre";
             lstb_enfer_selec.ValueMember = "id";
       

        
            DataTable nueva_tabla = new DataTable();
            int x = datos_List.Rows.Count;
              for (int m = 0; m < x; m = m + 1)
              {
                  DataRow header = nueva_tabla.NewRow();
                  DataRow fila = datos_List.Rows[m];
                  header["id"] = fila[""].ToString();
                  header["nombre"] = fila[""].ToString();
              }
            /*
            DataTable nueva_tabla = new DataTable();
            nueva_tabla.Columns.Add("id", typeof(string));
            nueva_tabla.Columns.Add("Nombre", typeof(string));
            DataRow header = nueva_tabla.NewRow();
            DataRow fila = datos.Rows[m];
            header["Nombre"] = fila["nombre"].ToString();
            header["Primer Apellido"] = fila["primer_apellido"].ToString();*/
        }


        private void medicamento_enfermedades_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void txt_enferm_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_enferm.Text == "")
            {
                DataTable vacio = new DataTable();
                lstb_resul_bus_enfer.DataSource = vacio;
            }
            if(txt_enferm.Text !=""){
                string texto = txt_enferm.Text.ToUpper().Trim();
                string valor ="%"+ texto + "%";     
            DataTable resultados = CRUD.buscar(valor, "enfermedades");
            lstb_resul_bus_enfer.DataSource = resultados;
            lstb_resul_bus_enfer.DisplayMember = "nombre";
            lstb_resul_bus_enfer.ValueMember = "id";
             
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void lstb_resul_bus_enfer_DoubleClick(object sender, EventArgs e)
        {

       
            DataRow header = enfermedades_seleccionadas.NewRow();
            lstb_enfer_selec.Items.Add(lstb_resul_bus_enfer.Text);
            header["Nombre"] = lstb_resul_bus_enfer.Text;
            header["id"] = lstb_resul_bus_enfer.SelectedValue;
            header["tipo"] = "Enfermedad";
            header["fecha_final"] = "";
            DateTime fecha =  DateTime.Today;
           header["fecha_inicio"] = fecha.ToShortDateString() +" "+ fecha.ToShortTimeString();
           enfermedades_seleccionadas.Rows.Add(header);
           //DataRow fila = enfermedades_seleccionadas.NewRow();
           int filas=enfermedades_seleccionadas.Rows.Count;
           DataRow fila = enfermedades_seleccionadas.Rows[filas-1];
           MessageBox.Show(fila["id"].ToString());    
            



        }

        private void mc_enferm_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btn_cancel_enfer_Click(object sender, EventArgs e)
        {
            pn_botones.Enabled = true;
            pn_enfer.Enabled = true;
            pn_medica.Enabled = true;
            mc_enferm.Hide();
            btn_cancel_enfer.Hide();
            btn_guar_fech.Hide();
        }

        private void btn_guar_fech_Click(object sender, EventArgs e)
        {
          
           
        }

        private void lstb_enfer_selec_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lstb_enfer_selec.SelectedValue.ToString());
        }

        private void lstb_resul_bus_enfer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_enferm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void lstb_resul_bus_medic_DoubleClick(object sender, EventArgs e)
        {
            pn_botones.Enabled = false;
            pn_enfer.Enabled = false;
            pn_medica.Enabled = false;
            lbl_titu_mont_cal.Text = "Fecha de Inicio";
            mc_enferm.Show();
            btn_cancel_enfer.Show();
            btn_guar_fech.Show();
        }

        private void txt_medicam_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_medicam.Text == "")
            {
                DataTable vacio = new DataTable();
               lstb_resul_bus_medic.DataSource = vacio;
            }
            if (txt_medicam.Text != "")
            {
                string texto = txt_medicam.Text.ToUpper().Trim();
                string valor ="%"+ texto + "%";
                DataTable resultados = CRUD.buscar(valor, "medicamentos");
                lstb_resul_bus_medic.DataSource = resultados;
                lstb_resul_bus_medic.DisplayMember = "nombre";
                lstb_resul_bus_medic.ValueMember = "id";

            }
        }

        
    }
}
