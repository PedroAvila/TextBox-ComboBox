namespace TextBoxComboBox
{
    partial class Form1
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
            this.txtNumero = new GlobalTech.TextBoxControl.TextBoxUniversal();
            this.txtLetra = new GlobalTech.TextBoxControl.TextBoxUniversal();
            this.txtDecimal = new GlobalTech.TextBoxControl.TextBoxUniversal();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategoria = new GlobalTech.TextBoxControl.EntitySelectorCombo();
            this.textBoxUniversal1 = new GlobalTech.TextBoxControl.TextBoxUniversal();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.AcceptDecimal = false;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNumero.Location = new System.Drawing.Point(101, 41);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.NumeroDecimales = ((short)(2));
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.SombrearTexto = false;
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TipoControl = GlobalTech.TextBoxControl.TextBoxUniversal.TipoDato.Enteros;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtNumero.WaterMarkText = "";
            // 
            // txtLetra
            // 
            this.txtLetra.AcceptDecimal = false;
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLetra.Location = new System.Drawing.Point(101, 67);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.NumeroDecimales = ((short)(2));
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.SombrearTexto = false;
            this.txtLetra.TabIndex = 1;
            this.txtLetra.TipoControl = GlobalTech.TextBoxControl.TextBoxUniversal.TipoDato.Letras;
            this.txtLetra.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLetra.WaterMarkText = "";
            // 
            // txtDecimal
            // 
            this.txtDecimal.AcceptDecimal = true;
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDecimal.Location = new System.Drawing.Point(101, 93);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.NumeroDecimales = ((short)(2));
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.SombrearTexto = false;
            this.txtDecimal.TabIndex = 2;
            this.txtDecimal.TipoControl = GlobalTech.TextBoxControl.TextBoxUniversal.TipoDato.Numeric;
            this.txtDecimal.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtDecimal.WaterMarkText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Números:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Letras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decimales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(101, 151);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 7;
            // 
            // textBoxUniversal1
            // 
            this.textBoxUniversal1.AcceptDecimal = false;
            this.textBoxUniversal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxUniversal1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUniversal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxUniversal1.Location = new System.Drawing.Point(101, 119);
            this.textBoxUniversal1.Name = "textBoxUniversal1";
            this.textBoxUniversal1.NumeroDecimales = ((short)(2));
            this.textBoxUniversal1.Size = new System.Drawing.Size(100, 20);
            this.textBoxUniversal1.SombrearTexto = false;
            this.textBoxUniversal1.TabIndex = 8;
            this.textBoxUniversal1.TipoControl = GlobalTech.TextBoxControl.TextBoxUniversal.TipoDato.AlfaNumerico;
            this.textBoxUniversal1.WaterMarkColor = System.Drawing.Color.Gray;
            this.textBoxUniversal1.WaterMarkText = "Nuevo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuario:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUniversal1);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.txtNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GlobalTech.TextBoxControl.TextBoxUniversal txtNumero;
        private GlobalTech.TextBoxControl.TextBoxUniversal txtLetra;
        private GlobalTech.TextBoxControl.TextBoxUniversal txtDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GlobalTech.TextBoxControl.EntitySelectorCombo cboCategoria;
        private GlobalTech.TextBoxControl.TextBoxUniversal textBoxUniversal1;
        private System.Windows.Forms.Label label5;
    }
}

