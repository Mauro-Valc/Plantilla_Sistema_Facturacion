namespace Plantilla_Sistema_Facturacion
{
    partial class FrmInvoice
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
            this.LblAdministracionFactura = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNroFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscarFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTotalIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LblFechaRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdministracionFactura
            // 
            this.LblAdministracionFactura.AutoSize = true;
            this.LblAdministracionFactura.Depth = 0;
            this.LblAdministracionFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdministracionFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdministracionFactura.Location = new System.Drawing.Point(324, 11);
            this.LblAdministracionFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdministracionFactura.Name = "LblAdministracionFactura";
            this.LblAdministracionFactura.Size = new System.Drawing.Size(212, 19);
            this.LblAdministracionFactura.TabIndex = 21;
            this.LblAdministracionFactura.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.LblEstadoFactura);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.LblFechaRegistro);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.TxtTotalFactura);
            this.panel1.Controls.Add(this.TxtTotalIva);
            this.panel1.Controls.Add(this.TxtDescuento);
            this.panel1.Controls.Add(this.TxtEmpleado);
            this.panel1.Controls.Add(this.TxtCliente);
            this.panel1.Controls.Add(this.TxtNroFactura);
            this.panel1.Location = new System.Drawing.Point(51, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 222);
            this.panel1.TabIndex = 20;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Depth = 0;
            this.TxtCliente.Hint = "Cliente";
            this.TxtCliente.Location = new System.Drawing.Point(26, 42);
            this.TxtCliente.MaxLength = 32767;
            this.TxtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.PasswordChar = '\0';
            this.TxtCliente.SelectedText = "";
            this.TxtCliente.SelectionLength = 0;
            this.TxtCliente.SelectionStart = 0;
            this.TxtCliente.Size = new System.Drawing.Size(92, 23);
            this.TxtCliente.TabIndex = 3;
            this.TxtCliente.TabStop = false;
            this.TxtCliente.UseSystemPasswordChar = false;
            // 
            // TxtNroFactura
            // 
            this.TxtNroFactura.Depth = 0;
            this.TxtNroFactura.Hint = "Nro factura";
            this.TxtNroFactura.Location = new System.Drawing.Point(26, 13);
            this.TxtNroFactura.MaxLength = 32767;
            this.TxtNroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNroFactura.Name = "TxtNroFactura";
            this.TxtNroFactura.PasswordChar = '\0';
            this.TxtNroFactura.SelectedText = "";
            this.TxtNroFactura.SelectionLength = 0;
            this.TxtNroFactura.SelectionStart = 0;
            this.TxtNroFactura.Size = new System.Drawing.Size(92, 23);
            this.TxtNroFactura.TabIndex = 2;
            this.TxtNroFactura.TabStop = false;
            this.TxtNroFactura.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscarCategoria);
            this.panel2.Location = new System.Drawing.Point(51, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 263);
            this.panel2.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 173);
            this.dataGridView1.TabIndex = 9;
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
            // TxtBuscarCategoria
            // 
            this.TxtBuscarCategoria.Depth = 0;
            this.TxtBuscarCategoria.Hint = "Buscar categoria";
            this.TxtBuscarCategoria.Location = new System.Drawing.Point(37, 25);
            this.TxtBuscarCategoria.MaxLength = 32767;
            this.TxtBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarCategoria.Name = "TxtBuscarCategoria";
            this.TxtBuscarCategoria.PasswordChar = '\0';
            this.TxtBuscarCategoria.SelectedText = "";
            this.TxtBuscarCategoria.SelectionLength = 0;
            this.TxtBuscarCategoria.SelectionStart = 0;
            this.TxtBuscarCategoria.Size = new System.Drawing.Size(363, 23);
            this.TxtBuscarCategoria.TabIndex = 2;
            this.TxtBuscarCategoria.TabStop = false;
            this.TxtBuscarCategoria.UseSystemPasswordChar = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(660, 170);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(660, 128);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(660, 86);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 16;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarFactura
            // 
            this.BtnBuscarFactura.AutoSize = true;
            this.BtnBuscarFactura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscarFactura.Depth = 0;
            this.BtnBuscarFactura.Icon = null;
            this.BtnBuscarFactura.Location = new System.Drawing.Point(660, 44);
            this.BtnBuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscarFactura.Name = "BtnBuscarFactura";
            this.BtnBuscarFactura.Primary = true;
            this.BtnBuscarFactura.Size = new System.Drawing.Size(138, 36);
            this.BtnBuscarFactura.TabIndex = 22;
            this.BtnBuscarFactura.Text = "Buscar factura";
            this.BtnBuscarFactura.UseVisualStyleBackColor = true;
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Depth = 0;
            this.TxtEmpleado.Hint = "Empleado";
            this.TxtEmpleado.Location = new System.Drawing.Point(26, 71);
            this.TxtEmpleado.MaxLength = 32767;
            this.TxtEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.PasswordChar = '\0';
            this.TxtEmpleado.SelectedText = "";
            this.TxtEmpleado.SelectionLength = 0;
            this.TxtEmpleado.SelectionStart = 0;
            this.TxtEmpleado.Size = new System.Drawing.Size(92, 23);
            this.TxtEmpleado.TabIndex = 4;
            this.TxtEmpleado.TabStop = false;
            this.TxtEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Depth = 0;
            this.TxtDescuento.Hint = "Descuento";
            this.TxtDescuento.Location = new System.Drawing.Point(26, 100);
            this.TxtDescuento.MaxLength = 32767;
            this.TxtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.PasswordChar = '\0';
            this.TxtDescuento.SelectedText = "";
            this.TxtDescuento.SelectionLength = 0;
            this.TxtDescuento.SelectionStart = 0;
            this.TxtDescuento.Size = new System.Drawing.Size(92, 23);
            this.TxtDescuento.TabIndex = 5;
            this.TxtDescuento.TabStop = false;
            this.TxtDescuento.UseSystemPasswordChar = false;
            // 
            // TxtTotalIva
            // 
            this.TxtTotalIva.Depth = 0;
            this.TxtTotalIva.Hint = "Tota iva";
            this.TxtTotalIva.Location = new System.Drawing.Point(26, 129);
            this.TxtTotalIva.MaxLength = 32767;
            this.TxtTotalIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTotalIva.Name = "TxtTotalIva";
            this.TxtTotalIva.PasswordChar = '\0';
            this.TxtTotalIva.SelectedText = "";
            this.TxtTotalIva.SelectionLength = 0;
            this.TxtTotalIva.SelectionStart = 0;
            this.TxtTotalIva.Size = new System.Drawing.Size(92, 23);
            this.TxtTotalIva.TabIndex = 6;
            this.TxtTotalIva.TabStop = false;
            this.TxtTotalIva.UseSystemPasswordChar = false;
            // 
            // TxtTotalFactura
            // 
            this.TxtTotalFactura.Depth = 0;
            this.TxtTotalFactura.Hint = "Tota factura";
            this.TxtTotalFactura.Location = new System.Drawing.Point(26, 172);
            this.TxtTotalFactura.MaxLength = 32767;
            this.TxtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTotalFactura.Name = "TxtTotalFactura";
            this.TxtTotalFactura.PasswordChar = '\0';
            this.TxtTotalFactura.SelectedText = "";
            this.TxtTotalFactura.SelectionLength = 0;
            this.TxtTotalFactura.SelectionStart = 0;
            this.TxtTotalFactura.Size = new System.Drawing.Size(92, 23);
            this.TxtTotalFactura.TabIndex = 7;
            this.TxtTotalFactura.TabStop = false;
            this.TxtTotalFactura.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // LblFechaRegistro
            // 
            this.LblFechaRegistro.AutoSize = true;
            this.LblFechaRegistro.Depth = 0;
            this.LblFechaRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaRegistro.Location = new System.Drawing.Point(335, 26);
            this.LblFechaRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaRegistro.Name = "LblFechaRegistro";
            this.LblFechaRegistro.Size = new System.Drawing.Size(105, 19);
            this.LblFechaRegistro.TabIndex = 23;
            this.LblFechaRegistro.Text = "Fecha registro";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // LblEstadoFactura
            // 
            this.LblEstadoFactura.AutoSize = true;
            this.LblEstadoFactura.Depth = 0;
            this.LblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEstadoFactura.Location = new System.Drawing.Point(335, 100);
            this.LblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEstadoFactura.Name = "LblEstadoFactura";
            this.LblEstadoFactura.Size = new System.Drawing.Size(110, 19);
            this.LblEstadoFactura.TabIndex = 25;
            this.LblEstadoFactura.Text = "Estado Factura";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(339, 135);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 26;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBuscarFactura);
            this.Controls.Add(this.LblAdministracionFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAdministracionFactura;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNroFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTotalIva;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTotalFactura;
        private MaterialSkin.Controls.MaterialLabel LblFechaRegistro;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel LblEstadoFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}