namespace WinFormsApp1
{
    partial class Sesion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sesion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXBnom = new System.Windows.Forms.TextBox();
            this.TXBcontra = new System.Windows.Forms.TextBox();
            this.BTNconectar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Barra = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBLporcentaje = new System.Windows.Forms.Label();
            this.LBLporc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de Sesion";
            // 
            // TXBnom
            // 
            this.TXBnom.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TXBnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBnom.Location = new System.Drawing.Point(83, 232);
            this.TXBnom.Name = "TXBnom";
            this.TXBnom.Size = new System.Drawing.Size(141, 16);
            this.TXBnom.TabIndex = 2;
            // 
            // TXBcontra
            // 
            this.TXBcontra.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TXBcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBcontra.Location = new System.Drawing.Point(83, 300);
            this.TXBcontra.Name = "TXBcontra";
            this.TXBcontra.PasswordChar = '*';
            this.TXBcontra.Size = new System.Drawing.Size(141, 16);
            this.TXBcontra.TabIndex = 3;
            // 
            // BTNconectar
            // 
            this.BTNconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNconectar.ForeColor = System.Drawing.Color.Transparent;
            this.BTNconectar.Location = new System.Drawing.Point(101, 344);
            this.BTNconectar.Name = "BTNconectar";
            this.BTNconectar.Size = new System.Drawing.Size(100, 42);
            this.BTNconectar.TabIndex = 4;
            this.BTNconectar.Text = "Conectar";
            this.BTNconectar.UseVisualStyleBackColor = false;
            this.BTNconectar.Click += new System.EventHandler(this.BTNconectar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Barra.ForeColor = System.Drawing.Color.DarkCyan;
            this.Barra.Location = new System.Drawing.Point(25, 392);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(243, 23);
            this.Barra.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBLporcentaje
            // 
            this.LBLporcentaje.AutoSize = true;
            this.LBLporcentaje.Location = new System.Drawing.Point(260, 358);
            this.LBLporcentaje.Name = "LBLporcentaje";
            this.LBLporcentaje.Size = new System.Drawing.Size(0, 15);
            this.LBLporcentaje.TabIndex = 8;
            // 
            // LBLporc
            // 
            this.LBLporc.AutoSize = true;
            this.LBLporc.Location = new System.Drawing.Point(274, 400);
            this.LBLporc.Name = "LBLporc";
            this.LBLporc.Size = new System.Drawing.Size(0, 15);
            this.LBLporc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(50, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Limpiar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(192, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Auntentificar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLporc);
            this.Controls.Add(this.LBLporcentaje);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTNconectar);
            this.Controls.Add(this.TXBcontra);
            this.Controls.Add(this.TXBnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sesion";
            this.Text = "Sesion";
            this.Load += new System.EventHandler(this.Sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TXBnom;
        private TextBox TXBcontra;
        private Button BTNconectar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ProgressBar Barra;
        private System.Windows.Forms.Timer timer1;
        private Label LBLporcentaje;
        private Label LBLporc;
        private Label label2;
        private Label label3;
    }
}