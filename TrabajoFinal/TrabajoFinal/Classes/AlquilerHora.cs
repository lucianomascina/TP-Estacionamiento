using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class AlquilerHora:Alquiler
    {
        private DateTime desde;
        private DateTime hasta;

        public DateTime Desde
        {
            get
            {
                return desde;
            }

            set
            {
                desde = value;
            }
        }

        public DateTime Hasta
        {
            get
            {
                return hasta;
            }

            set
            {
                hasta = value;
            }
        }

        public override double CalcularImporte()
        {
            TimeSpan tiempo = hasta.Subtract(desde);
            double hora = tiempo.Hours;
            double minutos = tiempo.Minutes;
            double importe = 0;

            if(minutos>15)
            {
                hora += 1;
            }

            switch(Convert.ToInt32(OCochera.OVehiculo.OTipovehiculo.Codigo))
            {
                case 1:
                    importe = hora * 10;
                    break;
                case 2:
                    importe = hora * 20;
                    break;
                case 3:
                    importe = hora * 35;
                    break;
            }
            return importe;
        }

        public AlquilerHora(DateTime desde,DateTime hasta,DateTime fecha,Cochera ocochera):base(fecha,ocochera)
        {
            Desde = desde;
            Hasta = hasta;
        }

        public AlquilerHora()
        {
        }
    }
}
