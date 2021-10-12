using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace WebAppAgendarCitas.Models
{
    public class clsAgendarCita
    {

        private ConexionDB conexion = new ConexionDB();
        private SqlCommand comando = new SqlCommand();
        private SqlDataAdapter leerFilas;
    
    
    
        public void registrarPaciente(string cedula,string nombre,string correo,string edad,int IdProfesores,int IdMateria)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "registrarEstudiante";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.Parameters.AddWithValue("@Nombre",nombre);
            comando.Parameters.AddWithValue("@Correo",correo);
            comando.Parameters.AddWithValue("@Edad",edad);
            comando.Parameters.AddWithValue("@IdProfesores",IdProfesores);
            comando.Parameters.AddWithValue("@IdMateria", IdMateria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    
    
    }


}
