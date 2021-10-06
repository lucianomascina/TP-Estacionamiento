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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        Usuarios listausuarios = new Usuarios();

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string usuario =  txtUser.Text.Trim();
            string password =  txtPassword.Text.Trim();
            
            
            if(listausuarios.Buscar(usuario,password))
            {
                this.Hide();
                Usuario user = new Usuario(usuario,password);
                FormPrincipal f = new FormPrincipal(listausuarios,user);
               
                f.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O PASSWORD SON INCORRECTOS");
                txtPassword.Clear();
                txtUser.Clear();
                txtUser.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario u = new Usuario("admin", "1234");
            listausuarios.Agregar(u);
        }
    }
}
