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


        //Controlador Puestos
        public void insertarPuesto(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funInsertar(Id, Nombre, Estado, Ruta);
        }

        public void modificarPuesto(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funModificar(Id, Nombre, Estado, Ruta);
        }

        public void eliminarPuesto(string id)
        {
            sn.funEliminar(id);
        }


        //Controlador Empleados
        
        public void insertarEmpleado(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funInsertar(Id, Nombre, Estado, Ruta);
        }

        public void modificarEmpleado(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funModificar(Id, Nombre, Estado, Ruta);
        }

        public void eliminarEmpleado(string id)
        {
            sn.funEliminar(id);
        }
    }
}
