using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        public void insertarAplicacion(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funInsertar(Id, Nombre, Estado, Ruta);
        }

        public void modificarAplicacion(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funModificar(Id, Nombre, Estado, Ruta);
        }

        public void eliminarAplicacion(string id)
        {
            sn.funEliminar(id);
        }
    }
}
