using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insertar_productos
{
    public class pacientes
    {
        
        public int id { get; set; }       
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string tipo_identificacion { get; set; }
        public float numero_identificacion { get; set; }
        public int telefono_fijo { get; set; }
        public float celular { get; set; }
        public int id_ciudad { get; set; }
        public int id_barrios { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_nacimiento {get; set; }
        public string sexo { get; set; }
        public float numero_contacto { get; set; }
        public string nombre_contacto { get; set; }

        public pacientes() { }

        public pacientes(string pnombre, string pprimer_apellido, string psegundo_apellido, string ptipo_identificacion, float pnumero_identificacion,int ptelefono_fijo, float pcelular,int pid_ciudad,int pid_barrios,string pdireccion, DateTime pfecha_nacimiento,string psexo, float pnumero_contacto, string pnombre_contacto)
        {             
            this.nombre = pnombre;
            this.primer_apellido = pprimer_apellido;
            this.segundo_apellido = psegundo_apellido;
            this.tipo_identificacion = ptipo_identificacion;
            this.numero_identificacion = pnumero_identificacion;
            this.telefono_fijo=ptelefono_fijo;
            this.celular= pcelular;
            this.id_ciudad=pid_ciudad;
            this.id_barrios=pid_barrios;
            this.direccion=pdireccion;
            this.fecha_nacimiento=pfecha_nacimiento;
            this.sexo=psexo;
            this.numero_contacto=pnumero_contacto;
            this.nombre_contacto=pnombre_contacto;
        }
    }
 }

