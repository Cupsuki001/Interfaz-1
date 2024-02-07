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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eejmplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSSLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farmaciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasePracticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionDeKgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eejmplosToolStripMenuItem,
            this.clasePracticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eejmplosToolStripMenuItem
            // 
            this.eejmplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSSLaboralToolStripMenuItem,
            this.sumaNotasToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.farmaciaToolStripMenuItem});
            this.eejmplosToolStripMenuItem.Name = "eejmplosToolStripMenuItem";
            this.eejmplosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.eejmplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // iNSSLaboralToolStripMenuItem
            // 
            this.iNSSLaboralToolStripMenuItem.Name = "iNSSLaboralToolStripMenuItem";
            this.iNSSLaboralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iNSSLaboralToolStripMenuItem.Text = "INSS laboral";
            // 
            // sumaNotasToolStripMenuItem
            // 
            this.sumaNotasToolStripMenuItem.Name = "sumaNotasToolStripMenuItem";
            this.sumaNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaNotasToolStripMenuItem.Text = "Suma notas";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            // 
            // farmaciaToolStripMenuItem
            // 
            this.farmaciaToolStripMenuItem.Name = "farmaciaToolStripMenuItem";
            this.farmaciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farmaciaToolStripMenuItem.Text = "Farmacia";
            // 
            // clasePracticaToolStripMenuItem
            // 
            this.clasePracticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversionDeKgToolStripMenuItem});
            this.clasePracticaToolStripMenuItem.Name = "clasePracticaToolStripMenuItem";
            this.clasePracticaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.clasePracticaToolStripMenuItem.Text = "Clase practica";
            // 
            // conversionDeKgToolStripMenuItem
            // 
            this.conversionDeKgToolStripMenuItem.Name = "conversionDeKgToolStripMenuItem";
            this.conversionDeKgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conversionDeKgToolStripMenuItem.Text = "Conversion de kg";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 302);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Curso de verano";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eejmplosToolStripMenuItem;
        private ToolStripMenuItem iNSSLaboralToolStripMenuItem;
        private ToolStripMenuItem sumaNotasToolStripMenuItem;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem farmaciaToolStripMenuItem;
        private ToolStripMenuItem clasePracticaToolStripMenuItem;
        private ToolStripMenuItem conversionDeKgToolStripMenuItem;
    }
}