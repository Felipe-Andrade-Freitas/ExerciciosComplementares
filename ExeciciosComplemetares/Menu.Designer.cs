namespace ExeciciosComplemetares
{
    partial class Menu
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
            this.calculadoraFinanceiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurosSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurosCompostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraFinanceiraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraFinanceiraToolStripMenuItem
            // 
            this.calculadoraFinanceiraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jurosSimplesToolStripMenuItem,
            this.jurosCompostoToolStripMenuItem});
            this.calculadoraFinanceiraToolStripMenuItem.Name = "calculadoraFinanceiraToolStripMenuItem";
            this.calculadoraFinanceiraToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.calculadoraFinanceiraToolStripMenuItem.Text = "Calculadora Financeira";
            // 
            // jurosSimplesToolStripMenuItem
            // 
            this.jurosSimplesToolStripMenuItem.Name = "jurosSimplesToolStripMenuItem";
            this.jurosSimplesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.jurosSimplesToolStripMenuItem.Text = "Juros Simples";
            // 
            // jurosCompostoToolStripMenuItem
            // 
            this.jurosCompostoToolStripMenuItem.Name = "jurosCompostoToolStripMenuItem";
            this.jurosCompostoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.jurosCompostoToolStripMenuItem.Text = "Juros Composto";
            this.jurosCompostoToolStripMenuItem.Click += new System.EventHandler(this.jurosCompostoToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Calculadora Financeira";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraFinanceiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurosSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurosCompostoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

