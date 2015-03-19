using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertar_productos
{
    public class usuarios
    {
        public int id { get; set; }
        public int tipo_usuario { get; set; }
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string tipo_identificacion { get; set; }
        public double numero_identificacion { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string cargo { get; set; }


        public usuarios() { }

        public usuarios( int ptipo_usuario, string pnombre, string pprimer_apellido, string psegundo_apellido, string ptipo_identificacion, double pnumero_identificacion,string pemail, string ppassword, string pcargo)
        { 
            
            this.tipo_usuario = ptipo_usuario;
            this.nombre = pnombre;
            this.primer_apellido = pprimer_apellido;
            this.segundo_apellido = psegundo_apellido;
            this.tipo_identificacion = ptipo_identificacion;
            this.numero_identificacion = pnumero_identificacion;
            this.email = pemail;
            this.password = ppassword;
            this.cargo = pcargo;
        
        }
    }
}
