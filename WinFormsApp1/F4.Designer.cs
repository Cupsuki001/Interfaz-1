namespace WinFormsApp1
{
    partial class F4
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
            this.MSKprimo = new System.Windows.Forms.MaskedTextBox();
            this.BTNcal = new System.Windows.Forms.Button();
            this.BTNlimp = new System.Windows.Forms.Button();
            this.BTNsal = new System.Windows.Forms.Button();
            this.TXBresul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero a digitar";
            // 
            // MSKprimo
            // 
            this.MSKprimo.Location = new System.Drawing.Point(59, 109);
            this.MSKprimo.Mask = "999";
            this.MSKprimo.Name = "MSKprimo";
            this.MSKprimo.Size = new System.Drawing.Size(100, 23);
            this.MSKprimo.TabIndex = 1;
            this.MSKprimo.ValidatingType = typeof(int);
            // 
            // BTNcal
            // 
            this.BTNcal.Location = new System.Drawing.Point(49, 187);
            this.BTNcal.Name = "BTNcal";
            this.BTNcal.Size = new System.Drawing.Size(75, 23);
            this.BTNcal.TabIndex = 2;
            this.BTNcal.Text = "Calcular";
            this.BTNcal.UseVisualStyleBackColor = true;
            this.BTNcal.Click += new System.EventHandler(this.BTNcal_Click);
            // 
            // BTNlimp
            // 
            this.BTNlimp.Location = new System.Drawing.Point(197, 187);
            this.BTNlimp.Name = "BTNlimp";
            this.BTNlimp.Size = new System.Drawing.Size(75, 23);
            this.BTNlimp.TabIndex = 3;
            this.BTNlimp.Text = "Limpiar";
            this.BTNlimp.UseVisualStyleBackColor = true;
            this.BTNlimp.Click += new System.EventHandler(this.BTNlimp_Click);
            // 
            // BTNsal
            // 
            this.BTNsal.Location = new System.Drawing.Point(333, 187);
            this.BTNsal.Name = "BTNsal";
            this.BTNsal.Size = new System.Drawing.Size(75, 23);
            this.BTNsal.TabIndex = 4;
            this.BTNsal.Text = "Salir";
            this.BTNsal.UseVisualStyleBackColor = true;
            this.BTNsal.Click += new System.EventHandler(this.BTNsal_Click);
            // 
            // TXBresul
            // 
            this.TXBresul.Location = new System.Drawing.Point(276, 109);
            this.TXBresul.Name = "TXBresul";
            this.TXBresul.Size = new System.Drawing.Size(100, 23);
            this.TXBresul.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numeros primos";
            // 
            // F4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXBresul);
            this.Controls.Add(this.BTNsal);
            this.Controls.Add(this.BTNlimp);
            this.Controls.Add(this.BTNcal);
            this.Controls.Add(this.MSKprimo);
            this.Controls.Add(this.label1);
            this.Name = "F4";
            this.Text = "F4";
            this.Load += new System.EventHandler(this.F4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox MSKprimo;
        private Button BTNcal;
        private Button BTNlimp;
        private Button BTNsal;
        private TextBox TXBresul;
        private Label label2;
        private Label label3;
    }
}