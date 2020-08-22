namespace Plantilla_Sistema_Facturacion
{
    partial class FrmReport
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
            this.LblGeneradorDeInformesDeFacturacion = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.LblFechaFin = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblSeleccioneInforme = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LblOrdenarPor = new MaterialSkin.Controls.MaterialLabel();
            this.RbEnPantalla = new System.Windows.Forms.RadioButton();
            this.RbPDF = new System.Windows.Forms.RadioButton();
            this.RbExcel = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblGeneradorDeInformesDeFacturacion
            // 
            this.LblGeneradorDeInformesDeFacturacion.AutoSize = true;
            this.LblGeneradorDeInformesDeFacturacion.Depth = 0;
            this.LblGeneradorDeInformesDeFacturacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblGeneradorDeInformesDeFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblGeneradorDeInformesDeFacturacion.Location = new System.Drawing.Point(241, 26);
            this.LblGeneradorDeInformesDeFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblGeneradorDeInformesDeFacturacion.Name = "LblGeneradorDeInformesDeFacturacion";
            this.LblGeneradorDeInformesDeFacturacion.Size = new System.Drawing.Size(324, 19);
            this.LblGeneradorDeInformesDeFacturacion.TabIndex = 27;
            this.LblGeneradorDeInformesDeFacturacion.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbExcel);
            this.panel1.Controls.Add(this.RbPDF);
            this.panel1.Controls.Add(this.RbEnPantalla);
            this.panel1.Controls.Add(this.LblOrdenarPor);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.LblFechaInicio);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.LblFechaFin);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.LblSeleccioneInforme);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(32, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 222);
            this.panel1.TabIndex = 26;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(412, 23);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 26;
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.Depth = 0;
            this.LblFechaFin.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaFin.Location = new System.Drawing.Point(318, 60);
            this.LblFechaFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(73, 19);
            this.LblFechaFin.TabIndex = 25;
            this.LblFechaFin.Text = "Fecha Fin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // LblSeleccioneInforme
            // 
            this.LblSeleccioneInforme.AutoSize = true;
            this.LblSeleccioneInforme.Depth = 0;
            this.LblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblSeleccioneInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSeleccioneInforme.Location = new System.Drawing.Point(20, 19);
            this.LblSeleccioneInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSeleccioneInforme.Name = "LblSeleccioneInforme";
            this.LblSeleccioneInforme.Size = new System.Drawing.Size(139, 19);
            this.LblSeleccioneInforme.TabIndex = 23;
            this.LblSeleccioneInforme.Text = "Seleccione Informe";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(354, 326);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 25;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnGenerarInforme
            // 
            this.BtnGenerarInforme.AutoSize = true;
            this.BtnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGenerarInforme.Depth = 0;
            this.BtnGenerarInforme.Icon = null;
            this.BtnGenerarInforme.Location = new System.Drawing.Point(197, 326);
            this.BtnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGenerarInforme.Name = "BtnGenerarInforme";
            this.BtnGenerarInforme.Primary = true;
            this.BtnGenerarInforme.Size = new System.Drawing.Size(144, 36);
            this.BtnGenerarInforme.TabIndex = 24;
            this.BtnGenerarInforme.Text = "Generar Informe";
            this.BtnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Depth = 0;
            this.LblFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFechaInicio.Location = new System.Drawing.Point(20, 60);
            this.LblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.LblFechaInicio.TabIndex = 27;
            this.LblFechaInicio.Text = "Fecha Inicio";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // LblOrdenarPor
            // 
            this.LblOrdenarPor.AutoSize = true;
            this.LblOrdenarPor.Depth = 0;
            this.LblOrdenarPor.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblOrdenarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblOrdenarPor.Location = new System.Drawing.Point(318, 22);
            this.LblOrdenarPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblOrdenarPor.Name = "LblOrdenarPor";
            this.LblOrdenarPor.Size = new System.Drawing.Size(88, 19);
            this.LblOrdenarPor.TabIndex = 29;
            this.LblOrdenarPor.Text = "Ordenar Por";
            // 
            // RbEnPantalla
            // 
            this.RbEnPantalla.AutoSize = true;
            this.RbEnPantalla.Location = new System.Drawing.Point(165, 168);
            this.RbEnPantalla.Name = "RbEnPantalla";
            this.RbEnPantalla.Size = new System.Drawing.Size(79, 17);
            this.RbEnPantalla.TabIndex = 30;
            this.RbEnPantalla.TabStop = true;
            this.RbEnPantalla.Text = "En Pantalla";
            this.RbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // RbPDF
            // 
            this.RbPDF.AutoSize = true;
            this.RbPDF.Location = new System.Drawing.Point(256, 168);
            this.RbPDF.Name = "RbPDF";
            this.RbPDF.Size = new System.Drawing.Size(46, 17);
            this.RbPDF.TabIndex = 31;
            this.RbPDF.TabStop = true;
            this.RbPDF.Text = "PDF";
            this.RbPDF.UseVisualStyleBackColor = true;
            // 
            // RbExcel
            // 
            this.RbExcel.AutoSize = true;
            this.RbExcel.Location = new System.Drawing.Point(322, 168);
            this.RbExcel.Name = "RbExcel";
            this.RbExcel.Size = new System.Drawing.Size(51, 17);
            this.RbExcel.TabIndex = 32;
            this.RbExcel.TabStop = true;
            this.RbExcel.Text = "Excel";
            this.RbExcel.UseVisualStyleBackColor = true;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblGeneradorDeInformesDeFacturacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGenerarInforme);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LblGeneradorDeInformesDeFacturacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox3;
        private MaterialSkin.Controls.MaterialLabel LblFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel LblSeleccioneInforme;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGenerarInforme;
        private MaterialSkin.Controls.MaterialLabel LblFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialLabel LblOrdenarPor;
        private System.Windows.Forms.RadioButton RbExcel;
        private System.Windows.Forms.RadioButton RbPDF;
        private System.Windows.Forms.RadioButton RbEnPantalla;
    }
}