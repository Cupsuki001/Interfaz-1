namespace WinFormsApp1
{
    partial class Practica3
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
            this.MSKsalario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MSKaño = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXBneto = new System.Windows.Forms.TextBox();
            this.TXBir = new System.Windows.Forms.TextBox();
            this.TXBbruto = new System.Windows.Forms.TextBox();
            this.TXBlaboral = new System.Windows.Forms.TextBox();
            this.TXBAntporc = new System.Windows.Forms.TextBox();
            this.TXBantigue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNlimpr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario";
            // 
            // MSKsalario
            // 
            this.MSKsalario.Location = new System.Drawing.Point(32, 129);
            this.MSKsalario.Mask = "999999";
            this.MSKsalario.Name = "MSKsalario";
            this.MSKsalario.Size = new System.Drawing.Size(100, 23);
            this.MSKsalario.TabIndex = 1;
            this.MSKsalario.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(191, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año de ingreso";
            // 
            // MSKaño
            // 
            this.MSKaño.Location = new System.Drawing.Point(191, 129);
            this.MSKaño.Mask = "9999";
            this.MSKaño.Name = "MSKaño";
            this.MSKaño.Size = new System.Drawing.Size(100, 23);
            this.MSKaño.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.TXBneto);
            this.groupBox1.Controls.Add(this.TXBir);
            this.groupBox1.Controls.Add(this.TXBbruto);
            this.groupBox1.Controls.Add(this.TXBlaboral);
            this.groupBox1.Controls.Add(this.TXBAntporc);
            this.groupBox1.Controls.Add(this.TXBantigue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADOS";
            // 
            // TXBneto
            // 
            this.TXBneto.Location = new System.Drawing.Point(457, 89);
            this.TXBneto.Name = "TXBneto";
            this.TXBneto.Size = new System.Drawing.Size(57, 23);
            this.TXBneto.TabIndex = 20;
            // 
            // TXBir
            // 
            this.TXBir.Location = new System.Drawing.Point(383, 89);
            this.TXBir.Name = "TXBir";
            this.TXBir.Size = new System.Drawing.Size(59, 23);
            this.TXBir.TabIndex = 19;
            // 
            // TXBbruto
            // 
            this.TXBbruto.Location = new System.Drawing.Point(219, 89);
            this.TXBbruto.Name = "TXBbruto";
            this.TXBbruto.Size = new System.Drawing.Size(60, 23);
            this.TXBbruto.TabIndex = 18;
            // 
            // TXBlaboral
            // 
            this.TXBlaboral.Location = new System.Drawing.Point(295, 89);
            this.TXBlaboral.Name = "TXBlaboral";
            this.TXBlaboral.Size = new System.Drawing.Size(70, 23);
            this.TXBlaboral.TabIndex = 17;
            // 
            // TXBAntporc
            // 
            this.TXBAntporc.Location = new System.Drawing.Point(117, 89);
            this.TXBAntporc.Name = "TXBAntporc";
            this.TXBAntporc.Size = new System.Drawing.Size(75, 23);
            this.TXBAntporc.TabIndex = 16;
            // 
            // TXBantigue
            // 
            this.TXBantigue.Location = new System.Drawing.Point(24, 89);
            this.TXBantigue.Name = "TXBantigue";
            this.TXBantigue.Size = new System.Drawing.Size(69, 23);
            this.TXBantigue.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Chocolate;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(457, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ingr.Neto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Chocolate;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(406, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "IR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Chocolate;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(311, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inss.L";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Chocolate;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(221, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingr.Bruto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Chocolate;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(117, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "A.Porcentual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Chocolate;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(24, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Antiguedad";
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.BackColor = System.Drawing.Color.Peru;
            this.BTNcalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNcalcular.Location = new System.Drawing.Point(348, 64);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNcalcular.TabIndex = 5;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = false;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.Peru;
            this.BTNsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNsalir.Location = new System.Drawing.Point(348, 134);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 6;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNlimpr
            // 
            this.BTNlimpr.BackColor = System.Drawing.Color.Peru;
            this.BTNlimpr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNlimpr.Location = new System.Drawing.Point(451, 101);
            this.BTNlimpr.Name = "BTNlimpr";
            this.BTNlimpr.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpr.TabIndex = 7;
            this.BTNlimpr.Text = "Limpiar";
            this.BTNlimpr.UseVisualStyleBackColor = false;
            this.BTNlimpr.Click += new System.EventHandler(this.BTNlimpr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(140, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calcular datos del Empleado";
            // 
            // Practica3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(553, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNlimpr);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MSKaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSKsalario);
            this.Controls.Add(this.label1);
            this.Name = "Practica3";
            this.Text = "Practica3";
            this.Load += new System.EventHandler(this.Practica3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox MSKsalario;
        private Label label2;
        private MaskedTextBox MSKaño;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BTNcalcular;
        private Button BTNsalir;
        private Button BTNlimpr;
        private Label label3;
        private TextBox TXBneto;
        private TextBox TXBir;
        private TextBox TXBbruto;
        private TextBox TXBlaboral;
        private TextBox TXBAntporc;
        private TextBox TXBantigue;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}