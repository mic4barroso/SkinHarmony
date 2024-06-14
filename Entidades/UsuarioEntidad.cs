using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class UsuarioEntidad
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private long _dni;
        private string _rol;
        private string _user;
        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _contrasenia;

        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public long DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        public UsuarioEntidad()
        {
        }

        public UsuarioEntidad(int Id, string nombre, string apellido, long dni, string user, string contrasenia, string rol, string elEstado)
        {
            this._id = Id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._user = user;
            this._contrasenia = contrasenia;
            this._rol = rol;
            this._estado = elEstado;
        }

    }
}
