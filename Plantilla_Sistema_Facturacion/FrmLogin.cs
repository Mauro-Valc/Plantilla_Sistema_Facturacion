using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Plantilla_Sistema_Facturacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmHome fromHome;
            String username, password, response;
            username = txtUsuario.Text;
            password = txtPassword.Text;
            try
            {
                if (username == String.Empty || password == String.Empty)
                    throw new Exception("Debe ingresar datos");

                if (username != "admin" && password != "admin")
                    throw new Exception("Los datos ingresados no generan resultados");

                DataAccess access = new DataAccess();
                response = access.ValidarUsuario(username, password);
                fromHome = new FrmHome();
                fromHome.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
