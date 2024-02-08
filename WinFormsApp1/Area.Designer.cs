namespace WinFormsApp1
{
    partial class Area
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
            this.RDtriangular = new System.Windows.Forms.RadioButton();
            this.RDcilindro = new System.Windows.Forms.RadioButton();
            this.RDhexagono = new System.Windows.Forms.RadioButton();
            this.GRPtriangulo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GRPtriangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area y perimetro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.RDhexagono);
            this.groupBox1.Controls.Add(this.RDtriangular);
            this.groupBox1.Controls.Add(this.RDcilindro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Figura";
            // 
            // RDtriangular
            // 
            this.RDtriangular.AutoSize = true;
            this.RDtriangular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RDtriangular.Location = new System.Drawing.Point(20, 35);
            this.RDtriangular.Name = "RDtriangular";
            this.RDtriangular.Size = new System.Drawing.Size(137, 19);
            this.RDtriangular.TabIndex = 2;
            this.RDtriangular.TabStop = true;
            this.RDtriangular.Text = "Triangulo Rectangulo";
            this.RDtriangular.UseVisualStyleBackColor = true;
            // 
            // RDcilindro
            // 
            this.RDcilindro.AutoSize = true;
            this.RDcilindro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RDcilindro.Location = new System.Drawing.Point(20, 60);
            this.RDcilindro.Name = "RDcilindro";
            this.RDcilindro.Size = new System.Drawing.Size(67, 19);
            this.RDcilindro.TabIndex = 3;
            this.RDcilindro.TabStop = true;
            this.RDcilindro.Text = "Cilindro";
            this.RDcilindro.UseVisualStyleBackColor = true;
            // 
            // RDhexagono
            // 
            this.RDhexagono.AutoSize = true;
            this.RDhexagono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RDhexagono.Location = new System.Drawing.Point(20, 85);
            this.RDhexagono.Name = "RDhexagono";
            this.RDhexagono.Size = new System.Drawing.Size(80, 19);
            this.RDhexagono.TabIndex = 4;
            this.RDhexagono.TabStop = true;
            this.RDhexagono.Text = "Hexagono";
            this.RDhexagono.UseVisualStyleBackColor = true;
            // 
            // GRPtriangulo
            // 
            this.GRPtriangulo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.GRPtriangulo.Controls.Add(this.label7);
            this.GRPtriangulo.Controls.Add(this.label6);
            this.GRPtriangulo.Controls.Add(this.maskedTextBox4);
            this.GRPtriangulo.Controls.Add(this.maskedTextBox3);
            this.GRPtriangulo.Controls.Add(this.label5);
            this.GRPtriangulo.Controls.Add(this.label4);
            this.GRPtriangulo.Controls.Add(this.label3);
            this.GRPtriangulo.Controls.Add(this.maskedTextBox2);
            this.GRPtriangulo.Controls.Add(this.maskedTextBox1);
            this.GRPtriangulo.Controls.Add(this.label2);
            this.GRPtriangulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GRPtriangulo.Location = new System.Drawing.Point(260, 61);
            this.GRPtriangulo.Name = "GRPtriangulo";
            this.GRPtriangulo.Size = new System.Drawing.Size(292, 324);
            this.GRPtriangulo.TabIndex = 2;
            this.GRPtriangulo.TabStop = false;
            this.GRPtriangulo.Text = "Triangulo Rectangulo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(163, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(81, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aristas basales:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(32, 60);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(172, 60);
            this.maskedTextBox2.Mask = "99999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Altura:";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(32, 144);
            this.maskedTextBox3.Mask = "99999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox3.TabIndex = 6;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(172, 144);
            this.maskedTextBox4.Mask = "99999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox4.TabIndex = 7;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "h1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "h2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Resultados";
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(564, 397);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GRPtriangulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Area";
            this.Text = "Area";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GRPtriangulo.ResumeLayout(false);
            this.GRPtriangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton RDhexagono;
        private RadioButton RDtriangular;
        private RadioButton RDcilindro;
        private GroupBox GRPtriangulo;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
    }
}