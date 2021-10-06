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
    public partial class FormMovimientos : Form
    {
        public FormMovimientos()
        {
            InitializeComponent();
        }

        protected double[] caja = { 0, 0, 0 };
        Movimientos listmov;

        public FormMovimientos(Movimientos listmovim)
        {
            InitializeComponent();
            listmov = listmovim;
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listmov.MovimientosAbiertos();
            caja = listmov.Caja();
            txtIngresos.Text = Convert.ToString(caja[0]);
            txtEgresos.Text = Convert.ToString(caja[1]);
            txtTotal.Text = Convert.ToString(caja[2]);
        }
    }
}
