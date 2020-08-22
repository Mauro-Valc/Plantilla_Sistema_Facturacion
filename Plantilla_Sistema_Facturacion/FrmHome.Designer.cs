namespace Plantilla_Sistema_Facturacion
{
    partial class FrmHome
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
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tabla = new System.Windows.Forms.TabPage();
            this.btnCategorias = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Facturación = new System.Windows.Forms.TabPage();
            this.btnInformes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFacturas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.btnSeguridad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRoles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEmpleados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.btnAcercaDe = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAyuda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnPrincipal.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Facturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.PnlContenedor);
            this.pnPrincipal.Controls.Add(this.pnMenu);
            this.pnPrincipal.Location = new System.Drawing.Point(1, 65);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1197, 584);
            this.pnPrincipal.TabIndex = 0;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(997, 584);
            this.PnlContenedor.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.TbpMenu);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(200, 584);
            this.pnMenu.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.Tabla);
            this.TbpMenu.Controls.Add(this.Facturación);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.Acerca);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(200, 584);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 558);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(6, 374);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Plantilla_Sistema_Facturacion.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tabla
            // 
            this.Tabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Tabla.Controls.Add(this.btnCategorias);
            this.Tabla.Controls.Add(this.btnProductos);
            this.Tabla.Controls.Add(this.btnCliente);
            this.Tabla.Controls.Add(this.pictureBox2);
            this.Tabla.Location = new System.Drawing.Point(4, 22);
            this.Tabla.Name = "Tabla";
            this.Tabla.Padding = new System.Windows.Forms.Padding(3);
            this.Tabla.Size = new System.Drawing.Size(192, 558);
            this.Tabla.TabIndex = 1;
            this.Tabla.Text = "Administración de tablas";
            // 
            // btnCategorias
            // 
            this.btnCategorias.AutoSize = true;
            this.btnCategorias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCategorias.Depth = 0;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCategorias.Icon = null;
            this.btnCategorias.Location = new System.Drawing.Point(7, 230);
            this.btnCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Primary = true;
            this.btnCategorias.Size = new System.Drawing.Size(104, 36);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Tag = "";
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.AutoSize = true;
            this.btnProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductos.Depth = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnProductos.Icon = null;
            this.btnProductos.Location = new System.Drawing.Point(7, 179);
            this.btnProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Primary = true;
            this.btnProductos.Size = new System.Drawing.Size(101, 36);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Tag = "";
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCliente.Depth = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCliente.Icon = null;
            this.btnCliente.Location = new System.Drawing.Point(7, 129);
            this.btnCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Primary = true;
            this.btnCliente.Size = new System.Drawing.Size(83, 36);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Tag = "";
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Plantilla_Sistema_Facturacion.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Facturación
            // 
            this.Facturación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Facturación.Controls.Add(this.btnInformes);
            this.Facturación.Controls.Add(this.btnFacturas);
            this.Facturación.Controls.Add(this.pictureBox3);
            this.Facturación.Location = new System.Drawing.Point(4, 22);
            this.Facturación.Name = "Facturación";
            this.Facturación.Size = new System.Drawing.Size(192, 558);
            this.Facturación.TabIndex = 2;
            this.Facturación.Text = "Facturación";
            // 
            // btnInformes
            // 
            this.btnInformes.AutoSize = true;
            this.btnInformes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInformes.Depth = 0;
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnInformes.Icon = null;
            this.btnInformes.Location = new System.Drawing.Point(25, 193);
            this.btnInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Primary = true;
            this.btnInformes.Size = new System.Drawing.Size(88, 36);
            this.btnInformes.TabIndex = 7;
            this.btnInformes.Tag = "";
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnFacturas
            // 
            this.btnFacturas.AutoSize = true;
            this.btnFacturas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFacturas.Depth = 0;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnFacturas.Icon = null;
            this.btnFacturas.Location = new System.Drawing.Point(25, 135);
            this.btnFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Primary = true;
            this.btnFacturas.Size = new System.Drawing.Size(90, 36);
            this.btnFacturas.TabIndex = 6;
            this.btnFacturas.Tag = "";
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Plantilla_Sistema_Facturacion.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Seguridad.Controls.Add(this.btnSeguridad);
            this.Seguridad.Controls.Add(this.btnRoles);
            this.Seguridad.Controls.Add(this.btnEmpleados);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 558);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.AutoSize = true;
            this.btnSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeguridad.Depth = 0;
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSeguridad.Icon = null;
            this.btnSeguridad.Location = new System.Drawing.Point(18, 230);
            this.btnSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Primary = true;
            this.btnSeguridad.Size = new System.Drawing.Size(95, 36);
            this.btnSeguridad.TabIndex = 9;
            this.btnSeguridad.Tag = "";
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            this.btnRoles.AutoSize = true;
            this.btnRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRoles.Depth = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRoles.Icon = null;
            this.btnRoles.Location = new System.Drawing.Point(18, 188);
            this.btnRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Primary = true;
            this.btnRoles.Size = new System.Drawing.Size(62, 36);
            this.btnRoles.TabIndex = 8;
            this.btnRoles.Tag = "";
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSize = true;
            this.btnEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleados.Depth = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEmpleados.Icon = null;
            this.btnEmpleados.Location = new System.Drawing.Point(18, 146);
            this.btnEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Primary = true;
            this.btnEmpleados.Size = new System.Drawing.Size(101, 36);
            this.btnEmpleados.TabIndex = 7;
            this.btnEmpleados.Tag = "";
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Plantilla_Sistema_Facturacion.Properties.Resources.pngwing_com;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Acerca.Controls.Add(this.btnAcercaDe);
            this.Acerca.Controls.Add(this.btnAyuda);
            this.Acerca.Controls.Add(this.pictureBox5);
            this.Acerca.Location = new System.Drawing.Point(4, 22);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 558);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Acerca";
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.AutoSize = true;
            this.btnAcercaDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcercaDe.Depth = 0;
            this.btnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAcercaDe.Icon = null;
            this.btnAcercaDe.Location = new System.Drawing.Point(38, 204);
            this.btnAcercaDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Primary = true;
            this.btnAcercaDe.Size = new System.Drawing.Size(105, 36);
            this.btnAcercaDe.TabIndex = 9;
            this.btnAcercaDe.Tag = "";
            this.btnAcercaDe.Text = "Acerca de...";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.AutoSize = true;
            this.btnAyuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAyuda.Depth = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAyuda.Icon = null;
            this.btnAyuda.Location = new System.Drawing.Point(38, 162);
            this.btnAyuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Primary = true;
            this.btnAyuda.Size = new System.Drawing.Size(66, 36);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Tag = "";
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Plantilla_Sistema_Facturacion.Properties.Resources.pngwing_com;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(109, 95);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // TabOpcionesMenu
            // 
            this.TabOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.TabOpcionesMenu.Depth = 0;
            this.TabOpcionesMenu.Location = new System.Drawing.Point(284, 25);
            this.TabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpcionesMenu.Name = "TabOpcionesMenu";
            this.TabOpcionesMenu.Size = new System.Drawing.Size(728, 34);
            this.TabOpcionesMenu.TabIndex = 1;
            this.TabOpcionesMenu.Text = "materialTabSelector1";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.TabOpcionesMenu);
            this.Controls.Add(this.pnPrincipal);
            this.Name = "FrmHome";
            this.Sizable = false;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.pnPrincipal.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tabla.ResumeLayout(false);
            this.Tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Facturación.ResumeLayout(false);
            this.Facturación.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Seguridad.ResumeLayout(false);
            this.Seguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Acerca.ResumeLayout(false);
            this.Acerca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel pnMenu;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Tabla;
        private System.Windows.Forms.TabPage Facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcionesMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel PnlContenedor;
        private MaterialSkin.Controls.MaterialRaisedButton btnCategorias;
        private MaterialSkin.Controls.MaterialRaisedButton btnProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnInformes;
        private MaterialSkin.Controls.MaterialRaisedButton btnFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnSeguridad;
        private MaterialSkin.Controls.MaterialRaisedButton btnRoles;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnAcercaDe;
        private MaterialSkin.Controls.MaterialRaisedButton btnAyuda;
    }
}