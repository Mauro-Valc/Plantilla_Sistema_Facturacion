using MaterialSkin.Controls;
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
    public partial class FrmCustomer : Form
    {
        private static string EMPTY_STRING = "";
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            DataTable dataTable = new DataTable();
            DataAccess access = new DataAccess();
            dataTable = access.LoadTable("TBLCLIENTES", "");
            dgCustomer.DataSource = dataTable;
        }

        private void dgCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentPosition = 0;
            currentPosition = dgCustomer.CurrentRow.Index;
            TxtIdCustomer.Text = dgCustomer[0, currentPosition].Value.ToString();
            TxtNombreCliente.Text = dgCustomer[1, currentPosition].Value.ToString();
            TxtDocumento.Text = dgCustomer[2, currentPosition].Value.ToString();
            TxtDireccion.Text = dgCustomer[3, currentPosition].Value.ToString();
            TxtTelefono.Text = dgCustomer[4, currentPosition].Value.ToString();
            TxtEmail.Text = dgCustomer[5, currentPosition].Value.ToString();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                TxtIdCustomer.Text = EMPTY_STRING;
                TxtNombreCliente.Text = EMPTY_STRING;
                TxtDocumento.Text = EMPTY_STRING;
                TxtDireccion.Text = EMPTY_STRING;
                TxtTelefono.Text = EMPTY_STRING;
                TxtEmail.Text = EMPTY_STRING;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un errro no esperado durante el proceso");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valitadeCustomerForm())
                {
                    DataAccess access = new DataAccess();
                    string command = $"exec actualizar_Cliente '{TxtIdCustomer.Text}', '{TxtNombreCliente.Text}', '{TxtDocumento.Text}', '{TxtDireccion.Text}', '{TxtTelefono.Text}', '{TxtEmail.Text}', '{DateTime.Now}', 'AdminUser'";
                    MessageBox.Show(access.RunCommand(command));
                    fillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fallo inserción: " + ex);
            }
        }

        private bool valitadeCustomerForm()
        {
            try
            {
                setErrorProvider(TxtNombreCliente, "Debe ingresar el nombre del cliente");
                setErrorProvider(TxtDocumento, "Debe ingresar el documento");
                if (!isNumber(TxtDocumento.Text))
                {
                    errorProvider.SetError(TxtDocumento, "Debe ingresar el documento");
                    TxtDocumento.Focus();
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void setErrorProvider(MaterialSingleLineTextField txt, string message)
        {
            if (txt.Text == string.Empty)
            {
                errorProvider.SetError(txt, message);
                txt.Focus();
                throw new Exception();
            }
            else
            {
                errorProvider.SetError(txt, EMPTY_STRING);
            }
        }
        private bool isNumber(string number)
        {
            try
            {
                double x = Convert.ToDouble(number);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess access = new DataAccess();
                string command = $"exec Eliminar_Cliente '{TxtIdCustomer.Text}'";
                MessageBox.Show(access.RunCommand(command));
                fillGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un errro no esperado durante el proceso");
            }
        }
    }
}
