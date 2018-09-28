namespace TiendaProductosG1_2019_1
{
    partial class FormTarjeta
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
            this.mskNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.mskCVV = new System.Windows.Forms.MaskedTextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbCVV = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.mskFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTotalPagar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskNumeroTarjeta
            // 
            this.mskNumeroTarjeta.Location = new System.Drawing.Point(86, 48);
            this.mskNumeroTarjeta.Mask = "0000-0000-0000-0000";
            this.mskNumeroTarjeta.Name = "mskNumeroTarjeta";
            this.mskNumeroTarjeta.Size = new System.Drawing.Size(129, 20);
            this.mskNumeroTarjeta.TabIndex = 0;
            // 
            // mskCVV
            // 
            this.mskCVV.Location = new System.Drawing.Point(86, 161);
            this.mskCVV.Mask = "000";
            this.mskCVV.Name = "mskCVV";
            this.mskCVV.Size = new System.Drawing.Size(52, 20);
            this.mskCVV.TabIndex = 1;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(83, 21);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(95, 13);
            this.lbNumero.TabIndex = 2;
            this.lbNumero.Text = "Numero de Tarjeta";
            // 
            // lbCVV
            // 
            this.lbCVV.AutoSize = true;
            this.lbCVV.Location = new System.Drawing.Point(84, 132);
            this.lbCVV.Name = "lbCVV";
            this.lbCVV.Size = new System.Drawing.Size(28, 13);
            this.lbCVV.TabIndex = 3;
            this.lbCVV.Text = "CVV";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(83, 201);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(112, 13);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Fecha de vencimiento";
            // 
            // mskFechaVencimiento
            // 
            this.mskFechaVencimiento.Location = new System.Drawing.Point(86, 230);
            this.mskFechaVencimiento.Mask = "00/00";
            this.mskFechaVencimiento.Name = "mskFechaVencimiento";
            this.mskFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.mskFechaVencimiento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MM/AA";
            // 
            // btnTotalPagar
            // 
            this.btnTotalPagar.Location = new System.Drawing.Point(86, 315);
            this.btnTotalPagar.Name = "btnTotalPagar";
            this.btnTotalPagar.Size = new System.Drawing.Size(129, 23);
            this.btnTotalPagar.TabIndex = 7;
            this.btnTotalPagar.Text = "Pagar";
            this.btnTotalPagar.UseVisualStyleBackColor = true;
            this.btnTotalPagar.Click += new System.EventHandler(this.btnTotalPagar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(84, 277);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(43, 13);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total: $";
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Location = new System.Drawing.Point(133, 277);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(13, 13);
            this.lbTotalPagar.TabIndex = 9;
            this.lbTotalPagar.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TiendaProductosG1_2019_1.Properties.Resources.Visa;
            this.pictureBox2.Location = new System.Drawing.Point(87, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiendaProductosG1_2019_1.Properties.Resources.MasterCard;
            this.pictureBox1.Location = new System.Drawing.Point(156, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 350);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTotalPagar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnTotalPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskFechaVencimiento);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbCVV);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.mskCVV);
            this.Controls.Add(this.mskNumeroTarjeta);
            this.Name = "FormTarjeta";
            this.Text = "FormTarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskNumeroTarjeta;
        private System.Windows.Forms.MaskedTextBox mskCVV;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbCVV;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.MaskedTextBox mskFechaVencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTotalPagar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}