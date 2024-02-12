namespace WinFormsApp1
{
    partial class F1
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
            this.MSKnota1 = new System.Windows.Forms.MaskedTextBox();
            this.MSKnota2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNlimp = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXBresul = new System.Windows.Forms.TextBox();
            this.TXBestado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MSKnota1
            // 
            this.MSKnota1.Location = new System.Drawing.Point(36, 73);
            this.MSKnota1.Mask = "99";
            this.MSKnota1.Name = "MSKnota1";
            this.MSKnota1.Size = new System.Drawing.Size(100, 23);
            this.MSKnota1.TabIndex = 0;
            this.MSKnota1.ValidatingType = typeof(int);
            // 
            // MSKnota2
            // 
            this.MSKnota2.Location = new System.Drawing.Point(172, 76);
            this.MSKnota2.Mask = "99";
            this.MSKnota2.Name = "MSKnota2";
            this.MSKnota2.Size = new System.Drawing.Size(100, 23);
            this.MSKnota2.TabIndex = 1;
            this.MSKnota2.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNlimp
            // 
            this.BTNlimp.Location = new System.Drawing.Point(356, 123);
            this.BTNlimp.Name = "BTNlimp";
            this.BTNlimp.Size = new System.Drawing.Size(75, 23);
            this.BTNlimp.TabIndex = 5;
            this.BTNlimp.Text = "Limpiar";
            this.BTNlimp.UseVisualStyleBackColor = true;
            this.BTNlimp.Click += new System.EventHandler(this.BTNlimp_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(356, 180);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 6;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultados";
            // 
            // TXBresul
            // 
            this.TXBresul.Location = new System.Drawing.Point(36, 180);
            this.TXBresul.Name = "TXBresul";
            this.TXBresul.Size = new System.Drawing.Size(100, 23);
            this.TXBresul.TabIndex = 8;
            // 
            // TXBestado
            // 
            this.TXBestado.Location = new System.Drawing.Point(167, 178);
            this.TXBestado.Name = "TXBestado";
            this.TXBestado.Size = new System.Drawing.Size(100, 23);
            this.TXBestado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXBestado);
            this.Controls.Add(this.TXBresul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MSKnota2);
            this.Controls.Add(this.MSKnota1);
            this.Name = "F1";
            this.Text = "F1";
            this.Load += new System.EventHandler(this.F1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox MSKnota1;
        private MaskedTextBox MSKnota2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button BTNlimp;
        private Button BTNsalir;
        private Label label3;
        private TextBox TXBresul;
        private TextBox TXBestado;
        private Label label4;
    }
}