using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {
        private Conexion cn = new Conexion();

        public void funInsertar(string Id, string Nombre, int estado, string ruta)
        {
            string cadena = "INSERT INTO" +
            " `componenteseguridad`.`Aplicacion` VALUES (" + "'" + Id + "', '" + Nombre + "' , " + estado + ", '" + ruta + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funModificar(string Id, string Nombre, int estado, string ruta)
        {
            string cadena = "UPDATE componenteseguridad.aplicacion set pkId ='" + Id
              + "',nombre ='" + Nombre + "',estado = " + estado + ", idReporteAsociado = '" + ruta + "'  where pkId= '" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funEliminar(string Id)
        {
            string cadena = "delete from componenteseguridad.aplicacion where pkId ='" + Id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
    }
}
