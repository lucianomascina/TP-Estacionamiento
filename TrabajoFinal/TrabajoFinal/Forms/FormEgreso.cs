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
    public partial class FormEgreso : Form
    {
        public FormEgreso()
        {
            InitializeComponent();
        }
        Movimientos listmov;
        Usuario us;
        XMLMovimientos xmlmov = new XMLMovimientos();

        public FormEgreso(Movimientos listmovim,Usuario user)
        {
            InitializeComponent();
            this.listmov = listmovim;
            this.us = user;
        }


        private void btnEgreso_Click(object sender, EventArgs e)
        {
            double importe;

            if (!double.TryParse(txtImporte.Text, out importe))
            {
                MessageBox.Show("Debe ingresar un número");
            }
            else
            {
                if (!string.IsNullOrEmpty(txtConcepto.Text) && !string.IsNullOrEmpty(txtImporte.Text))
                {
                    string concepto = txtConcepto.Text;
                    importe = Convert.ToDouble(txtImporte.Text);

                    Movimiento m = new Movimiento(concepto, importe, DateTime.Now, false, us, null);
                    listmov.Agregar(m);
                    xmlmov.Generar(listmov.Devolver());
                    MessageBox.Show("Egreso cargado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            
        }

        private void FormEgreso_Load(object sender, EventArgs e)
        {

        }
    }
}
