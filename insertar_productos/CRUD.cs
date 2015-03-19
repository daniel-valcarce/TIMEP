using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace insertar_productos
{
   public class CRUD
    {
        public static int agregaru(usuarios usuario1)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuarios(tipo_usuario, nombre, primer_apellido, segundo_apellido, tipo_identificacion, numero_identificacion, password , cargo, email) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
               usuario1.tipo_usuario, usuario1.nombre, usuario1.primer_apellido, usuario1.segundo_apellido, usuario1.tipo_identificacion, usuario1.numero_identificacion, usuario1.password, usuario1.cargo, usuario1.email), bdComun.ObtenerConexion());
            try
            {
                retorno = comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
            return 0;
            }
            return retorno;
        }
        public static int agregarp(pacientes paciente1)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO pacientes(nombre, primer_apellido, segundo_apellido, tipo_documento, numero_identificacion,telefono_fijo,celular,ciudad_id,barrio_id,direccion,fecha_nacimiento,sexo,numero_contacto,nombre_contacto) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
               paciente1.nombre, paciente1.primer_apellido, paciente1.segundo_apellido, paciente1.tipo_identificacion, paciente1.numero_identificacion,paciente1.telefono_fijo,paciente1.celular,paciente1.id_ciudad,paciente1.id_barrios,paciente1.direccion,paciente1.fecha_nacimiento,paciente1.sexo,paciente1.numero_contacto,paciente1.nombre_contacto), bdComun.ObtenerConexion());
            try
            {
                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
            return retorno;
        }
        public static DataTable ingresar(string usuario, string password)
        {   
                MySqlDataAdapter lector = new MySqlDataAdapter(string.Format("SELECT * FROM usuarios WHERE numero_identificacion='{0}' and password='{1}'", usuario, password), bdComun.ObtenerConexion());                
                DataTable tabla = new DataTable();
                lector.Fill(tabla);
                return tabla;
        }
          public static DataTable todos(string tabla_mysql) {
            MySqlDataAdapter lector = new MySqlDataAdapter(string.Format("SELECT * FROM {0}", tabla_mysql), bdComun.ObtenerConexion());
            DataTable tabla = new DataTable();
            lector.Fill(tabla);
            return tabla;
        }

          public static DataTable selec1(int dit)
          {
              MySqlDataAdapter lector = new MySqlDataAdapter(string.Format("SELECT * FROM usuarios WHERE numero_identificacion='{0}'", dit), bdComun.ObtenerConexion());
              DataTable tabla = new DataTable();
              lector.Fill(tabla);

              return tabla;
          }


        public static DataTable todos(int dit)
        {
            MySqlDataAdapter lector = new MySqlDataAdapter(string.Format("SELECT nombre, primer_apellido, segundo_apellido, tipo_identificacion, numero_identificacion, cargo FROM usuarios WHERE numero_identificacion='{0}'", dit), bdComun.ObtenerConexion());
            DataTable tabla = new DataTable();
            lector.Fill(tabla);

            return tabla;
        }
        public static DataTable todos1(int dit1)
        {
            MySqlDataAdapter lector = new MySqlDataAdapter(string.Format("SELECT nombre, primer_apellido, segundo_apellido, tipo_identificacion, numero_identificacion,telefono_fijo,celular,id_ciudad,id_barrios,direccion,fecha_nacimiento,sexo,numero_contacto,nombre_contacto FROM pacientes WHERE numero_identificacion='{0}'", dit1), bdComun.ObtenerConexion());
            DataTable tabla1 = new DataTable();
            lector.Fill(tabla1);

            return tabla1;
        }
        public static int eliminar(int dato)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE from usuarios where numero_identificacion='{0}'",  dato), bdComun.ObtenerConexion());
            try
            {
                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
            return retorno;
        }
        public static int eliminarp(int dato)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE from pacientes where numero_identificacion='{0}'", dato), bdComun.ObtenerConexion());
            try
            {
                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
            return retorno;
        }
        public static DataTable todos()
        {
            MySqlDataAdapter lector = new MySqlDataAdapter(string.Format("SELECT * FROM usuarios"), bdComun.ObtenerConexion());
            DataTable tabla = new DataTable();
            lector.Fill(tabla);

            return tabla;
        }



        internal static int actualizar_user(usuarios usuario)
        {
            int retorno;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE usuarios SET tipo_usuario='{0}',nombre='{1}',primer_apellido='{2}',segundo_apellido='{3}',tipo_identificacion='{4}',numero_identificacion='{5}',password='{6}',cargo='{7}',email='{8}' WHERE numero_identificacion='{9}'",usuario.tipo_usuario, usuario.nombre,usuario.primer_apellido, usuario.segundo_apellido, usuario.tipo_identificacion, usuario.numero_identificacion, usuario.password, usuario.cargo, usuario.email, usuario.id), bdComun.ObtenerConexion());
            try
            {
                retorno = comando.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                return 0;
            }
            return retorno;  
        }
        public static DataTable buscar( string valor, string tabla_sele)
        {
            
            MySqlDataAdapter lector = new MySqlDataAdapter(string.Format("SELECT * FROM {0} WHERE  nombre like '{1}'",tabla_sele ,valor), bdComun.ObtenerConexion());
            DataTable tabla = new DataTable();
            lector.Fill(tabla);
            return tabla;
       }
    }

}
