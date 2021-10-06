using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Usuario
    {
        private string nombre;
        private string password;
        private DateTime ultacceso;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                 nombre= value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public DateTime Ultacceso
        {
            get
            {
                return ultacceso;
            }

            set
            {
                ultacceso = value;
            }
        }

        public Usuario(string nombre,string password,DateTime ultacceso)
        {
            Nombre = nombre;
            Password = password;
            Ultacceso = ultacceso;
        }

        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public Usuario()
        {
        }
    }
}
