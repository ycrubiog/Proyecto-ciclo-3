using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WebAppAgendarCitas.Models
{
    public class ConexionDB
    {
        static private string CadenConexion = "Server=Lapto-Win;DataBase=ColegioApp;Integrated Security=True";

        private SqlConnection conexion = new SqlConnection(CadenConexion);

        public SqlConnection abrirConexion()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            return conexion;
        }


        public SqlConnection cerrarConexion()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return conexion;
        }
    }
}
