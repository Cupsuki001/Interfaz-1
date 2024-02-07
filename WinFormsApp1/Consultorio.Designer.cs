namespace WinFormsApp1
{
    partial class Consultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultorio));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            CHKtos = new CheckBox();
            CHKnauseas = new CheckBox();
            CHKmuscular = new CheckBox();
            richTextBox1 = new RichTextBox();
            BTNsalir = new Button();
            BTNcancel = new Button();
            BTNanalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 33);
            label1.Name = "label1";
            label1.Size = new Size(377, 36);
            label1.TabIndex = 1;
            label1.Text = "CONSULTORIO ONLINE ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(CHKtos);
            groupBox1.Controls.Add(CHKnauseas);
            groupBox1.Controls.Add(CHKmuscular);
            groupBox1.Location = new Point(266, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 239);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indique los sintomas";
            // 
            // CHKtos
            // 
            CHKtos.AutoSize = true;
            CHKtos.Location = new Point(25, 156);
            CHKtos.Name = "CHKtos";
            CHKtos.Size = new Size(53, 24);
            CHKtos.TabIndex = 2;
            CHKtos.Text = "Tos";
            CHKtos.UseVisualStyleBackColor = true;
            // 
            // CHKnauseas
            // 
            CHKnauseas.AutoSize = true;
            CHKnauseas.Location = new Point(22, 103);
            CHKnauseas.Name = "CHKnauseas";
            CHKnauseas.Size = new Size(149, 24);
            CHKnauseas.TabIndex = 1;
            CHKnauseas.Text = "Nauseas y Vomito";
            CHKnauseas.UseVisualStyleBackColor = true;
            // 
            // CHKmuscular
            // 
            CHKmuscular.AutoSize = true;
            CHKmuscular.Location = new Point(22, 54);
            CHKmuscular.Name = "CHKmuscular";
            CHKmuscular.Size = new Size(160, 24);
            CHKmuscular.TabIndex = 0;
            CHKmuscular.Text = "Dolores musculares";
            CHKmuscular.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(538, 202);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(266, 230);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // BTNsalir
            // 
            BTNsalir.BackColor = Color.Gainsboro;
            BTNsalir.ForeColor = Color.Red;
            BTNsalir.Location = new Point(89, 396);
            BTNsalir.Name = "BTNsalir";
            BTNsalir.Size = new Size(111, 36);
            BTNsalir.TabIndex = 9;
            BTNsalir.Text = "Salir";
            BTNsalir.UseVisualStyleBackColor = false;
            BTNsalir.Click += BTNsalir_Click;
            // 
            // BTNcancel
            // 
            BTNcancel.BackColor = Color.Gainsboro;
            BTNcancel.ForeColor = Color.FromArgb(0, 192, 192);
            BTNcancel.Location = new Point(89, 293);
            BTNcancel.Name = "BTNcancel";
            BTNcancel.Size = new Size(111, 36);
            BTNcancel.TabIndex = 8;
            BTNcancel.Text = "Cancelar";
            BTNcancel.UseVisualStyleBackColor = false;
            BTNcancel.Click += BTNcancel_Click;
            // 
            // BTNanalizar
            // 
            BTNanalizar.BackColor = Color.Gainsboro;
            BTNanalizar.ForeColor = Color.FromArgb(0, 192, 0);
            BTNanalizar.Location = new Point(89, 202);
            BTNanalizar.Name = "BTNanalizar";
            BTNanalizar.Size = new Size(111, 36);
            BTNanalizar.TabIndex = 7;
            BTNanalizar.Text = "Analizar";
            BTNanalizar.UseVisualStyleBackColor = false;
            BTNanalizar.Click += BTNanalizar_Click;
            // 
            // Consultorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(816, 482);
            Controls.Add(BTNsalir);
            Controls.Add(BTNcancel);
            Controls.Add(BTNanalizar);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Consultorio";
            Text = "Consultorio";
            Load += Consultorio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox CHKtos;
        private CheckBox CHKnauseas;
        private CheckBox CHKmuscular;
        private RichTextBox richTextBox1;
        private Button BTNsalir;
        private Button BTNcancel;
        private Button BTNanalizar;
    }
}