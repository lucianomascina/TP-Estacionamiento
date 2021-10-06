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
    public partial class FormCierre : Form
    {
        public FormCierre()
        {
            InitializeComponent();
        }

        protected double[] caja = { 0, 0, 0 };
        Movimientos listmov;
        Usuario usua;
        Cierres listcie;
        XMLCierres archivocierres = new XMLCierres();
        XMLMovimientos archivomov = new XMLMovimientos();

        public FormCierre(Movimientos listmovim,Usuario us,Cierres listcierre)
        {
            InitializeComponent();
            listmov = listmovim;
            usua= us;
            listcie = listcierre;
        }

        private void FormCierre_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listmov.MovimientosAbiertos();
 
            caja = listmov.Caja();
            txtIngresos.Text = Convert.ToString(caja[0]);
            txtEgresos.Text = Convert.ToString(caja[1]);
            txtTotal.Text = Convert.ToString(caja[2]);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { 
            if (listmov.Buscar())
            {
                Cierre cierre = new Cierre(DateTime.Now, usua);
                listcie.Agregar(cierre);
                listmov.CerrarCaja(cierre);
                archivocierres.Generar(listcie.Devolver());
                //archivomov.Generar(listmov.Devolver());
                MessageBox.Show("La caja se cerró correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay movimientos para realizar el cierre");

            }
        }
    
    }
}
