namespace WinFormsApp1
{
    partial class Notas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSKn1 = new System.Windows.Forms.MaskedTextBox();
            this.MSKn2 = new System.Windows.Forms.MaskedTextBox();
            this.MSKn3 = new System.Windows.Forms.MaskedTextBox();
            this.MSKn4 = new System.Windows.Forms.MaskedTextBox();
            this.TXBresul = new System.Windows.Forms.TextBox();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.BTNlimp = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "P2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "P3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(42, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "P4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(42, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota final";
            // 
            // MSKn1
            // 
            this.MSKn1.Location = new System.Drawing.Point(154, 30);
            this.MSKn1.Mask = "99";
            this.MSKn1.Name = "MSKn1";
            this.MSKn1.Size = new System.Drawing.Size(100, 23);
            this.MSKn1.TabIndex = 5;
            this.MSKn1.ValidatingType = typeof(int);
            // 
            // MSKn2
            // 
            this.MSKn2.Location = new System.Drawing.Point(154, 79);
            this.MSKn2.Mask = "99";
            this.MSKn2.Name = "MSKn2";
            this.MSKn2.Size = new System.Drawing.Size(100, 23);
            this.MSKn2.TabIndex = 6;
            this.MSKn2.ValidatingType = typeof(int);
            // 
            // MSKn3
            // 
            this.MSKn3.Location = new System.Drawing.Point(154, 132);
            this.MSKn3.Mask = "99";
            this.MSKn3.Name = "MSKn3";
            this.MSKn3.Size = new System.Drawing.Size(100, 23);
            this.MSKn3.TabIndex = 7;
            this.MSKn3.ValidatingType = typeof(int);
            // 
            // MSKn4
            // 
            this.MSKn4.Location = new System.Drawing.Point(154, 185);
            this.MSKn4.Mask = "99";
            this.MSKn4.Name = "MSKn4";
            this.MSKn4.Size = new System.Drawing.Size(100, 23);
            this.MSKn4.TabIndex = 8;
            this.MSKn4.ValidatingType = typeof(int);
            // 
            // TXBresul
            // 
            this.TXBresul.Location = new System.Drawing.Point(154, 252);
            this.TXBresul.Name = "TXBresul";
            this.TXBresul.Size = new System.Drawing.Size(100, 23);
            this.TXBresul.TabIndex = 9;
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.Location = new System.Drawing.Point(42, 329);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNcalcular.TabIndex = 10;
            this.BTNcalcular.Text = "CALCULAR";
            this.BTNcalcular.UseVisualStyleBackColor = true;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // BTNlimp
            // 
            this.BTNlimp.Location = new System.Drawing.Point(179, 329);
            this.BTNlimp.Name = "BTNlimp";
            this.BTNlimp.Size = new System.Drawing.Size(75, 23);
            this.BTNlimp.TabIndex = 11;
            this.BTNlimp.Text = "LIMPIAR";
            this.BTNlimp.UseVisualStyleBackColor = true;
            this.BTNlimp.Click += new System.EventHandler(this.BTNlimp_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(108, 381);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 12;
            this.BTNsalir.Text = "SALIR";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 430);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimp);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.TXBresul);
            this.Controls.Add(this.MSKn4);
            this.Controls.Add(this.MSKn3);
            this.Controls.Add(this.MSKn2);
            this.Controls.Add(this.MSKn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Notas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox MSKn1;
        private MaskedTextBox MSKn2;
        private MaskedTextBox MSKn3;
        private MaskedTextBox MSKn4;
        private TextBox TXBresul;
        private Button BTNcalcular;
        private Button BTNlimp;
        private Button BTNsalir;
    }
}