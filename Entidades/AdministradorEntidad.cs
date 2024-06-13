﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AdministradorEntidad : UsuarioEntidad
    {
        public AdministradorEntidad(int id, string nombre, string apellido, long dni, string user, string contrasenia, string rol, string estado)
        : base(id, nombre, apellido, dni, user, contrasenia, rol, estado) { }
    }
}
