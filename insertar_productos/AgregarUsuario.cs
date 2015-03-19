using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertar_productos
{
    public partial class AgregarUsuario : Form
    {
        public string accion;
        public Form formAnterior;
        public int id;
        private string cedula;
        public AgregarUsuario(string titulo, DataTable datos)
        {

            InitializeComponent();
            lbl_titulo.Text = titulo;
            DataRow fila = datos.Rows[0];
            btn_agre_u.Text="Actualizar";
            txt_nombre.Text =fila["nombre"].ToString();
            txt_1apell.Text = fila["primer_apellido"].ToString();
            txt_2apell.Text= fila["segundo_apellido"].ToString();
            cmb_tipodoc.Text= fila["tipo_identificacion"].ToString();
            txt_numidenti.Text = fila["numero_identificacion"].ToString();
            cedula = fila["numero_identificacion"].ToString();
            txt_pass.Text = fila["password"].ToString();
            txt_confpass.Text = fila["password"].ToString();
            txb_email.Text = fila["email"].ToString();
            if (fila["tipo_usuario"].ToString() == "1")
            {
                cmb_tipous.Text = "Admisitrador de sistema";
            }
            if (fila["tipo_usuario"].ToString() == "2")
            {
                cmb_tipous.Text = "Admisitrador de salud";
            }
            if (fila["tipo_usuario"].ToString() == "3")
            {
                cmb_tipous.Text = "Medico";
            }
            if (fila["tipo_usuario"].ToString() == "4")
            {
                
                cmb_tipous.Text = "Enfermera(o)";
            }
            if (fila["tipo_usuario"].ToString() == "5")
            {
                cmb_tipous.Text= "Parmamedico";
            }
            txt_ocupacion.Text = fila["cargo"].ToString();
        }

        public AgregarUsuario(string titulo)
        {

            InitializeComponent();
            lbl_titulo.Text = titulo;
        }
        public usuarios usuarioactual { get; set; }


     
        private void btn_insert_prod_Click(object sender, EventArgs e)
        {
            usuarios usuario1 = new usuarios();
            
            if (txt_confpass.Text == txt_pass.Text)
            {

               
                lblmsg.Hide();
                if (txt_nombre.Text != string.Empty && txt_1apell.Text != string.Empty && txt_2apell.Text != string.Empty && cmb_tipodoc.Text != string.Empty && txt_numidenti.Text != string.Empty && txt_pass.Text != string.Empty && txb_email.Text != string.Empty && txt_ocupacion.Text != string.Empty)
                {
                    string formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                    if (Regex.IsMatch(txb_email.Text, formato))
                    {
                        if (cmb_tipous.Text == "Admisitrador de sistema")
                        {
                            cmb_tipous.Text = "1";
                        }
                        if (cmb_tipous.Text == "Admisitrador de salud")
                        {
                            cmb_tipous.Text = "2";
                        }
                        if (cmb_tipous.Text == "Medico")
                        {
                            cmb_tipous.Text = "3";
                        }
                        if (cmb_tipous.Text == "Enfermera(o)")
                        {
                            cmb_tipous.Text = "4";
                        }
                        if (cmb_tipous.Text == "Parmamedico")
                        {
                            cmb_tipous.Text = "5";
                        }


                        //string formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                        //if (Regex.IsMatch(txt_nombre.Text, formato))
                        //{
                        usuario1.tipo_usuario = int.Parse(cmb_tipous.Text);
                        usuario1.nombre = txt_nombre.Text;
                        usuario1.primer_apellido = txt_1apell.Text;
                        usuario1.segundo_apellido = txt_2apell.Text;
                        usuario1.tipo_identificacion = Convert.ToString(cmb_tipodoc.Text);
                        usuario1.numero_identificacion = Convert.ToDouble(txt_numidenti.Text);
                        usuario1.password = txt_pass.Text;
                        usuario1.email = txb_email.Text;
                        usuario1.cargo = txt_ocupacion.Text;
                        if(accion=="Actualizar"){
                            usuario1.id = id;
                            if( txt_numidenti.Text != cedula){
                                if (MessageBox.Show("Va a Cambiar el numero de Cedula, ¿Esta Seguro?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                {
                                    int retorno_up = CRUD.actualizar_user(usuario1);
                                    if (retorno_up > 0)
                                    {
                                        MessageBox.Show("Usuario actualizado corectamente");
                                        this.Refresh();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Verifica los datos insertados para actualizar");
                                        return;
                                    }
                                }
                                else
                                {
                                    return;
                                }
                        }
                        }
                        int retorno = CRUD.agregaru(usuario1);
                        if (retorno > 0)
                        {
                            MessageBox.Show("Usuario agregado corectamente");
                         
                        }
                        else
                        {
                            MessageBox.Show("Verifica los datos insertados");
                        }


                        //  if (Regex.Replace(txt_nombre.Text, sFormato, String.Empty).Length == 0)
                        //{
                        //  MessageBox.Show("Bien");
                        //}
                        //else
                        //{
                        //   MessageBox.Show("Bien mal");
                        //}
                        // }
                    }
                    else
                    {
                        MessageBox.Show("El Correo NO tiene el Formato Correcto");
                    }
                   // else
                    //{
                      //  MessageBox.Show("Mal escrito el Correo");
                    //}
                }

                else
                {
                    MessageBox.Show("Faltan Datos, Verifica!! ");
                }
                }

            else
            {
                MessageBox.Show("Las Contraseñas no Coinciden");

            }
            
            

        }

        private void cmb_tipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confpass_TextChanged(object sender, EventArgs e)
        {




        }

        private void cmb_tipous_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_confpass_Leave(object sender, EventArgs e)
        {
            if (txt_confpass.Text == txt_pass.Text)
            {
                lblmsg.Hide();
            }

            else
            {
                lblmsg.Show();
                
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void AgregarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AgregarUsuario_FormClosed_1(object sender, FormClosedEventArgs e)
        {
           
            formAnterior.Enabled = true;
            
        }

        private void txt_confpass_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
