using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Usuarios
    {
        List<Usuario> ListaUsuarios = new List<Usuario>();

        public void Agregar(Usuario u)
        {
            ListaUsuarios.Add(u);
        }

        public bool Buscar(string nombre,string password)
        {

            bool encontro = false;
            foreach(Usuario u in ListaUsuarios)
            {
                if((u.Nombre==nombre)&&(u.Password==password))
                {
                    encontro= true;        
                }
                else
                {
                    encontro= false;
                }
            }
            return encontro;
        }

        public bool Buscarpornombre(string nombre)
        {

            bool encontro = false;
            foreach (Usuario u in ListaUsuarios)
            {
                if (u.Nombre == nombre)
                {
                    encontro = true;
                }
                else
                {
                    encontro = false;
                }
            }
            return encontro;
        }
        public Usuarios()
        {

        }


    }
}
