namespace Plantilla_Sistema_Facturacion
{
    partial class FrmRole
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblDescripcionDetalleRol = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblRolDeEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscarRol);
            this.panel2.Location = new System.Drawing.Point(50, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 263);
            this.panel2.TabIndex = 16;
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
            // TxtBuscarRol
            // 
            this.TxtBuscarRol.Depth = 0;
            this.TxtBuscarRol.Hint = "Buscar Rol";
            this.TxtBuscarRol.Location = new System.Drawing.Point(37, 25);
            this.TxtBuscarRol.MaxLength = 32767;
            this.TxtBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarRol.Name = "TxtBuscarRol";
            this.TxtBuscarRol.PasswordChar = '\0';
            this.TxtBuscarRol.SelectedText = "";
            this.TxtBuscarRol.SelectionLength = 0;
            this.TxtBuscarRol.SelectionStart = 0;
            this.TxtBuscarRol.Size = new System.Drawing.Size(363, 23);
            this.TxtBuscarRol.TabIndex = 2;
            this.TxtBuscarRol.TabStop = false;
            this.TxtBuscarRol.UseSystemPasswordChar = false;
            // 
            // TxtNombreRol
            // 
            this.TxtNombreRol.Depth = 0;
            this.TxtNombreRol.Hint = "Nombre Rol";
            this.TxtNombreRol.Location = new System.Drawing.Point(37, 25);
            this.TxtNombreRol.MaxLength = 32767;
            this.TxtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreRol.Name = "TxtNombreRol";
            this.TxtNombreRol.PasswordChar = '\0';
            this.TxtNombreRol.SelectedText = "";
            this.TxtNombreRol.SelectionLength = 0;
            this.TxtNombreRol.SelectionStart = 0;
            this.TxtNombreRol.Size = new System.Drawing.Size(260, 23);
            this.TxtNombreRol.TabIndex = 2;
            this.TxtNombreRol.TabStop = false;
            this.TxtNombreRol.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 8;
            // 
            // LblDescripcionDetalleRol
            // 
            this.LblDescripcionDetalleRol.AutoSize = true;
            this.LblDescripcionDetalleRol.Depth = 0;
            this.LblDescripcionDetalleRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDescripcionDetalleRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescripcionDetalleRol.Location = new System.Drawing.Point(33, 92);
            this.LblDescripcionDetalleRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDescripcionDetalleRol.Name = "LblDescripcionDetalleRol";
            this.LblDescripcionDetalleRol.Size = new System.Drawing.Size(166, 19);
            this.LblDescripcionDetalleRol.TabIndex = 11;
            this.LblDescripcionDetalleRol.Text = "Descripcion Detalle Rol";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblDescripcionDetalleRol);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TxtNombreRol);
            this.panel1.Location = new System.Drawing.Point(50, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 208);
            this.panel1.TabIndex = 11;
            // 
            // LblRolDeEmpleados
            // 
            this.LblRolDeEmpleados.AutoSize = true;
            this.LblRolDeEmpleados.Depth = 0;
            this.LblRolDeEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblRolDeEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRolDeEmpleados.Location = new System.Drawing.Point(354, 18);
            this.LblRolDeEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRolDeEmpleados.Name = "LblRolDeEmpleados";
            this.LblRolDeEmpleados.Size = new System.Drawing.Size(150, 19);
            this.LblRolDeEmpleados.TabIndex = 12;
            this.LblRolDeEmpleados.Text = "ROL DE EMPLEADOS";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(683, 68);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 13;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(683, 110);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 14;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(683, 152);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.LblRolDeEmpleados);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRole";
            this.Text = "FrmRole";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreRol;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel LblDescripcionDetalleRol;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LblRolDeEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
    }
}