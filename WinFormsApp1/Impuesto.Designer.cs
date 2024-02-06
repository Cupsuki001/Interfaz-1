namespace WinFormsApp1
{
    partial class Impuesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDtarjeta = new System.Windows.Forms.RadioButton();
            this.RDefectivo = new System.Windows.Forms.RadioButton();
            this.MSKsubtt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXBtot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TXBdesc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(174, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.RDtarjeta);
            this.groupBox1.Controls.Add(this.RDefectivo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de pago";
            // 
            // RDtarjeta
            // 
            this.RDtarjeta.AutoSize = true;
            this.RDtarjeta.Location = new System.Drawing.Point(26, 67);
            this.RDtarjeta.Name = "RDtarjeta";
            this.RDtarjeta.Size = new System.Drawing.Size(59, 19);
            this.RDtarjeta.TabIndex = 3;
            this.RDtarjeta.TabStop = true;
            this.RDtarjeta.Text = "Tarjeta";
            this.RDtarjeta.UseVisualStyleBackColor = true;
            // 
            // RDefectivo
            // 
            this.RDefectivo.AutoSize = true;
            this.RDefectivo.Location = new System.Drawing.Point(26, 33);
            this.RDefectivo.Name = "RDefectivo";
            this.RDefectivo.Size = new System.Drawing.Size(67, 19);
            this.RDefectivo.TabIndex = 2;
            this.RDefectivo.TabStop = true;
            this.RDefectivo.Text = "Efectivo";
            this.RDefectivo.UseVisualStyleBackColor = true;
            // 
            // MSKsubtt
            // 
            this.MSKsubtt.Location = new System.Drawing.Point(410, 95);
            this.MSKsubtt.Mask = "99999";
            this.MSKsubtt.Name = "MSKsubtt";
            this.MSKsubtt.Size = new System.Drawing.Size(100, 23);
            this.MSKsubtt.TabIndex = 2;
            this.MSKsubtt.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(322, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(326, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // TXBtot
            // 
            this.TXBtot.Location = new System.Drawing.Point(410, 140);
            this.TXBtot.Name = "TXBtot";
            this.TXBtot.Size = new System.Drawing.Size(100, 23);
            this.TXBtot.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(326, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descuento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(45, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNsalir.Location = new System.Drawing.Point(170, 253);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 9;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.Location = new System.Drawing.Point(322, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TXBdesc
            // 
            this.TXBdesc.Location = new System.Drawing.Point(410, 180);
            this.TXBdesc.Name = "TXBdesc";
            this.TXBdesc.Size = new System.Drawing.Size(100, 23);
            this.TXBdesc.TabIndex = 7;
            // 
            // Impuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(559, 288);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXBdesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXBtot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSKsubtt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Impuesto";
            this.Text = "Impuesto";
            this.Load += new System.EventHandler(this.Impuesto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton RDtarjeta;
        private RadioButton RDefectivo;
        private MaskedTextBox MSKsubtt;
        private Label label2;
        private Label label3;
        private TextBox TXBtot;
        private Label label4;
        private Button button1;
        private Button BTNsalir;
        private Button button3;
        private TextBox TXBdesc;
    }
}