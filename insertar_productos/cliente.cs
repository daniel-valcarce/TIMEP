using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertar_productos
{
    class cliente
    {
        public string password 
                {
            get; 
            set; 
                }
        private int cedula
                {
            get;
            set;
                }
        private int id_usuario
                { 
            get;
            set; 
                }
        public string usuario 
                {
            get;
            set;
                }
        public string nombres
                {
            get;
            set;
                }
        public string apellidos
                {
            get;
            set;
                }

        public cliente() { }

        public cliente(int cedula, int id_usuario, string usuario, string apellidos, string nombres) {
            this.cedula = cedula;
            this.apellidos = apellidos;
            this.usuario = usuario;
            this.id_usuario = id_usuario;
            this.nombres = nombres;
        }
    }
   
}
