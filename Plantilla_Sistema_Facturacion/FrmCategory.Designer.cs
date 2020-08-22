namespace Plantilla_Sistema_Facturacion
{
    partial class FrmCategory
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
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblCategoriaDeProductos = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCodigoCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(650, 179);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(650, 137);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(650, 95);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 10;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscarCategoria);
            this.panel2.Location = new System.Drawing.Point(41, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 263);
            this.panel2.TabIndex = 13;
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
            // LblCategoriaDeProductos
            // 
            this.LblCategoriaDeProductos.AutoSize = true;
            this.LblCategoriaDeProductos.Depth = 0;
            this.LblCategoriaDeProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCategoriaDeProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCategoriaDeProductos.Location = new System.Drawing.Point(314, 20);
            this.LblCategoriaDeProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCategoriaDeProductos.Name = "LblCategoriaDeProductos";
            this.LblCategoriaDeProductos.Size = new System.Drawing.Size(203, 19);
            this.LblCategoriaDeProductos.TabIndex = 15;
            this.LblCategoriaDeProductos.Text = "CATEGORIA DE PRODUCTOS";
            // 
            // TxtCodigoCategoria
            // 
            this.TxtCodigoCategoria.Depth = 0;
            this.TxtCodigoCategoria.Hint = "Codigo categoria";
            this.TxtCodigoCategoria.Location = new System.Drawing.Point(37, 25);
            this.TxtCodigoCategoria.MaxLength = 32767;
            this.TxtCodigoCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigoCategoria.Name = "TxtCodigoCategoria";
            this.TxtCodigoCategoria.PasswordChar = '\0';
            this.TxtCodigoCategoria.SelectedText = "";
            this.TxtCodigoCategoria.SelectionLength = 0;
            this.TxtCodigoCategoria.SelectionStart = 0;
            this.TxtCodigoCategoria.Size = new System.Drawing.Size(260, 23);
            this.TxtCodigoCategoria.TabIndex = 2;
            this.TxtCodigoCategoria.TabStop = false;
            this.TxtCodigoCategoria.UseSystemPasswordChar = false;
            // 
            // TxtNombreCategoria
            // 
            this.TxtNombreCategoria.Depth = 0;
            this.TxtNombreCategoria.Hint = "Nombre categoria";
            this.TxtNombreCategoria.Location = new System.Drawing.Point(37, 76);
            this.TxtNombreCategoria.MaxLength = 32767;
            this.TxtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreCategoria.Name = "TxtNombreCategoria";
            this.TxtNombreCategoria.PasswordChar = '\0';
            this.TxtNombreCategoria.SelectedText = "";
            this.TxtNombreCategoria.SelectionLength = 0;
            this.TxtNombreCategoria.SelectionStart = 0;
            this.TxtNombreCategoria.Size = new System.Drawing.Size(260, 23);
            this.TxtNombreCategoria.TabIndex = 3;
            this.TxtNombreCategoria.TabStop = false;
            this.TxtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtNombreCategoria);
            this.panel1.Controls.Add(this.TxtCodigoCategoria);
            this.panel1.Location = new System.Drawing.Point(41, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 147);
            this.panel1.TabIndex = 14;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 530);
            this.Controls.Add(this.LblCategoriaDeProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCategoria;
        private MaterialSkin.Controls.MaterialLabel LblCategoriaDeProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigoCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreCategoria;
        private System.Windows.Forms.Panel panel1;
    }
}