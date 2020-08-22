namespace Plantilla_Sistema_Facturacion
{
    partial class FrmSecurity
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
            this.BtnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblAdministracionDeUsuariosDelSistema = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(664, 151);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(83, 36);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(664, 109);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 19;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.AutoSize = true;
            this.BtnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConsultar.Depth = 0;
            this.BtnConsultar.Icon = null;
            this.BtnConsultar.Location = new System.Drawing.Point(664, 67);
            this.BtnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Primary = true;
            this.BtnConsultar.Size = new System.Drawing.Size(100, 36);
            this.BtnConsultar.TabIndex = 18;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // LblAdministracionDeUsuariosDelSistema
            // 
            this.LblAdministracionDeUsuariosDelSistema.AutoSize = true;
            this.LblAdministracionDeUsuariosDelSistema.Depth = 0;
            this.LblAdministracionDeUsuariosDelSistema.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdministracionDeUsuariosDelSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdministracionDeUsuariosDelSistema.Location = new System.Drawing.Point(335, 17);
            this.LblAdministracionDeUsuariosDelSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdministracionDeUsuariosDelSistema.Name = "LblAdministracionDeUsuariosDelSistema";
            this.LblAdministracionDeUsuariosDelSistema.Size = new System.Drawing.Size(329, 19);
            this.LblAdministracionDeUsuariosDelSistema.TabIndex = 17;
            this.LblAdministracionDeUsuariosDelSistema.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtClave);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.LblEmpleado);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Location = new System.Drawing.Point(31, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 208);
            this.panel1.TabIndex = 16;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Depth = 0;
            this.LblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEmpleado.Location = new System.Drawing.Point(33, 30);
            this.LblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(166, 19);
            this.LblEmpleado.TabIndex = 11;
            this.LblEmpleado.Text = "Descripcion Detalle Rol";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Hint = "Usuario";
            this.TxtUsuario.Location = new System.Drawing.Point(37, 97);
            this.TxtUsuario.MaxLength = 32767;
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(260, 23);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.TabStop = false;
            this.TxtUsuario.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // TxtClave
            // 
            this.TxtClave.Depth = 0;
            this.TxtClave.Hint = "Clave";
            this.TxtClave.Location = new System.Drawing.Point(37, 136);
            this.TxtClave.MaxLength = 32767;
            this.TxtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '\0';
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.Size = new System.Drawing.Size(260, 23);
            this.TxtClave.TabIndex = 13;
            this.TxtClave.TabStop = false;
            this.TxtClave.UseSystemPasswordChar = false;
            // 
            // FrmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.LblAdministracionDeUsuariosDelSistema);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSecurity";
            this.Text = "FrmSecurity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConsultar;
        private MaterialSkin.Controls.MaterialLabel LblAdministracionDeUsuariosDelSistema;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LblEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtClave;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}