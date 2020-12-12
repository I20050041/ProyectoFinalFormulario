namespace ProyectoFinalFormulario.formulario
{
    partial class AltaChofer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.cboLicencia = new System.Windows.Forms.ComboBox();
            this.btnAgregarChofer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de licencia";
            // 
            // cboLicencia
            // 
            this.cboLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLicencia.FormattingEnabled = true;
            this.cboLicencia.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboLicencia.Location = new System.Drawing.Point(104, 280);
            this.cboLicencia.Name = "cboLicencia";
            this.cboLicencia.Size = new System.Drawing.Size(290, 24);
            this.cboLicencia.TabIndex = 7;
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Location = new System.Drawing.Point(140, 335);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(217, 36);
            this.btnAgregarChofer.TabIndex = 8;
            this.btnAgregarChofer.Text = "Agregar Chofer";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // AltaChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(564, 531);
            this.Controls.Add(this.btnAgregarChofer);
            this.Controls.Add(this.cboLicencia);
            this.Controls.Add(this.label4);
            this.Name = "AltaChofer";
            this.Text = "AltaChofer";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cboLicencia, 0);
            this.Controls.SetChildIndex(this.btnAgregarChofer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLicencia;
        private System.Windows.Forms.Button btnAgregarChofer;
    }
}
