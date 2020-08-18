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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.Tabla = new System.Windows.Forms.TabPage();
            this.Facturación = new System.Windows.Forms.TabPage();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnPrincipal.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnMenu);
            this.pnPrincipal.Location = new System.Drawing.Point(1, 65);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1197, 584);
            this.pnPrincipal.TabIndex = 0;
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
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 558);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // Tabla
            // 
            this.Tabla.Location = new System.Drawing.Point(4, 22);
            this.Tabla.Name = "Tabla";
            this.Tabla.Padding = new System.Windows.Forms.Padding(3);
            this.Tabla.Size = new System.Drawing.Size(192, 558);
            this.Tabla.TabIndex = 1;
            this.Tabla.Text = "Administración de tablas";
            this.Tabla.UseVisualStyleBackColor = true;
            // 
            // Facturación
            // 
            this.Facturación.Location = new System.Drawing.Point(4, 22);
            this.Facturación.Name = "Facturación";
            this.Facturación.Size = new System.Drawing.Size(192, 558);
            this.Facturación.TabIndex = 2;
            this.Facturación.Text = "Facturación";
            this.Facturación.UseVisualStyleBackColor = true;
            // 
            // Seguridad
            // 
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 558);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            this.Seguridad.UseVisualStyleBackColor = true;
            // 
            // Acerca
            // 
            this.Acerca.Location = new System.Drawing.Point(4, 22);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 558);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Acerca";
            this.Acerca.UseVisualStyleBackColor = true;
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
    }
}