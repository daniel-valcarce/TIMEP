using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace insertar_productos
{
    public partial class Logeo : Form
    {
        public Logeo()
        {

            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            DataTable datos = CRUD.ingresar(txt_usuario.Text, txt_password.Text);

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("Usuario no existe o contraseña equivocada");
            }
            else
            {
                DataTable todos = CRUD.todos("usuarios");
                DataRow tipo_user = datos.Rows[0];
                int valor_tip_user = int.Parse(tipo_user["tipo_usuario"].ToString());
                if (valor_tip_user == 1)
                {
                    Inicioadmin  hide = new Inicioadmin();
                    hide.Show();
                    hide.cargar(todos);
                    this.Hide();
                }
                if (valor_tip_user == 2)
                {
                    DataTable todos_pacientes = CRUD.todos("pacientes");
                    Inicioadmisalud ver = new Inicioadmisalud();
                    ver.Show();
                    ver.cargar(todos_pacientes);
                    this.Hide();
                }
                if (valor_tip_user == 3)
                {
                    DataTable todos_pacientes = CRUD.todos("pacientes");
                    Iniciomedico ver = new Iniciomedico();
                    ver.Show();
                    ver.cargar(todos_pacientes);
                    this.Hide();
                }
                if (valor_tip_user == 4)
                {
                    DataTable todos_pacientes = CRUD.todos("pacientes");
                    Inicionurse ver = new Inicionurse();
                    ver.Show();
                    this.Hide();

                }
                if (valor_tip_user == 5)
                {
                    DataTable todos_pacientes = CRUD.todos("pacientes");
                    InicioParamedico ver = new InicioParamedico();
                    ver.Show();
                    this.Hide();

                }
            }
        }

     

       
    }
}
