namespace Plantilla_Sistema_Facturacion
{
    partial class FrmHelp
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
            this.LblQueNecesitas = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBucar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LblQueNecesitas
            // 
            this.LblQueNecesitas.AutoSize = true;
            this.LblQueNecesitas.Depth = 0;
            this.LblQueNecesitas.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblQueNecesitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblQueNecesitas.Location = new System.Drawing.Point(310, 35);
            this.LblQueNecesitas.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblQueNecesitas.Name = "LblQueNecesitas";
            this.LblQueNecesitas.Size = new System.Drawing.Size(121, 19);
            this.LblQueNecesitas.TabIndex = 18;
            this.LblQueNecesitas.Text = "¿Que Necesitas?";
            // 
            // TxtBucar
            // 
            this.TxtBucar.Location = new System.Drawing.Point(221, 96);
            this.TxtBucar.Name = "TxtBucar";
            this.TxtBucar.Size = new System.Drawing.Size(252, 20);
            this.TxtBucar.TabIndex = 19;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(497, 87);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscar.TabIndex = 20;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBucar);
            this.Controls.Add(this.LblQueNecesitas);
            this.Name = "FrmHelp";
            this.Text = "FrmHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblQueNecesitas;
        private System.Windows.Forms.TextBox TxtBucar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
    }
}