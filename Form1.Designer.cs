namespace MáquinaDeGuloseimas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBolacha = new System.Windows.Forms.Label();
            this.lblBolinho = new System.Windows.Forms.Label();
            this.lblChocolate = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValor3);
            this.panel1.Controls.Add(this.lblValor2);
            this.panel1.Controls.Add(this.lblValor1);
            this.panel1.Controls.Add(this.lblChocolate);
            this.panel1.Controls.Add(this.lblBolinho);
            this.panel1.Controls.Add(this.lblBolacha);
            this.panel1.Location = new System.Drawing.Point(232, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 187);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInfo);
            this.panel2.Controls.Add(this.btnComprar);
            this.panel2.Location = new System.Drawing.Point(232, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 158);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(232, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblBolacha
            // 
            this.lblBolacha.AutoSize = true;
            this.lblBolacha.Location = new System.Drawing.Point(112, 39);
            this.lblBolacha.Name = "lblBolacha";
            this.lblBolacha.Size = new System.Drawing.Size(111, 13);
            this.lblBolacha.TabIndex = 0;
            this.lblBolacha.Text = "Bolacha de chocolate";
            // 
            // lblBolinho
            // 
            this.lblBolinho.AutoSize = true;
            this.lblBolinho.Location = new System.Drawing.Point(112, 97);
            this.lblBolinho.Name = "lblBolinho";
            this.lblBolinho.Size = new System.Drawing.Size(92, 13);
            this.lblBolinho.TabIndex = 1;
            this.lblBolinho.Text = "Bolinho Ana maria";
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.Location = new System.Drawing.Point(128, 147);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(55, 13);
            this.lblChocolate.TabIndex = 2;
            this.lblChocolate.Text = "Chocolate";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(65, 104);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(216, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(65, 78);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(216, 20);
            this.txtInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guloseimas Conradito´s";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(230, 39);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(28, 13);
            this.lblValor1.TabIndex = 3;
            this.lblValor1.Text = "5,00";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(224, 97);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(28, 13);
            this.lblValor2.TabIndex = 4;
            this.lblValor2.Text = "6,00";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(227, 147);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(28, 13);
            this.lblValor3.TabIndex = 5;
            this.lblValor3.Text = "7,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.Label lblBolinho;
        private System.Windows.Forms.Label lblBolacha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

