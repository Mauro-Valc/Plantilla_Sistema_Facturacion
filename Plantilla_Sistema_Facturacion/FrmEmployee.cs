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
    public partial class FrmEmployee : Form
    {
        private static string EMPTY_STRING = "";

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            DataTable dataTable = new DataTable();
            DataAccess access = new DataAccess();
            dataTable = access.LoadTable("TBLEMPLEADO", "");
            dgEmployee.DataSource = dataTable;

            dataTable = access.LoadTable("TBLROLES", "");
            cbRole.DataSource = dataTable;
            cbRole.DisplayMember = "StrDescripcion";
            cbRole.ValueMember = "IdRolEmpleado";
        }

        private void dgEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentPosition = 0;
            currentPosition = dgEmployee.CurrentRow.Index;
            TxtIdEmployee.Text = dgEmployee[0, currentPosition].Value.ToString();
            txtNombreEmpleado.Text = dgEmployee[1, currentPosition].Value.ToString();
            TxtDocumento.Text = dgEmployee[2, currentPosition].Value.ToString();
            TxtDireccion.Text = dgEmployee[3, currentPosition].Value.ToString();
            TxtTelefono.Text = dgEmployee[4, currentPosition].Value.ToString();
            TxtEmail.Text = dgEmployee[5, currentPosition].Value.ToString();
            cbRole.SelectedIndex = Convert.ToInt32(dgEmployee[6, currentPosition].Value.ToString()) - 1;
            dtIngreso.Value = Convert.ToDateTime(dgEmployee[7, currentPosition].Value.ToString());
            if (dgEmployee[8, currentPosition].Value.ToString() != "")
            {
                dtRetiro.Value = Convert.ToDateTime(dgEmployee[8, currentPosition].Value.ToString());
            }
            else
            {
                dtRetiro.Value = Convert.ToDateTime("01/01/1900");
            }
            txtDatosAdicionales.Text = dgEmployee[9, currentPosition].Value.ToString();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valitadeEmployeeForm())
                {
                    DataAccess access = new DataAccess();
                    string command = $"exec actualizar_Empleado '{TxtIdEmployee.Text}', '{txtNombreEmpleado.Text}', '{TxtDocumento.Text}', '{TxtDireccion.Text}', '{TxtTelefono.Text}', '{TxtEmail.Text}', '{cbRole.SelectedIndex + 1}', '{dtIngreso.Value}', '{dtRetiro.Value}', '{txtDatosAdicionales.Text}', '2020-09-01', 'AdminUser'";
                    MessageBox.Show(access.RunCommand(command));
                    fillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fallo inserción: " + ex);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess access = new DataAccess();
                string command = $"exec Eliminar_Empleado '{TxtIdEmployee.Text}'";
                MessageBox.Show(access.RunCommand(command));
                fillGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un errro no esperado durante el proceso");
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                TxtIdEmployee.Text = EMPTY_STRING;
                txtNombreEmpleado.Text = EMPTY_STRING;
                TxtDocumento.Text = EMPTY_STRING;
                TxtDireccion.Text = EMPTY_STRING;
                TxtTelefono.Text = EMPTY_STRING;
                TxtEmail.Text = EMPTY_STRING;
                cbRole.SelectedIndex = 0;
                dtIngreso.Value = DateTime.Now;
                dtRetiro.Value = Convert.ToDateTime("01/01/1900");
                txtDatosAdicionales.Text = EMPTY_STRING;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un errro no esperado durante el proceso");
            }
        }

        private bool valitadeEmployeeForm()
        {
            try
            {
                setErrorProvider(txtNombreEmpleado, "Debe ingresar el nombre del empleado");
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

        
    }
}
