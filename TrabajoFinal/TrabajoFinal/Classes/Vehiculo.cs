using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Vehiculo
    {
        private string dominio;
        private string marca;
        private string modelo;
        private TipoVehiculo otipovehiculo;

        public string Dominio
        {
            get
            {
                return dominio;
            }

            set
            {
                dominio = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public TipoVehiculo OTipovehiculo
        {
            get
            {
                return otipovehiculo;
            }

            set
            {
                otipovehiculo = value;
            }
        }

        public Vehiculo(string dominio,string marca,string modelo,TipoVehiculo otipovehiculo)
        {
            Dominio = dominio;
            Marca = marca;
            Modelo = modelo;
            OTipovehiculo = otipovehiculo;
        }

        public Vehiculo()
        {
        }
    }
}
