using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //Administrador hereda de Usuario que es una CLASE ABSTRACTA
    public class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string apellido, long dni, string user, string contrasenia, string rol)
        : base(id, nombre, apellido, dni, user, contrasenia, rol) { }

        public override string ObtenerRol(string user, string password)
        {
            return "administrador";
        }
    }
}

