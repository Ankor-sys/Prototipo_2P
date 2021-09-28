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


        //Sentencias sn = new Sentencias();
        //Controlador Puestos

        public void insertarPuesto(string Id, string Nombre, int Estado)
        {
          //sn.funInsertarPuesto(Id, Nombre, Estado);
        }

        public void modificarPuesto(string Id, string Nombre, int Estado)
        {
           // sn.funModificarP(Id, Nombre, Estado);
        }

        public void eliminarPuesto(string id)
        {
           // sn.funEliminarP(id);
        }

        //Controlador Empleados

        public void insertarEmpleado(string Id, string Nombre, string puesto, string departamento, float sueldo, string status) 
        {
            //sn.funInsertarE(Id, Nombre, puesto, departamento, sueldo, status);
        }

        public void modificarEmpleado(string Id, string Nombre, string puesto, string departamento, float sueldo, string status)
        {
            //sn.funModificarE(Id, Nombre, puesto, departamento, sueldo, status);
        }

        public void eliminarEmpleado(string id)
        {
           // sn.funEliminarE(id);
        }
    }
}
