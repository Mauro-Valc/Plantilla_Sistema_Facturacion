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
    public partial class FrmProduct : Form
    {
        private static string EMPTY_STRING = "";
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            DataTable dataTable = new DataTable();
            DataAccess access = new DataAccess();
            dataTable = access.LoadTable("TBLPRODUCTO1", "");
            DgProductos.DataSource = dataTable;

            dataTable = access.LoadTable("TBLCATEGORIA_PROD", "");
            CbCategoria.DataSource = dataTable;
            CbCategoria.DisplayMember = "StrDescripcion";
            CbCategoria.ValueMember = "IdCategoria";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                TxtIdProducto.Text = EMPTY_STRING;
                txtNombreProducto.Text = EMPTY_STRING;
                TxtCodigoReferencia.Text = EMPTY_STRING;
                TxtPrecioVenta.Text = EMPTY_STRING;
                TxtPrecioCompra.Text = EMPTY_STRING;
                TxtCantidadStock.Text = EMPTY_STRING;
                TxtRutaImagen.Text = EMPTY_STRING;
                CbCategoria.SelectedIndex = 0;
                TxtDetalleProducto.Text = EMPTY_STRING;
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
                if (valitadeProductForm())
                {
                    DataAccess access = new DataAccess();
                    string command = $"exec actualizar_Producto '{TxtIdProducto.Text}', '{txtNombreProducto.Text}', '{TxtCodigoReferencia.Text}', '{TxtPrecioCompra.Text}', '{TxtPrecioVenta.Text}', '{CbCategoria.SelectedValue}', '{TxtDetalleProducto.Text}', '{TxtRutaImagen.Text}', '{TxtCantidadStock.Text}', '{DateTime.Now}', 'AdminUser'";
                    MessageBox.Show(access.RunCommand(command));
                    fillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fallo inserción: " + ex);
            }
        }

        private bool valitadeProductForm()
        {
            try
            {
                setErrorProvider(txtNombreProducto, "Debe ingresar el nombre del producto");
                setErrorProvider(TxtCodigoReferencia, "Debe ingresar el codigo referencia");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess access = new DataAccess();
                string command = $"exec Eliminar_Producto '{TxtIdProducto.Text}'";
                MessageBox.Show(access.RunCommand(command));
                fillGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un errro no esperado durante el proceso");
            }
        }

        private void DgProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentPosition = 0;
            currentPosition = DgProductos.CurrentRow.Index;
            TxtIdProducto.Text = DgProductos[0, currentPosition].Value.ToString();
            txtNombreProducto.Text = DgProductos[1, currentPosition].Value.ToString();
            TxtCodigoReferencia.Text = DgProductos[2, currentPosition].Value.ToString();
            TxtPrecioCompra.Text = DgProductos[3, currentPosition].Value.ToString();
            TxtPrecioVenta.Text = DgProductos[4, currentPosition].Value.ToString();
            CbCategoria.SelectedIndex = Convert.ToInt32(DgProductos[5, currentPosition].Value.ToString()) - 1;
            TxtDetalleProducto.Text = DgProductos[6, currentPosition].Value.ToString();
            TxtRutaImagen.Text = DgProductos[7, currentPosition].Value.ToString();
            TxtCantidadStock.Text = DgProductos[8, currentPosition].Value.ToString();
        }
    }
}
