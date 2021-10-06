using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public abstract class Alquiler
    {
        private DateTime fecha;
        private Cochera ocochera;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Cochera OCochera
        {
            get
            {
                return ocochera;
            }

            set
            {
                ocochera = value;
            }
        }

        public abstract double CalcularImporte();

        public Alquiler (DateTime fecha,Cochera ocochera)
        {
            Fecha = fecha;
            OCochera = ocochera;
        }

        public Alquiler()
        { }
    }
}
