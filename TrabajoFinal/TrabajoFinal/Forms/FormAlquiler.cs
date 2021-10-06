using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabajoFinal
{
    public partial class FormAlquiler : Form
    {
        public FormAlquiler()
        {
            InitializeComponent();
        }

        int Numero;
        string Ubicacion;
        Alquileres listalquileres;
        Movimientos listmov;
        Usuario user;
        Estacionamiento listaestacion;
        XMLAlquileres xmlalqui = new XMLAlquileres();
        XMLMovimientos xmlmov = new XMLMovimientos();

        public FormAlquiler(int numero,string ubicacion,Alquileres listalquiler,Movimientos listmovim,Usuario us,Estacionamiento listestacion)
        {
            InitializeComponent();
            Numero = numero;
            Ubicacion = ubicacion;
            this.listalquileres = listalquiler;
            this.listmov = listmovim;
            this.user = us;
            this.listaestacion = listestacion;
           
        }


        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            mtbFecha.Text = Convert.ToString(DateTime.Now);
        }

        public bool chequear()
        {
            bool ok = false;
            if (rbMensual.Checked)
            {
                if (mskDominio.Text != "" && txtMarca.Text != "" && txtModelo.Text != "" && txtTitular.Text != "")
                { ok = true; }
            }
            else
            {
                if (mskDominio.Text != "" && txtMarca.Text != "" && txtModelo.Text != "")
                { ok = true; }
            }
            return ok;
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            string dominio = mskDominio.Text.ToUpper(); ;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string codigo="";
            string descripcion="";
            string titular = "";

            if(rbMoto.Checked)
            {
                codigo = "1";
                descripcion = "Moto";
            }
            if (rbAuto.Checked)
            {
                codigo = "2";
                descripcion = "Auto";
            }
            if (rbPickup.Checked)
            {
                codigo = "3";
                descripcion = "Pickup";
            }

            TipoVehiculo tipo = new TipoVehiculo(codigo,descripcion);

            if(chequear())
            {
                Vehiculo v = new Vehiculo(dominio, marca, modelo, tipo);
                if (!listaestacion.Existe(v))
                {

                    Cochera c = new Cochera(Numero, Ubicacion, false, v);
                    listaestacion.Ocupar(Numero);
                    listaestacion.Agregar(c);
                    if (rbMensual.Checked)
                    {
                        titular = txtTitular.Text;
                        AlquilerMes almes = new AlquilerMes(titular, DateTime.Now.AddMonths(Convert.ToInt32(numMeses.Value)), DateTime.Now, c);
                        Movimiento m = new Movimiento("alquiler mensual", almes.CalcularImporte() * Convert.ToInt32(numMeses.Value), DateTime.Now, true, user, null);
                        listmov.Agregar(m);
                        listalquileres.Agregar(almes);
                        xmlalqui.Generar(listalquileres.Devolver());
                        xmlmov.Generar(listmov.Devolver());
                        MessageBox.Show("IMPORTE A COBRAR: " + almes.CalcularImporte() * Convert.ToInt32(numMeses.Value));
                        this.Close();
                    }
                    if (rbPorhora.Checked)
                    {
                        AlquilerHora alhora = new AlquilerHora(DateTime.Now, DateTime.Now, DateTime.Now, c);
                        listalquileres.Agregar(alhora);
                        xmlalqui.Generar(listalquileres.Devolver());
                        MessageBox.Show("Cargado correctamente");
                        this.Close();
                    }
              
                }
                else
                {
                    MessageBox.Show("El vehiculo está en otra cochera");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }

        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            txtTitular.Visible = true;
            lblTitular.Visible = true;
            lblMeses.Visible = true;
            numMeses.Visible = true;
        }

        private void rbPorhora_CheckedChanged(object sender, EventArgs e)
        {
            txtTitular.Visible = false;
            lblTitular.Visible = false;
            lblMeses.Visible = false;
            numMeses.Visible = false;
        }
    }
}
