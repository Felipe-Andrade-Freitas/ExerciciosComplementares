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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.txtValorAplicado = new System.Windows.Forms.TextBox();
            this.txtQuantMeses = new System.Windows.Forms.TextBox();
            this.txtJurosPoupanca = new System.Windows.Forms.TextBox();
            this.txtJurosRendaFixa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorAplicado
            // 
            this.txtValorAplicado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorAplicado.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorAplicado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorAplicado.Location = new System.Drawing.Point(142, 62);
            this.txtValorAplicado.Name = "txtValorAplicado";
            this.txtValorAplicado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorAplicado.Size = new System.Drawing.Size(110, 20);
            this.txtValorAplicado.TabIndex = 2;
            // 
            // txtQuantMeses
            // 
            this.txtQuantMeses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantMeses.Location = new System.Drawing.Point(142, 89);
            this.txtQuantMeses.Name = "txtQuantMeses";
            this.txtQuantMeses.Size = new System.Drawing.Size(110, 20);
            this.txtQuantMeses.TabIndex = 3;
            // 
            // txtJurosPoupanca
            // 
            this.txtJurosPoupanca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJurosPoupanca.Location = new System.Drawing.Point(142, 116);
            this.txtJurosPoupanca.Name = "txtJurosPoupanca";
            this.txtJurosPoupanca.Size = new System.Drawing.Size(110, 20);
            this.txtJurosPoupanca.TabIndex = 4;
            // 
            // txtJurosRendaFixa
            // 
            this.txtJurosRendaFixa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJurosRendaFixa.Location = new System.Drawing.Point(142, 143);
            this.txtJurosRendaFixa.Name = "txtJurosRendaFixa";
            this.txtJurosRendaFixa.Size = new System.Drawing.Size(110, 20);
            this.txtJurosRendaFixa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor a ser aplicado: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantidade de meses: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Juros Poupança: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Juros Renda Fixa: ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(47, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Gerar dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(154, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seja Bem Vindo - Calculadora Financeira";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(282, 249);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJurosRendaFixa);
            this.Controls.Add(this.txtJurosPoupanca);
            this.Controls.Add(this.txtQuantMeses);
            this.Controls.Add(this.txtValorAplicado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculadora Financeira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorAplicado;
        private System.Windows.Forms.TextBox txtQuantMeses;
        private System.Windows.Forms.TextBox txtJurosPoupanca;
        private System.Windows.Forms.TextBox txtJurosRendaFixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

