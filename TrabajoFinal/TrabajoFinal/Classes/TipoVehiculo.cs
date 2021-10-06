using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class TipoVehiculo
    {
        private string codigo;
        private string descripcion;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public TipoVehiculo(string codigo,string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }

        public TipoVehiculo()
        {
        }
    }
}
