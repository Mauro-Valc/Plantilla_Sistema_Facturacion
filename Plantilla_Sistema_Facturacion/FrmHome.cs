using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Plantilla_Sistema_Facturacion
{
    public partial class FrmHome : MaterialForm
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCustomer FrmCustomer = new FrmCustomer();
            openForm(FrmCustomer);
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProduct FrmProduct = new FrmProduct();
            openForm(FrmProduct);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategory FrmCategory = new FrmCategory();
            openForm(FrmCategory);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmInvoice FrmInvoice = new FrmInvoice();
            openForm(FrmInvoice);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmReport FrmReport = new FrmReport();
            openForm(FrmReport);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmployee FrmEmployee = new FrmEmployee();
            openForm(FrmEmployee);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRole FrmRole = new FrmRole();
            openForm(FrmRole);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            FrmSecurity FrmSecurity = new FrmSecurity();
            openForm(FrmSecurity);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmHelp FrmHelp = new FrmHelp();
            openForm(FrmHelp);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAbout FrmAbout = new FrmAbout();
            openForm(FrmAbout);
        }

        private void openForm(Form form)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
