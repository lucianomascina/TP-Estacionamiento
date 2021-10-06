using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class AlquilerMes:Alquiler
    {
        private string titular;
        private DateTime FechaVencimiento;

        public string Titular
        {
            get
            {
                return titular;
            }

            set
            {
                titular = value;
            }
        }

        public DateTime FechaVencimiento1
        {
            get
            {
                return FechaVencimiento;
            }

            set
            {
                FechaVencimiento = value;
            }
        }

        public override double CalcularImporte()
        {
            return 750;
        }

        public AlquilerMes (string titular, DateTime fechavencimiento,DateTime fecha,Cochera ocochera):base (fecha,ocochera)
        {
            Titular = titular;
            FechaVencimiento = fechavencimiento;
        }

        public AlquilerMes()
        {
        }
    }
}
