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
using System.Xml;

namespace Plantilla_Sistema_Facturacion
{
    public partial class FrmSecurity : Form
    {
        private static string EMPTY_STRING = "";

        public FrmSecurity()
        {
            InitializeComponent();
        }

        private void FrmSecurity_Load(object sender, EventArgs e)
        {
            fillEmployeeComboBox();
        }

        private void fillEmployeeComboBox()
        {
            DataTable dataTable = new DataTable();
            DataAccess access = new DataAccess();
            dataTable = access.LoadTable("TBLEMPLEADO","");
            cbEmployee.DataSource = dataTable;
            cbEmployee.DisplayMember = "strNombre";
            cbEmployee.ValueMember = "IdEmpleado";
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valitadeSecurityForm())
                {
                    DataAccess access = new DataAccess();
                    string command = $"exec actualizar_Seguridad '{TxtIdSeguridad.Text}','{Convert.ToInt32(cbEmployee.SelectedValue)}', '{TxtUsuario.Text}', '{TxtClave.Text}', '{DateTime.Now}', 'admin'";
                    MessageBox.Show(access.RunCommand(command));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo actualización");
            }
           
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();
            string command = $"exec Eliminar_Seguridad '{TxtIdSeguridad.Text}'";
            MessageBox.Show(access.RunCommand(command));
            TxtIdSeguridad.Text = EMPTY_STRING;
            TxtUsuario.Text = EMPTY_STRING;
            TxtClave.Text = EMPTY_STRING;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string command = $"select IdSeguridad ,StrUsuario, StrClave from TBLSEGURIDAD where IdEmpleado = '{cbEmployee.SelectedValue}'";
            DataAccess access = new DataAccess();
            dataTable = access.GetDataForQuery(command);
            if (dataTable.Rows.Count > 0)
            {
                TxtIdSeguridad.Text = dataTable.Rows[0]["IdSeguridad"].ToString();
                TxtUsuario.Text = dataTable.Rows[0]["StrUsuario"].ToString();
                TxtClave.Text = dataTable.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                TxtUsuario.Text = EMPTY_STRING;
                TxtClave.Text = EMPTY_STRING;
            }
        }

        private bool valitadeSecurityForm()
        {
            try
            {
                setErrorProvider(TxtUsuario, "Debe ingresar el usuario");
                setErrorProvider(TxtClave, "Debe ingresar la clave");
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

        
    }
}
