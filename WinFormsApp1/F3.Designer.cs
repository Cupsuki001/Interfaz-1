namespace WinFormsApp1
{
    partial class F3
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
            this.MSK2 = new System.Windows.Forms.MaskedTextBox();
            this.MSK1 = new System.Windows.Forms.MaskedTextBox();
            this.MSK4 = new System.Windows.Forms.MaskedTextBox();
            this.MSK3 = new System.Windows.Forms.MaskedTextBox();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.btnLIMP = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXBresul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MSK2
            // 
            this.MSK2.Location = new System.Drawing.Point(173, 94);
            this.MSK2.Mask = "999";
            this.MSK2.Name = "MSK2";
            this.MSK2.Size = new System.Drawing.Size(100, 23);
            this.MSK2.TabIndex = 0;
            this.MSK2.ValidatingType = typeof(int);
            // 
            // MSK1
            // 
            this.MSK1.Location = new System.Drawing.Point(29, 94);
            this.MSK1.Mask = "999";
            this.MSK1.Name = "MSK1";
            this.MSK1.Size = new System.Drawing.Size(100, 23);
            this.MSK1.TabIndex = 1;
            this.MSK1.ValidatingType = typeof(int);
            // 
            // MSK4
            // 
            this.MSK4.Location = new System.Drawing.Point(173, 157);
            this.MSK4.Mask = "999";
            this.MSK4.Name = "MSK4";
            this.MSK4.Size = new System.Drawing.Size(100, 23);
            this.MSK4.TabIndex = 2;
            this.MSK4.ValidatingType = typeof(int);
            // 
            // MSK3
            // 
            this.MSK3.Location = new System.Drawing.Point(29, 157);
            this.MSK3.Mask = "999";
            this.MSK3.Name = "MSK3";
            this.MSK3.Size = new System.Drawing.Size(100, 23);
            this.MSK3.TabIndex = 3;
            this.MSK3.ValidatingType = typeof(int);
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.Location = new System.Drawing.Point(325, 93);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(75, 23);
            this.btnCALCULAR.TabIndex = 4;
            this.btnCALCULAR.Text = "Calcular";
            this.btnCALCULAR.UseVisualStyleBackColor = true;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // btnLIMP
            // 
            this.btnLIMP.Location = new System.Drawing.Point(325, 156);
            this.btnLIMP.Name = "btnLIMP";
            this.btnLIMP.Size = new System.Drawing.Size(75, 23);
            this.btnLIMP.TabIndex = 5;
            this.btnLIMP.Text = "Limpiar";
            this.btnLIMP.UseVisualStyleBackColor = true;
            this.btnLIMP.Click += new System.EventHandler(this.btnLIMP_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(325, 238);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 6;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "N2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "N3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "N4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultados";
            // 
            // TXBresul
            // 
            this.TXBresul.Location = new System.Drawing.Point(103, 238);
            this.TXBresul.Name = "TXBresul";
            this.TXBresul.Size = new System.Drawing.Size(100, 23);
            this.TXBresul.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(173, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "MEDIA";
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 274);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXBresul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.btnLIMP);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.MSK3);
            this.Controls.Add(this.MSK4);
            this.Controls.Add(this.MSK1);
            this.Controls.Add(this.MSK2);
            this.Name = "F3";
            this.Text = "F3";
            this.Load += new System.EventHandler(this.F3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox MSK2;
        private MaskedTextBox MSK1;
        private MaskedTextBox MSK4;
        private MaskedTextBox MSK3;
        private Button btnCALCULAR;
        private Button btnLIMP;
        private Button BTNsalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TXBresul;
        private Label label6;
    }
}