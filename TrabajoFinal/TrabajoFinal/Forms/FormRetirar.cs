using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class FormRetirar : Form
    {
        public FormRetirar()
        {
            InitializeComponent();
        }

        int Numero;
        string Ubicacion;
        string tipo;
        double precio;
        Alquileres listalquileres;
        Movimientos listmov;
        Usuario user;
        Estacionamiento listaestacion;
        Alquiler alquiler;
        Cochera cochera;
        XMLAlquileres xmlalquiler = new XMLAlquileres();
        XMLMovimientos xmlmov = new XMLMovimientos();


        public FormRetirar(int numero, string ubicacion, Alquileres listalquiler, Movimientos listmovim, Usuario us, Estacionamiento listestacion)
        {
            InitializeComponent();
            Numero = numero;
            Ubicacion = ubicacion;
            this.listalquileres = listalquiler;
            this.listmov = listmovim;
            this.user = us;
            this.listaestacion = listestacion;
        }

        private void FormRetirar_Load(object sender, EventArgs e)
        {
            cochera= listaestacion.Buscar(Numero);
            alquiler= listalquileres.Buscar(Numero);
            txtdom.Text = alquiler.OCochera.OVehiculo.Dominio;
            txtdesde.Text = Convert.ToString(alquiler.Fecha);

            if ((alquiler.GetType()) == (typeof(AlquilerMes)))
            {
                tipo = "Mensual";
            }
            else
            {
                tipo = "Por Hora";
            }

            txtipoalq.Text = tipo;

            if (tipo == "Mensual")
            {
                txtvencim.Text = Convert.ToString(((AlquilerMes)alquiler).FechaVencimiento1);
            }
            else
            {
                txtvencim.Enabled = false;
                btnRenovar.Enabled = false;
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (tipo != "Mensual")
            {
                precio = alquiler.CalcularImporte();
                Movimiento mov = new Movimiento(tipo, precio, DateTime.Now, true, user, null);
                listmov.Agregar(mov);
                MessageBox.Show("IMPORTE A COBRAR: $ " + precio);
            }
            listalquileres.Borrar(Numero);
            listaestacion.desOcupar(Numero);
            //listaestacion.Borrar(cochera);
            xmlalquiler.Generar(listalquileres.Devolver());
            xmlmov.Generar(listmov.Devolver());
            MessageBox.Show("RETIRADO CORRECTAMENTE");
            this.Close();
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            listalquileres.Renovar(Numero);
            Movimiento mov = new Movimiento("Renovación", ((AlquilerMes)alquiler).CalcularImporte(), DateTime.Now, true, user, null);
            listmov.Agregar(mov);
            txtvencim.Text = Convert.ToString(((AlquilerMes)alquiler).FechaVencimiento1);
            xmlalquiler.Generar(listalquileres.Devolver());
            xmlmov.Generar(listmov.Devolver());
            MessageBox.Show("IMPORTE A COBRAR: $ " + Convert.ToString(((AlquilerMes)alquiler).CalcularImporte()));
            this.Close();
        }
    }
}
