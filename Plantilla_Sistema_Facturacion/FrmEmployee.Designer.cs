namespace Plantilla_Sistema_Facturacion
{
    partial class FrmEmployee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblAdministracionEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtIdEmployee = new System.Windows.Forms.TextBox();
            this.dtRetiro = new System.Windows.Forms.DateTimePicker();
            this.LblFechaRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.LblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.LblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.LblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.TxtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgEmployee);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscarEmpleado);
            this.panel2.Location = new System.Drawing.Point(47, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 263);
            this.panel2.TabIndex = 16;
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(37, 67);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(510, 173);
            this.dgEmployee.TabIndex = 9;
            this.dgEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEmployee_CellMouseClick);
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
            // TxtBuscarEmpleado
            // 
            this.TxtBuscarEmpleado.Depth = 0;
            this.TxtBuscarEmpleado.Hint = "Buscar Empleado";
            this.TxtBuscarEmpleado.Location = new System.Drawing.Point(37, 25);
            this.TxtBuscarEmpleado.MaxLength = 32767;
            this.TxtBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarEmpleado.Name = "TxtBuscarEmpleado";
            this.TxtBuscarEmpleado.PasswordChar = '\0';
            this.TxtBuscarEmpleado.SelectedText = "";
            this.TxtBuscarEmpleado.SelectionLength = 0;
            this.TxtBuscarEmpleado.SelectionStart = 0;
            this.TxtBuscarEmpleado.Size = new System.Drawing.Size(363, 23);
            this.TxtBuscarEmpleado.TabIndex = 2;
            this.TxtBuscarEmpleado.TabStop = false;
            this.TxtBuscarEmpleado.UseSystemPasswordChar = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(680, 145);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 15;
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
            this.BtnActualizar.Location = new System.Drawing.Point(680, 103);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 14;
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
            this.BtnNuevo.Location = new System.Drawing.Point(680, 61);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 13;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // LblAdministracionEmpleados
            // 
            this.LblAdministracionEmpleados.AutoSize = true;
            this.LblAdministracionEmpleados.Depth = 0;
            this.LblAdministracionEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdministracionEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdministracionEmpleados.Location = new System.Drawing.Point(351, 11);
            this.LblAdministracionEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdministracionEmpleados.Name = "LblAdministracionEmpleados";
            this.LblAdministracionEmpleados.Size = new System.Drawing.Size(247, 19);
            this.LblAdministracionEmpleados.TabIndex = 12;
            this.LblAdministracionEmpleados.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtIdEmployee);
            this.panel1.Controls.Add(this.dtRetiro);
            this.panel1.Controls.Add(this.LblFechaRetiro);
            this.panel1.Controls.Add(this.dtIngreso);
            this.panel1.Controls.Add(this.LblFechaIngreso);
            this.panel1.Controls.Add(this.LblDatosAdicionales);
            this.panel1.Controls.Add(this.LblRolEmpleado);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.txtDatosAdicionales);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtTelefono);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.TxtDocumento);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Location = new System.Drawing.Point(47, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 263);
            this.panel1.TabIndex = 11;
            // 
            // TxtIdEmployee
            // 
            this.TxtIdEmployee.Location = new System.Drawing.Point(37, -1);
            this.TxtIdEmployee.Name = "TxtIdEmployee";
            this.TxtIdEmployee.Size = new System.Drawing.Size(100, 20);
            this.TxtIdEmployee.TabIndex = 17;
            this.TxtIdEmployee.Visible = false;
            // 
            // dtRetiro
            // 
            this.dtRetiro.Location = new System.Drawing.Point(325, 146);
            this.dtRetiro.Name = "dtRetiro";
            this.dtRetiro.Size = new System.Drawing.Size(200, 20);
            this.dtRetiro.TabIndex = 27;
            // 
            // LblFechaRetiro
            // 
            this.LblFechaRetiro.AutoSize = true;
            this.LblFechaRetiro.Depth = 0;
            this.LblFechaRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaRetiro.Location = new System.Drawing.Point(321, 121);
            this.LblFechaRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaRetiro.Name = "LblFechaRetiro";
            this.LblFechaRetiro.Size = new System.Drawing.Size(93, 19);
            this.LblFechaRetiro.TabIndex = 26;
            this.LblFechaRetiro.Text = "Fecha Retiro";
            // 
            // dtIngreso
            // 
            this.dtIngreso.Location = new System.Drawing.Point(325, 84);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtIngreso.TabIndex = 25;
            // 
            // LblFechaIngreso
            // 
            this.LblFechaIngreso.AutoSize = true;
            this.LblFechaIngreso.Depth = 0;
            this.LblFechaIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaIngreso.Location = new System.Drawing.Point(321, 59);
            this.LblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaIngreso.Name = "LblFechaIngreso";
            this.LblFechaIngreso.Size = new System.Drawing.Size(103, 19);
            this.LblFechaIngreso.TabIndex = 12;
            this.LblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // LblDatosAdicionales
            // 
            this.LblDatosAdicionales.AutoSize = true;
            this.LblDatosAdicionales.Depth = 0;
            this.LblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDatosAdicionales.Location = new System.Drawing.Point(321, 182);
            this.LblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDatosAdicionales.Name = "LblDatosAdicionales";
            this.LblDatosAdicionales.Size = new System.Drawing.Size(132, 19);
            this.LblDatosAdicionales.TabIndex = 11;
            this.LblDatosAdicionales.Text = "Datos Adicionales";
            // 
            // LblRolEmpleado
            // 
            this.LblRolEmpleado.AutoSize = true;
            this.LblRolEmpleado.Depth = 0;
            this.LblRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRolEmpleado.Location = new System.Drawing.Point(321, 29);
            this.LblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRolEmpleado.Name = "LblRolEmpleado";
            this.LblRolEmpleado.Size = new System.Drawing.Size(102, 19);
            this.LblRolEmpleado.TabIndex = 10;
            this.LblRolEmpleado.Text = "Rol Empleado";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(464, 30);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 21);
            this.cbRole.TabIndex = 9;
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(325, 204);
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(260, 20);
            this.txtDatosAdicionales.TabIndex = 8;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Hint = "Email";
            this.TxtEmail.Location = new System.Drawing.Point(37, 204);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.Size = new System.Drawing.Size(260, 23);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Hint = "Telefono";
            this.TxtTelefono.Location = new System.Drawing.Point(37, 163);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.Size = new System.Drawing.Size(260, 23);
            this.TxtTelefono.TabIndex = 5;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.UseSystemPasswordChar = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Depth = 0;
            this.TxtDireccion.Hint = "Dirección";
            this.TxtDireccion.Location = new System.Drawing.Point(37, 121);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.Size = new System.Drawing.Size(260, 23);
            this.TxtDireccion.TabIndex = 4;
            this.TxtDireccion.TabStop = false;
            this.TxtDireccion.UseSystemPasswordChar = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "Documento";
            this.TxtDocumento.Location = new System.Drawing.Point(37, 76);
            this.TxtDocumento.MaxLength = 32767;
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(260, 23);
            this.TxtDocumento.TabIndex = 3;
            this.TxtDocumento.TabStop = false;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "Nombre Empleado";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(37, 25);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(260, 23);
            this.txtNombreEmpleado.TabIndex = 2;
            this.txtNombreEmpleado.TabStop = false;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.LblAdministracionEmpleados);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialLabel LblAdministracionEmpleados;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LblDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel LblRolEmpleado;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialLabel LblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtRetiro;
        private MaterialSkin.Controls.MaterialLabel LblFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.TextBox TxtIdEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}