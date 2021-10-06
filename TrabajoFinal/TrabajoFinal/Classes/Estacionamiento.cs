using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Estacionamiento
    {
        private string nombre;
        public List<Cochera> ListaCocheras = new List<Cochera>();

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public void Agregar(Cochera c)
        {
            ListaCocheras.Add(c);
        }

        public List<Cochera> Devolver()
        {
            return ListaCocheras;
        }

        public void Borrar(Cochera c)
        {
            ListaCocheras.Remove(c);
        }

        public Cochera Buscar(int n)
        {
            Cochera aux = null;
            foreach(Cochera c in ListaCocheras)
            {
                if(c.Numero==n)
                {
                    aux=c;
                }
            }
            return aux;
        }

        public void Ocupar(int n)
        {
            foreach (Cochera c in ListaCocheras)
            {
                if(c.Numero==n)
                c.Estado = false;
            }
        }

        public void desOcupar(int n)
        {
            foreach (Cochera c in ListaCocheras)
            {
                if (c.Numero == n)
                    c.Estado = true;
            }
        }

        public bool Existe(Vehiculo v)
        {
            bool existe = false;
            foreach (Cochera aux in ListaCocheras)
            {
                if (aux.OVehiculo != null)
                {
                    if (aux.OVehiculo.Dominio == v.Dominio)
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }

        public Estacionamiento(string nombre)
        {
            Nombre = nombre;
        }


    }
}
