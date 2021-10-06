using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabajoFinal
{
    public partial class FormPrincipal : Form
    {
        Usuarios listausuarios;
        Usuario us;
        Estacionamiento listestacion = new Estacionamiento("");
        Alquileres listalquiler = new Alquileres();
        Movimientos listmovim = new Movimientos();
        Cierres listcierres = new Cierres();
        XMLAlquileres archivoalqui = new XMLAlquileres();
        XMLCierres archivocierre = new XMLCierres();
        XMLMovimientos archivomovim = new XMLMovimientos();
        

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(Usuarios listausuarios,Usuario user)
        {
            InitializeComponent();
            this.listausuarios=listausuarios;
            us = user;
        }

        public void CambiarColores(int num, Button btn)
        {
            Cochera c;
            c = listestacion.Buscar(num);
            if (c.Estado)
            {
                btn.BackColor = System.Drawing.Color.Chartreuse;
            }
            else
            {
                btn.BackColor = System.Drawing.Color.OrangeRed;
            }
        }

        public void Actualizar()
        {
            for (int i = 1; i <= 20; i++)
            {
                Cochera c = new Cochera(i, "",true, null);
                foreach(Alquiler a in listalquiler.Devolver())
                {
                    if (a.OCochera.Numero == i)
                        c.Estado = false;
                }
                listestacion.Agregar(c);
                Button b = (Button)this.Controls.Find("button" + i, false)[0];
                CambiarColores(i, b);
            }
        }

        public void CargaArchivos()
        {
            foreach (Alquiler a in archivoalqui.Obtener())
            {
                listalquiler.Agregar(a);
            }
            foreach (Cierre c in archivocierre.Obtener())
            {
                listcierres.Agregar(c);
            }
            foreach (Movimiento m in archivomovim.Obtener())
            {
                listmovim.Agregar(m);
            }
        }


        private void ESTACIONAMIENTO_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = us.Nombre;

            CargaArchivos();
            Actualizar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = Convert.ToString(DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(listestacion.Buscar(1).Estado)
            {
                FormAlquiler fa = new FormAlquiler(1, "Planta Baja",listalquiler,listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(1, button1);
            }
           else
            {
                FormRetirar re = new FormRetirar(1, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(1, button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(2).Estado)
            {
                FormAlquiler fa = new FormAlquiler(2, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(2, button2);
            }
            else
            {
                FormRetirar re = new FormRetirar(2, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(2, button2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(3).Estado)
            {
                FormAlquiler fa = new FormAlquiler(3, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(3, button3);
            }
            else
            {
                FormRetirar re = new FormRetirar(3, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(3, button3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(4).Estado)
            {
                FormAlquiler fa = new FormAlquiler(4, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(4, button4);
            }
            else
            {
                FormRetirar re = new FormRetirar(4, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(4, button4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(5).Estado)
            {
                FormAlquiler fa = new FormAlquiler(5, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(5, button5);
            }
            else
            {
                FormRetirar re = new FormRetirar(5, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(5, button5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(6).Estado)
            {
                FormAlquiler fa = new FormAlquiler(6, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(6, button6);
            }
            else
            {
                FormRetirar re = new FormRetirar(6, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(6, button6);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(7).Estado)
            {
                FormAlquiler fa = new FormAlquiler(7, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(7, button7);
            }
            else
            {
                FormRetirar re = new FormRetirar(7, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(7, button7);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(8).Estado)
            {
                FormAlquiler fa = new FormAlquiler(8, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(8, button8);
            }
            else
            {
                FormRetirar re = new FormRetirar(8, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(8, button8);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(9).Estado)
            {
                FormAlquiler fa = new FormAlquiler(9, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(9, button9);
            }
            else
            {
                FormRetirar re = new FormRetirar(9, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(9, button9);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(10).Estado)
            {
                FormAlquiler fa = new FormAlquiler(10, "Planta Baja", listalquiler, listmovim,us,listestacion);
                fa.ShowDialog();
                CambiarColores(10, button10);
            }
            else
            {
                FormRetirar re = new FormRetirar(10, "Planta Baja", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(10, button10);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(11).Estado)
            {
                FormAlquiler fa = new FormAlquiler(11, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(11, button11);
            }
            else
            {
                FormRetirar re = new FormRetirar(11, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(11, button11);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(12).Estado)
            {
                FormAlquiler fa = new FormAlquiler(12, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(12, button12);
            }
            else
            {
                FormRetirar re = new FormRetirar(12, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(12, button12);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(13).Estado)
            {
                FormAlquiler fa = new FormAlquiler(13, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(13, button13);
            }
            else
            {
                FormRetirar re = new FormRetirar(13, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(13, button13);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(14).Estado)
            {
                FormAlquiler fa = new FormAlquiler(14, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(14, button14);
            }
            else
            {
                FormRetirar re = new FormRetirar(14, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(14, button14);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(15).Estado)
            {
                FormAlquiler fa = new FormAlquiler(15, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(15, button15);
            }
            else
            {
                FormRetirar re = new FormRetirar(15, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(15, button15);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(16).Estado)
            {
                FormAlquiler fa = new FormAlquiler(16, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(16, button16);
            }
            else
            {
                FormRetirar re = new FormRetirar(16, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(16, button16);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(17).Estado)
            {
                FormAlquiler fa = new FormAlquiler(17, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(17, button17);
            }
            else
            {
                FormRetirar re = new FormRetirar(17, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(17, button17);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(18).Estado)
            {
                FormAlquiler fa = new FormAlquiler(18, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(18, button18);
            }
            else
            {
                FormRetirar re = new FormRetirar(18, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(18, button18);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(19).Estado)
            {
                FormAlquiler fa = new FormAlquiler(19, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(19, button19);
            }
            else
            {
                FormRetirar re = new FormRetirar(19, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(19, button19);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (listestacion.Buscar(20).Estado)
            {
                FormAlquiler fa = new FormAlquiler(20, "Primer Piso", listalquiler, listmovim, us, listestacion);
                fa.ShowDialog();
                CambiarColores(20, button20);
            }
            else
            {
                FormRetirar re = new FormRetirar(20, "Primer Piso", listalquiler, listmovim, us, listestacion);
                re.ShowDialog();
                CambiarColores(20, button20);
            }
        }

       

        private void toolStripMenuItemEgreso_Click(object sender, EventArgs e)
        {
            FormEgreso f = new FormEgreso(listmovim,us);
            f.ShowDialog();
        }

        private void toolStripMenuItemCierre_Click(object sender, EventArgs e)
        {
            FormCierre f = new FormCierre(listmovim,us,listcierres);
            f.ShowDialog();
        }

        private void toolStripMenuItemMovimientos_Click(object sender, EventArgs e)
        {
            FormMovimientos f = new FormMovimientos(listmovim);
            f.ShowDialog();
        }

        private void verCierresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCierres f = new FormCierres(listcierres);
            f.ShowDialog();
        }
    }
}
