namespace WinFormsApp1
{
    partial class F2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNcal = new System.Windows.Forms.Button();
            this.BTNlimp = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXBresul = new System.Windows.Forms.TextBox();
            this.TXBrad = new System.Windows.Forms.TextBox();
            this.TXBtiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Velocidad Lineal";
            // 
            // BTNcal
            // 
            this.BTNcal.Location = new System.Drawing.Point(81, 299);
            this.BTNcal.Name = "BTNcal";
            this.BTNcal.Size = new System.Drawing.Size(75, 23);
            this.BTNcal.TabIndex = 5;
            this.BTNcal.Text = "Calcular";
            this.BTNcal.UseVisualStyleBackColor = true;
            this.BTNcal.Click += new System.EventHandler(this.BTNcal_Click);
            // 
            // BTNlimp
            // 
            this.BTNlimp.Location = new System.Drawing.Point(189, 299);
            this.BTNlimp.Name = "BTNlimp";
            this.BTNlimp.Size = new System.Drawing.Size(75, 23);
            this.BTNlimp.TabIndex = 6;
            this.BTNlimp.Text = "Limpiar";
            this.BTNlimp.UseVisualStyleBackColor = true;
            this.BTNlimp.Click += new System.EventHandler(this.BTNlimp_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(301, 299);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 7;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado";
            // 
            // TXBresul
            // 
            this.TXBresul.Location = new System.Drawing.Point(177, 252);
            this.TXBresul.Name = "TXBresul";
            this.TXBresul.Size = new System.Drawing.Size(100, 23);
            this.TXBresul.TabIndex = 9;
            // 
            // TXBrad
            // 
            this.TXBrad.Location = new System.Drawing.Point(56, 165);
            this.TXBrad.Name = "TXBrad";
            this.TXBrad.Size = new System.Drawing.Size(100, 23);
            this.TXBrad.TabIndex = 10;
            this.TXBrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBrad_KeyPress);
            // 
            // TXBtiem
            // 
            this.TXBtiem.Location = new System.Drawing.Point(276, 161);
            this.TXBtiem.Name = "TXBtiem";
            this.TXBtiem.Size = new System.Drawing.Size(100, 23);
            this.TXBtiem.TabIndex = 11;
            this.TXBtiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBtiem_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "metros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Segundos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "m/s";
            // 
            // F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 346);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXBtiem);
            this.Controls.Add(this.TXBrad);
            this.Controls.Add(this.TXBresul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimp);
            this.Controls.Add(this.BTNcal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F2";
            this.Text = "F2";
            this.Load += new System.EventHandler(this.F2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BTNcal;
        private Button BTNlimp;
        private Button BTNsalir;
        private Label label4;
        private TextBox TXBresul;
        private TextBox TXBrad;
        private TextBox TXBtiem;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}