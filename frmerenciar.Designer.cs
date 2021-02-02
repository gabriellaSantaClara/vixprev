
namespace API_Giphy
{
    partial class frmerenciar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeAtual = new System.Windows.Forms.TextBox();
            this.textNomeNovo = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.text0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deletar GIF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alterar Nome do GIF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do GIF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mudar Nome do GIF Para:";
            // 
            // textNomeAtual
            // 
            this.textNomeAtual.Location = new System.Drawing.Point(12, 36);
            this.textNomeAtual.Name = "textNomeAtual";
            this.textNomeAtual.Size = new System.Drawing.Size(149, 20);
            this.textNomeAtual.TabIndex = 5;
            // 
            // textNomeNovo
            // 
            this.textNomeNovo.Location = new System.Drawing.Point(12, 213);
            this.textNomeNovo.Name = "textNomeNovo";
            this.textNomeNovo.Size = new System.Drawing.Size(141, 20);
            this.textNomeNovo.TabIndex = 6;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(12, 101);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(144, 20);
            this.text1.TabIndex = 8;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(326, 101);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(144, 20);
            this.text3.TabIndex = 9;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(167, 101);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(144, 20);
            this.text2.TabIndex = 10;
            this.text2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "Pesquisar em Favoritos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // text0
            // 
            this.text0.Location = new System.Drawing.Point(485, 101);
            this.text0.Name = "text0";
            this.text0.Size = new System.Drawing.Size(144, 20);
            this.text0.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resultado da Pesquisa:";
            // 
            // frmerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.textNomeNovo);
            this.Controls.Add(this.textNomeAtual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmerenciar";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomeAtual;
        private System.Windows.Forms.TextBox textNomeNovo;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox text0;
        private System.Windows.Forms.Label label3;
    }
}