using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Usuario
        //tiene sublase gerente y administrador que heredan de usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private long _dni;
        private string _rol;
        private string _user;

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
        public Usuario()
        {
        }

        public Usuario(int Id, string nombre, string apellido, long dni, string user, string contrasenia, string rol)
        {
            this._id = Id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._user = user;
            this._contrasenia = contrasenia;
            this._rol = rol;
        }

        public List<Usuario> ListarUsuariosBase()
        {
            List<Usuario> usuarios = new List<Usuario>();
            DAL.UsuarioDAL usuarioDal = new DAL.UsuarioDAL();
            //Conexion conexion = new Conexion();

            DataTable miTabla = usuarioDal.UsuariosBase();

            foreach (DataRow fila in miTabla.Rows)
            {
                Usuario usuario = null;
                string rol = fila["Rol"].ToString();

                if (rol == "Gerente")
                {
                    usuario = new Gerente(
                        (int)fila["ID"],
                        fila["Nombre"].ToString(),
                        fila["Apellido"].ToString(),
                        (long)fila["DNI"],
                        fila["User"].ToString(),
                        fila["Contrasenia"].ToString(),
                        rol
                    );
                }
                else if (rol == "Administrador")
                {
                    usuario = new Administrador(
                        (int)fila["ID"],
                        fila["Nombre"].ToString(),
                        fila["Apellido"].ToString(),
                        (long)fila["DNI"],
                        fila["User"].ToString(),
                        fila["Contrasenia"].ToString(),
                        rol
                    );
                }
                else if (rol == "atencion_al_cliente")
                {
                    usuario = new AtencionAlCliente(
                        (int)fila["ID"],
                        fila["Nombre"].ToString(),
                        fila["Apellido"].ToString(),
                        (long)fila["DNI"],
                        fila["User"].ToString(),
                        fila["Contrasenia"].ToString(),
                        rol
                        );
                }
                else if (rol == "repositor")
                {
                    usuario = new Repositor(
                       (int)fila["ID"],
                       fila["Nombre"].ToString(),
                       fila["Apellido"].ToString(),
                       (long)fila["DNI"],
                       fila["User"].ToString(),
                       fila["Contrasenia"].ToString(),
                       rol
                       );
                }
                else if (rol == "cajero")
                {
                    usuario = new Repositor(
                       (int)fila["ID"],
                       fila["Nombre"].ToString(),
                       fila["Apellido"].ToString(),
                       (long)fila["DNI"],
                       fila["User"].ToString(),
                       fila["Contrasenia"].ToString(),
                       rol
                       );
                }
                if (usuario != null)
                {
                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }


        public abstract string ObtenerRol(string user, string password);

    }
}

