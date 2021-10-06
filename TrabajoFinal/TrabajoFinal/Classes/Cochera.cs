using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Cochera
    {
        private int numero;
        private string ubicacion;
        private bool estado;
        private Vehiculo ovehiculo;
 

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }

            set
            {
                ubicacion = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public Vehiculo OVehiculo
        {
            get
            {
                return ovehiculo;
            }

            set
            {
                ovehiculo = value;
            }
        }

        public Cochera(int numero,string ubicacion,bool estado,Vehiculo ovehiculo)
        {
            Numero = numero;
            Ubicacion = ubicacion;
            Estado = estado;
            OVehiculo = ovehiculo;
        }

        public Cochera()
        {
        }

        public Cochera(int numero, string ubicacion, Vehiculo ovehiculo)
        {
            Numero = numero;
            Ubicacion = ubicacion;
            OVehiculo = ovehiculo;
        }
    }
}
