using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    public class Movimientos
    {
        public List<Movimiento> ListaMovimientos = new List<Movimiento>();

        public void Agregar(Movimiento m)
        {
            ListaMovimientos.Add(m);
        }

        public List<Movimiento> Devolver()
        {
            return ListaMovimientos;
        }

        public List<Movimiento> MovimientosAbiertos()
        {
            List<Movimiento> listaAbierta = new List<Movimiento>();
            foreach (Movimiento aux in Devolver())
            {
                if (aux.OCierre == null)
                {
                    listaAbierta.Add(aux);
                }
            }
            return listaAbierta;
        }

        public double[] Caja()
        {
            double[] caja = { 0, 0, 0 };
            foreach (Movimiento aux in MovimientosAbiertos())
            {
                if (aux.Esingreso == true)
                {
                    caja[0] += aux.Importe;
                }
                else
                {
                    caja[1] += aux.Importe;
                }
                caja[2] = caja[0] - caja[1];
            }
            return caja;
        }

        public void CerrarCaja(Cierre cierre)
        {
            foreach (Movimiento aux in Devolver())
            {
                if (aux.OCierre == null)
                {
                    aux.OCierre = cierre;
                }
            }
        }

        public bool Buscar()
        {
            bool ok = false;
            foreach (Movimiento m in ListaMovimientos)
            {

                if (m.OCierre == null)

                {
                    ok = true;
                }

            }
            return ok;
        }

        public Movimientos()
        { }

    }
}
