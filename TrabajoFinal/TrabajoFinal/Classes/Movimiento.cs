using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Movimiento
    {
        private string concepto;
        private double importe;
        private DateTime fecha;
        private bool esingreso;
        private Usuario ousuario;
        private Cierre ocierre;

        public string Concepto
        {
            get
            {
                return concepto;
            }

            set
            {
                concepto = value;
            }
        }

        public double Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

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

        public bool Esingreso
        {
            get
            {
                return esingreso;
            }

            set
            {
                esingreso = value;
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

        public Cierre OCierre
        {
            get
            {
                return ocierre;
            }

            set
            {
                ocierre = value;
            }
        }

        public Movimiento(string concepto,double importe,DateTime fecha,bool esingreso,Usuario ousuario,Cierre ocierre)
        {
            Concepto = concepto;
            Importe = importe;
            Fecha = fecha;
            Esingreso = esingreso;
            OUsuario = ousuario;
            OCierre = ocierre;
        }

        public Movimiento()
        { }

    }
}
