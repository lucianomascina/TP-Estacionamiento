using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Cierre
    {
        private DateTime fecha;
        private Usuario ousuario;

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

        public Usuario OUsuario
        {
            get
            {
                return ousuario;
            }

            set
            {
                ousuario = value;
            }
        }

        public Cierre (DateTime fecha,Usuario ousuario)
        {
            Fecha = fecha;
            OUsuario = ousuario;
        }

        public Cierre()
        {
        }

    }
}
