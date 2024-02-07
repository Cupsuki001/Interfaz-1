namespace WinFormsApp1
{
    partial class MDI
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
            menuStrip1 = new MenuStrip();
            eejmplosToolStripMenuItem = new ToolStripMenuItem();
            iNSSLaboralToolStripMenuItem = new ToolStripMenuItem();
            sumaNotasToolStripMenuItem = new ToolStripMenuItem();
            compraToolStripMenuItem = new ToolStripMenuItem();
            farmaciaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eejmplosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(633, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // eejmplosToolStripMenuItem
            // 
            eejmplosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iNSSLaboralToolStripMenuItem, sumaNotasToolStripMenuItem, compraToolStripMenuItem, farmaciaToolStripMenuItem });
            eejmplosToolStripMenuItem.Name = "eejmplosToolStripMenuItem";
            eejmplosToolStripMenuItem.Size = new Size(84, 24);
            eejmplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // iNSSLaboralToolStripMenuItem
            // 
            iNSSLaboralToolStripMenuItem.Name = "iNSSLaboralToolStripMenuItem";
            iNSSLaboralToolStripMenuItem.Size = new Size(224, 26);
            iNSSLaboralToolStripMenuItem.Text = "INSS laboral";
            iNSSLaboralToolStripMenuItem.Click += iNSSLaboralToolStripMenuItem_Click;
            // 
            // sumaNotasToolStripMenuItem
            // 
            sumaNotasToolStripMenuItem.Name = "sumaNotasToolStripMenuItem";
            sumaNotasToolStripMenuItem.Size = new Size(224, 26);
            sumaNotasToolStripMenuItem.Text = "Suma notas";
            sumaNotasToolStripMenuItem.Click += sumaNotasToolStripMenuItem_Click;
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(224, 26);
            compraToolStripMenuItem.Text = "Compra";
            compraToolStripMenuItem.Click += compraToolStripMenuItem_Click;
            // 
            // farmaciaToolStripMenuItem
            // 
            farmaciaToolStripMenuItem.Name = "farmaciaToolStripMenuItem";
            farmaciaToolStripMenuItem.Size = new Size(224, 26);
            farmaciaToolStripMenuItem.Text = "Farmacia";
            farmaciaToolStripMenuItem.Click += farmaciaToolStripMenuItem_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 403);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MDI";
            Text = "Curso de verano";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eejmplosToolStripMenuItem;
        private ToolStripMenuItem iNSSLaboralToolStripMenuItem;
        private ToolStripMenuItem sumaNotasToolStripMenuItem;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem farmaciaToolStripMenuItem;
    }
}