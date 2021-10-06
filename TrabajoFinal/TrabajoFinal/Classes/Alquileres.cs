using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Alquileres
    {
        public List<Alquiler> ListaAlquileres = new List<Alquiler>();

        public void Agregar(Alquiler a)
        {
            ListaAlquileres.Add(a);
        }

        public List<Alquiler> Devolver()
        {
            return ListaAlquileres;
        }

        public Alquiler Buscar(int num)
        {
            Alquiler a = null;
            foreach (Alquiler aux in ListaAlquileres)
            {
                if (aux.OCochera.Numero == num)
                {
                    a = aux;
                }
            }
            return a;
        }

        public void Borrar(int num)
        {
            Alquiler alquiler = Buscar(num);
            if (alquiler != null)
            {
                foreach (Alquiler aux in ListaAlquileres)
                {
                    if (aux.OCochera.Numero == num)
                    {
                        ListaAlquileres.Remove(aux);
                    }
                    break;
                }
            }
        }

        public void Renovar(int num)
        {
            foreach (Alquiler aux in ListaAlquileres)
            {
                if (aux.GetType() == typeof(AlquilerMes))
                {
                    if (((AlquilerMes)aux).OCochera.Numero == num)
                    {
                        ((AlquilerMes)aux).FechaVencimiento1 = ((AlquilerMes)aux).FechaVencimiento1.AddMonths(1);
                    }
                }
            }
        }

        public Alquileres()
        {

        }
    }
}
