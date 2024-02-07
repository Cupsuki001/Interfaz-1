namespace WinFormsApp1
{
    partial class Practica1
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
            this.MSKkg = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOPCION = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXBlibras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXBgramos = new System.Windows.Forms.TextBox();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion de peso";
            // 
            // MSKkg
            // 
            this.MSKkg.Location = new System.Drawing.Point(238, 101);
            this.MSKkg.Mask = "99999";
            this.MSKkg.Name = "MSKkg";
            this.MSKkg.Size = new System.Drawing.Size(100, 23);
            this.MSKkg.TabIndex = 1;
            this.MSKkg.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(112, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad en Kg";
            // 
            // cmbOPCION
            // 
            this.cmbOPCION.FormattingEnabled = true;
            this.cmbOPCION.Items.AddRange(new object[] {
            "Libras",
            "Gramos"});
            this.cmbOPCION.Location = new System.Drawing.Point(238, 154);
            this.cmbOPCION.Name = "cmbOPCION";
            this.cmbOPCION.Size = new System.Drawing.Size(100, 23);
            this.cmbOPCION.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(91, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione una opcion";
            // 
            // TXBlibras
            // 
            this.TXBlibras.BackColor = System.Drawing.Color.White;
            this.TXBlibras.ForeColor = System.Drawing.Color.White;
            this.TXBlibras.Location = new System.Drawing.Point(252, 85);
            this.TXBlibras.Name = "TXBlibras";
            this.TXBlibras.Size = new System.Drawing.Size(100, 23);
            this.TXBlibras.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXBgramos);
            this.groupBox1.Controls.Add(this.TXBlibras);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(27, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(283, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Libras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(89, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gramos";
            // 
            // TXBgramos
            // 
            this.TXBgramos.Location = new System.Drawing.Point(64, 85);
            this.TXBgramos.Name = "TXBgramos";
            this.TXBgramos.Size = new System.Drawing.Size(100, 23);
            this.TXBgramos.TabIndex = 6;
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.Location = new System.Drawing.Point(89, 378);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNcalcular.TabIndex = 8;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = true;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Location = new System.Drawing.Point(195, 378);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 9;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(304, 378);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 10;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // Practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(486, 428);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOPCION);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSKkg);
            this.Controls.Add(this.label1);
            this.Name = "Practica1";
            this.Text = "Practica1";
            this.Load += new System.EventHandler(this.Practica1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox MSKkg;
        private Label label2;
        private ComboBox cmbOPCION;
        private Label label3;
        private TextBox TXBlibras;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private TextBox TXBgramos;
        private Button BTNcalcular;
        private Button BTNlimpiar;
        private Button BTNsalir;
    }
}