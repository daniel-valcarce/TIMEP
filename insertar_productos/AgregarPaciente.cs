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
    public partial class AgregarPaciente : Form
    {
        public Form form_anterio;
        public static DataTable medicamentos_enfermedades = null;
        public AgregarPaciente()
        {
            InitializeComponent();
        }
        private List<Control> obtenerControles(List<Control> controls)
        {
            List<Control> controles = new List<Control>();
            foreach (Control c in controls)
            {
                if (c.Controls.Count >= 1)
                {
                    controles.AddRange(obtenerControles(c.Controls.Cast<Control>().ToList()));
                }

                switch (c.GetType().Name.ToString())
                {
                    case "TextBox":
                    case "ComboBox":
                        controles.Add(c);
                        break;

                }
            }
            return controles;
        }

       

        private void btn_agegar_u_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtm_Pfechanaci.Text);
            pacientes paciente1 = new pacientes();
            paciente1.nombre = txb_Pnombre.Text;
            paciente1.primer_apellido = txb_Papellido1.Text;
            paciente1.segundo_apellido = txb_Papellido2.Text;
            paciente1.tipo_identificacion = Convert.ToString(cbx_Ptip_identi.Text);
            paciente1.numero_identificacion = float.Parse(txb_Pnumer_identi.Text);
            paciente1.telefono_fijo =int.Parse(txb_Ptelfijo.Text);
            paciente1.celular = float.Parse(txb_Pcell.Text);
            paciente1.id_ciudad = int.Parse(txb_Pciudad.Text);
            paciente1.id_barrios = int.Parse(txb_Pbarrio.Text);
            paciente1.direccion = txb_Pdirecc.Text;
            paciente1.fecha_nacimiento = Convert.ToDateTime(dtm_Pfechanaci.Text);
            paciente1.sexo = cbx_Psexo.Text;
            paciente1.numero_contacto = float.Parse(txb_Pnum_contac.Text);
            paciente1.nombre_contacto = txb_Pnom_contac.Text;
            int retorno = CRUD.agregarp(paciente1);
            if (retorno > 0)
            {
                if (MessageBox.Show("Paciente agreado correctamente", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    List<Control> controles = obtenerControles(this.Controls.Cast<Control>().ToList());
                    controles.ForEach(a => a.ResetText());
                    rtb_ti.Checked = false; rtb_cc.Checked = false; rtb_ce.Checked = false; rtb_pp.Checked = false;
                }
               // rtb_ti.Checked = false; rtb_cc.Checked = false; rtb_ce.Checked = false; rtb_pp.Checked = false;
               // MessageBox.Show("correcto");
                //List<Control> controles = obtenerControles(this.Controls.Cast<Control>().ToList());
                //controles.ForEach(a => a.ResetText());
                
            }
            else
            {
                MessageBox.Show("Verifica los datos insertados");
            }
        }

        private void cbx_Ptip_identi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rtb_ti_CheckedChanged(object sender, EventArgs e)
        {
            if (rtb_ti.Checked)
            {
                cbx_Ptip_identi.Text = "ti";
            }

        }

        private void rtb_cc_CheckedChanged(object sender, EventArgs e)
        {
            if (rtb_cc.Checked)
            {
                cbx_Ptip_identi.Text = "cc";
            }
        }

        private void rtb_ce_CheckedChanged(object sender, EventArgs e)
        {
            if (rtb_ce.Checked)
            {
                cbx_Ptip_identi.Text = "ce";
            }
        }

        private void rtb_pp_CheckedChanged(object sender, EventArgs e)
        {
            if (rtb_pp.Checked)
            {
                cbx_Ptip_identi.Text = "pp";
            }
        }

        private void apellido2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            medicamento_enfermedades form = new medicamento_enfermedades();
            form.form_anterio = this;
            form.form_anterio.Enabled = false;
            form.Show();

        }

        private void AgregarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form_anterio.Enabled = true;
            this.form_anterio.Show();
        }

        private void AgregarPaciente_EnabledChanged(object sender, EventArgs e)
        {
        if(AgregarPaciente.medicamentos_enfermedades != null){
            int filas = medicamentos_enfermedades.Rows.Count;
           // dataGridView1.DataSource = medicamentos_enfermedades;
                }
        }
    }
}
