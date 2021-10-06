using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Cierres
    {
        public List<Cierre> ListaCierres = new List<Cierre>();

        public void Agregar(Cierre c)
        {
            ListaCierres.Add(c);
        }

        public List<Cierre> Devolver()
        {
            return ListaCierres;
        }




    }
}
