namespace WinFormsApp1
{
    partial class Practica2
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
            this.RDvehiculo = new System.Windows.Forms.RadioButton();
            this.RDindustrial = new System.Windows.Forms.RadioButton();
            this.RDmuebles = new System.Windows.Forms.RadioButton();
            this.MSKvalor = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXBtotal = new System.Windows.Forms.TextBox();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.BTNlimp = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(135, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPRECIACION";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.RDvehiculo);
            this.groupBox1.Controls.Add(this.RDindustrial);
            this.groupBox1.Controls.Add(this.RDmuebles);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(24, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activos";
            // 
            // RDvehiculo
            // 
            this.RDvehiculo.AutoSize = true;
            this.RDvehiculo.Location = new System.Drawing.Point(22, 103);
            this.RDvehiculo.Name = "RDvehiculo";
            this.RDvehiculo.Size = new System.Drawing.Size(70, 19);
            this.RDvehiculo.TabIndex = 3;
            this.RDvehiculo.TabStop = true;
            this.RDvehiculo.Text = "Vehiculo";
            this.RDvehiculo.UseVisualStyleBackColor = true;
            // 
            // RDindustrial
            // 
            this.RDindustrial.AutoSize = true;
            this.RDindustrial.Location = new System.Drawing.Point(22, 33);
            this.RDindustrial.Name = "RDindustrial";
            this.RDindustrial.Size = new System.Drawing.Size(114, 19);
            this.RDindustrial.TabIndex = 2;
            this.RDindustrial.TabStop = true;
            this.RDindustrial.Text = "Equipo Industrial";
            this.RDindustrial.UseVisualStyleBackColor = true;
            // 
            // RDmuebles
            // 
            this.RDmuebles.AutoSize = true;
            this.RDmuebles.Location = new System.Drawing.Point(22, 67);
            this.RDmuebles.Name = "RDmuebles";
            this.RDmuebles.Size = new System.Drawing.Size(70, 19);
            this.RDmuebles.TabIndex = 2;
            this.RDmuebles.TabStop = true;
            this.RDmuebles.Text = "Muebles";
            this.RDmuebles.UseVisualStyleBackColor = true;
            // 
            // MSKvalor
            // 
            this.MSKvalor.Location = new System.Drawing.Point(305, 116);
            this.MSKvalor.Mask = "99999";
            this.MSKvalor.Name = "MSKvalor";
            this.MSKvalor.Size = new System.Drawing.Size(100, 23);
            this.MSKvalor.TabIndex = 2;
            this.MSKvalor.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(305, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor del Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(305, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depreciacion total";
            // 
            // TXBtotal
            // 
            this.TXBtotal.BackColor = System.Drawing.Color.Honeydew;
            this.TXBtotal.Location = new System.Drawing.Point(305, 216);
            this.TXBtotal.Name = "TXBtotal";
            this.TXBtotal.Size = new System.Drawing.Size(100, 23);
            this.TXBtotal.TabIndex = 5;
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.BackColor = System.Drawing.Color.DarkCyan;
            this.BTNcalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNcalcular.Location = new System.Drawing.Point(305, 277);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNcalcular.TabIndex = 6;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = false;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // BTNlimp
            // 
            this.BTNlimp.BackColor = System.Drawing.Color.DarkCyan;
            this.BTNlimp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNlimp.Location = new System.Drawing.Point(41, 277);
            this.BTNlimp.Name = "BTNlimp";
            this.BTNlimp.Size = new System.Drawing.Size(75, 23);
            this.BTNlimp.TabIndex = 7;
            this.BTNlimp.Text = "Limpiar";
            this.BTNlimp.UseVisualStyleBackColor = false;
            this.BTNlimp.Click += new System.EventHandler(this.BTNlimp_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.DarkCyan;
            this.BTNsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNsalir.Location = new System.Drawing.Point(161, 277);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 8;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(478, 328);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimp);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.TXBtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSKvalor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Practica2";
            this.Text = "Practica2";
            this.Load += new System.EventHandler(this.Practica2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton RDvehiculo;
        private RadioButton RDindustrial;
        private RadioButton RDmuebles;
        private MaskedTextBox MSKvalor;
        private Label label2;
        private Label label3;
        private TextBox TXBtotal;
        private Button BTNcalcular;
        private Button BTNlimp;
        private Button BTNsalir;
    }
}