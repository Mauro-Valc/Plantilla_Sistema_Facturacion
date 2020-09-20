namespace Plantilla_Sistema_Facturacion
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblAdministracionDeProductos = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblDescripcionProducto = new MaterialSkin.Controls.MaterialLabel();
            this.LblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.CbCategoria = new System.Windows.Forms.ComboBox();
            this.TxtDetalleProducto = new System.Windows.Forms.TextBox();
            this.TxtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(706, 153);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(706, 111);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(706, 69);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // LblAdministracionDeProductos
            // 
            this.LblAdministracionDeProductos.AutoSize = true;
            this.LblAdministracionDeProductos.Depth = 0;
            this.LblAdministracionDeProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdministracionDeProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdministracionDeProductos.Location = new System.Drawing.Point(377, 19);
            this.LblAdministracionDeProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdministracionDeProductos.Name = "LblAdministracionDeProductos";
            this.LblAdministracionDeProductos.Size = new System.Drawing.Size(246, 19);
            this.LblAdministracionDeProductos.TabIndex = 6;
            this.LblAdministracionDeProductos.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtIdProducto);
            this.panel1.Controls.Add(this.LblDescripcionProducto);
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Controls.Add(this.CbCategoria);
            this.panel1.Controls.Add(this.TxtDetalleProducto);
            this.panel1.Controls.Add(this.TxtRutaImagen);
            this.panel1.Controls.Add(this.TxtCantidadStock);
            this.panel1.Controls.Add(this.TxtPrecioVenta);
            this.panel1.Controls.Add(this.TxtPrecioCompra);
            this.panel1.Controls.Add(this.TxtCodigoReferencia);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Location = new System.Drawing.Point(73, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 263);
            this.panel1.TabIndex = 5;
            // 
            // LblDescripcionProducto
            // 
            this.LblDescripcionProducto.AutoSize = true;
            this.LblDescripcionProducto.Depth = 0;
            this.LblDescripcionProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDescripcionProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescripcionProducto.Location = new System.Drawing.Point(321, 125);
            this.LblDescripcionProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDescripcionProducto.Name = "LblDescripcionProducto";
            this.LblDescripcionProducto.Size = new System.Drawing.Size(120, 19);
            this.LblDescripcionProducto.TabIndex = 11;
            this.LblDescripcionProducto.Text = "Detalle producto";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Depth = 0;
            this.LblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCategoria.Location = new System.Drawing.Point(321, 29);
            this.LblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(74, 19);
            this.LblCategoria.TabIndex = 10;
            this.LblCategoria.Text = "Categoria";
            // 
            // CbCategoria
            // 
            this.CbCategoria.FormattingEnabled = true;
            this.CbCategoria.Location = new System.Drawing.Point(464, 30);
            this.CbCategoria.Name = "CbCategoria";
            this.CbCategoria.Size = new System.Drawing.Size(121, 21);
            this.CbCategoria.TabIndex = 9;
            // 
            // TxtDetalleProducto
            // 
            this.TxtDetalleProducto.Location = new System.Drawing.Point(325, 163);
            this.TxtDetalleProducto.Name = "TxtDetalleProducto";
            this.TxtDetalleProducto.Size = new System.Drawing.Size(260, 20);
            this.TxtDetalleProducto.TabIndex = 8;
            // 
            // TxtRutaImagen
            // 
            this.TxtRutaImagen.Depth = 0;
            this.TxtRutaImagen.Hint = "Ruta imagen";
            this.TxtRutaImagen.Location = new System.Drawing.Point(325, 76);
            this.TxtRutaImagen.MaxLength = 32767;
            this.TxtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRutaImagen.Name = "TxtRutaImagen";
            this.TxtRutaImagen.PasswordChar = '\0';
            this.TxtRutaImagen.SelectedText = "";
            this.TxtRutaImagen.SelectionLength = 0;
            this.TxtRutaImagen.SelectionStart = 0;
            this.TxtRutaImagen.Size = new System.Drawing.Size(260, 23);
            this.TxtRutaImagen.TabIndex = 7;
            this.TxtRutaImagen.TabStop = false;
            this.TxtRutaImagen.UseSystemPasswordChar = false;
            // 
            // TxtCantidadStock
            // 
            this.TxtCantidadStock.Depth = 0;
            this.TxtCantidadStock.Hint = "Cantidad stock";
            this.TxtCantidadStock.Location = new System.Drawing.Point(37, 204);
            this.TxtCantidadStock.MaxLength = 32767;
            this.TxtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCantidadStock.Name = "TxtCantidadStock";
            this.TxtCantidadStock.PasswordChar = '\0';
            this.TxtCantidadStock.SelectedText = "";
            this.TxtCantidadStock.SelectionLength = 0;
            this.TxtCantidadStock.SelectionStart = 0;
            this.TxtCantidadStock.Size = new System.Drawing.Size(260, 23);
            this.TxtCantidadStock.TabIndex = 6;
            this.TxtCantidadStock.TabStop = false;
            this.TxtCantidadStock.UseSystemPasswordChar = false;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Depth = 0;
            this.TxtPrecioVenta.Hint = "Precio venta";
            this.TxtPrecioVenta.Location = new System.Drawing.Point(37, 163);
            this.TxtPrecioVenta.MaxLength = 32767;
            this.TxtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.PasswordChar = '\0';
            this.TxtPrecioVenta.SelectedText = "";
            this.TxtPrecioVenta.SelectionLength = 0;
            this.TxtPrecioVenta.SelectionStart = 0;
            this.TxtPrecioVenta.Size = new System.Drawing.Size(260, 23);
            this.TxtPrecioVenta.TabIndex = 5;
            this.TxtPrecioVenta.TabStop = false;
            this.TxtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Depth = 0;
            this.TxtPrecioCompra.Hint = "Precio compra";
            this.TxtPrecioCompra.Location = new System.Drawing.Point(37, 121);
            this.TxtPrecioCompra.MaxLength = 32767;
            this.TxtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.PasswordChar = '\0';
            this.TxtPrecioCompra.SelectedText = "";
            this.TxtPrecioCompra.SelectionLength = 0;
            this.TxtPrecioCompra.SelectionStart = 0;
            this.TxtPrecioCompra.Size = new System.Drawing.Size(260, 23);
            this.TxtPrecioCompra.TabIndex = 4;
            this.TxtPrecioCompra.TabStop = false;
            this.TxtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // TxtCodigoReferencia
            // 
            this.TxtCodigoReferencia.Depth = 0;
            this.TxtCodigoReferencia.Hint = "Codigo referencia";
            this.TxtCodigoReferencia.Location = new System.Drawing.Point(37, 76);
            this.TxtCodigoReferencia.MaxLength = 32767;
            this.TxtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigoReferencia.Name = "TxtCodigoReferencia";
            this.TxtCodigoReferencia.PasswordChar = '\0';
            this.TxtCodigoReferencia.SelectedText = "";
            this.TxtCodigoReferencia.SelectionLength = 0;
            this.TxtCodigoReferencia.SelectionStart = 0;
            this.TxtCodigoReferencia.Size = new System.Drawing.Size(260, 23);
            this.TxtCodigoReferencia.TabIndex = 3;
            this.TxtCodigoReferencia.TabStop = false;
            this.TxtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(37, 25);
            this.txtNombreProducto.MaxLength = 32767;
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(260, 23);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.TabStop = false;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgProductos);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscarProducto);
            this.panel2.Location = new System.Drawing.Point(73, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 263);
            this.panel2.TabIndex = 10;
            // 
            // DgProductos
            // 
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.Location = new System.Drawing.Point(37, 67);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.Size = new System.Drawing.Size(510, 173);
            this.DgProductos.TabIndex = 9;
            this.DgProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgProductos_CellMouseClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(464, 12);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarProducto
            // 
            this.TxtBuscarProducto.Depth = 0;
            this.TxtBuscarProducto.Hint = "Buscar producto";
            this.TxtBuscarProducto.Location = new System.Drawing.Point(37, 25);
            this.TxtBuscarProducto.MaxLength = 32767;
            this.TxtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarProducto.Name = "TxtBuscarProducto";
            this.TxtBuscarProducto.PasswordChar = '\0';
            this.TxtBuscarProducto.SelectedText = "";
            this.TxtBuscarProducto.SelectionLength = 0;
            this.TxtBuscarProducto.SelectionStart = 0;
            this.TxtBuscarProducto.Size = new System.Drawing.Size(363, 23);
            this.TxtBuscarProducto.TabIndex = 2;
            this.TxtBuscarProducto.TabStop = false;
            this.TxtBuscarProducto.UseSystemPasswordChar = false;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(37, 3);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtIdProducto.TabIndex = 11;
            this.TxtIdProducto.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.LblAdministracionDeProductos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialLabel LblAdministracionDeProductos;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRutaImagen;
        private MaterialSkin.Controls.MaterialLabel LblCategoria;
        private System.Windows.Forms.ComboBox CbCategoria;
        private System.Windows.Forms.TextBox TxtDetalleProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgProductos;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarProducto;
        private MaterialSkin.Controls.MaterialLabel LblDescripcionProducto;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}