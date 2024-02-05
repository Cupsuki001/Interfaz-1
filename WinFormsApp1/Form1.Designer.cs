namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MSKingresos = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXBlaboral = new System.Windows.Forms.TextBox();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNlimp = new System.Windows.Forms.Button();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "APLICACION PARA CALCULAR EL INSS LABORAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresos";
           
            // 
            // MSKingresos
            // 
            this.MSKingresos.Location = new System.Drawing.Point(67, 140);
            this.MSKingresos.Mask = "999999";
            this.MSKingresos.Name = "MSKingresos";
            this.MSKingresos.Size = new System.Drawing.Size(100, 23);
            this.MSKingresos.TabIndex = 2;
            this.MSKingresos.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "INSS laboral";
            // 
            // TXBlaboral
            // 
            this.TXBlaboral.Location = new System.Drawing.Point(67, 244);
            this.TXBlaboral.Name = "TXBlaboral";
            this.TXBlaboral.Size = new System.Drawing.Size(100, 23);
            this.TXBlaboral.TabIndex = 4;
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(530, 213);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 35);
            this.BTNsalir.TabIndex = 11;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNlimp
            // 
            this.BTNlimp.Location = new System.Drawing.Point(584, 128);
            this.BTNlimp.Name = "BTNlimp";
            this.BTNlimp.Size = new System.Drawing.Size(75, 39);
            this.BTNlimp.TabIndex = 10;
            this.BTNlimp.Text = "Limpiar";
            this.BTNlimp.UseVisualStyleBackColor = true;
            this.BTNlimp.Click += new System.EventHandler(this.BTNlimp_Click);
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.Location = new System.Drawing.Point(476, 130);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 37);
            this.BTNcalcular.TabIndex = 9;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = true;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(677, 337);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimp);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.TXBlaboral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MSKingresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "INSS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox MSKingresos;
        private Label label3;
        private TextBox TXBlaboral;
        private Button BTNsalir;
        private Button BTNlimp;
        private Button BTNcalcular;
    }
}