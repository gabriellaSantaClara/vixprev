
namespace API_Giphy
{
    partial class frmprincipal
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
            this.textGiphy = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textresultado5 = new System.Windows.Forms.TextBox();
            this.textresultado4 = new System.Windows.Forms.TextBox();
            this.textresultado3 = new System.Windows.Forms.TextBox();
            this.textresultado2 = new System.Windows.Forms.TextBox();
            this.textresultado1 = new System.Windows.Forms.TextBox();
            this.pesquisa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLink = new System.Windows.Forms.ComboBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Gerenciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textGiphy
            // 
            this.textGiphy.Location = new System.Drawing.Point(99, 49);
            this.textGiphy.Name = "textGiphy";
            this.textGiphy.Size = new System.Drawing.Size(149, 20);
            this.textGiphy.TabIndex = 0;
            this.textGiphy.TextChanged += new System.EventHandler(this.textGiphy_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textresultado5
            // 
            this.textresultado5.Location = new System.Drawing.Point(99, 249);
            this.textresultado5.Name = "textresultado5";
            this.textresultado5.Size = new System.Drawing.Size(293, 20);
            this.textresultado5.TabIndex = 2;
            // 
            // textresultado4
            // 
            this.textresultado4.Location = new System.Drawing.Point(99, 223);
            this.textresultado4.Name = "textresultado4";
            this.textresultado4.Size = new System.Drawing.Size(293, 20);
            this.textresultado4.TabIndex = 3;
            // 
            // textresultado3
            // 
            this.textresultado3.Location = new System.Drawing.Point(99, 197);
            this.textresultado3.Name = "textresultado3";
            this.textresultado3.Size = new System.Drawing.Size(293, 20);
            this.textresultado3.TabIndex = 4;
            // 
            // textresultado2
            // 
            this.textresultado2.Location = new System.Drawing.Point(99, 171);
            this.textresultado2.Name = "textresultado2";
            this.textresultado2.Size = new System.Drawing.Size(293, 20);
            this.textresultado2.TabIndex = 5;
            // 
            // textresultado1
            // 
            this.textresultado1.Location = new System.Drawing.Point(99, 145);
            this.textresultado1.Name = "textresultado1";
            this.textresultado1.Size = new System.Drawing.Size(293, 20);
            this.textresultado1.TabIndex = 6;
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(99, 90);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(149, 23);
            this.pesquisa.TabIndex = 7;
            this.pesquisa.Text = "Pesquisar por Giphy";
            this.pesquisa.UseVisualStyleBackColor = true;
            this.pesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisar por Giphy: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Opção 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Opção 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Opção 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Opção 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Opção 5";
            // 
            // comboLink
            // 
            this.comboLink.FormattingEnabled = true;
            this.comboLink.Items.AddRange(new object[] {
            "Opção 1",
            "Opção 2",
            "Opção 3",
            "Opção 4",
            "Opção 5"});
            this.comboLink.Location = new System.Drawing.Point(271, 318);
            this.comboLink.Name = "comboLink";
            this.comboLink.Size = new System.Drawing.Size(121, 21);
            this.comboLink.TabIndex = 15;
            this.comboLink.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(99, 319);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(104, 20);
            this.textNome.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome do Giphy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Opção para favoritar:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Favoritar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gerenciar
            // 
            this.Gerenciar.Location = new System.Drawing.Point(111, 405);
            this.Gerenciar.Name = "Gerenciar";
            this.Gerenciar.Size = new System.Drawing.Size(156, 23);
            this.Gerenciar.TabIndex = 21;
            this.Gerenciar.Text = "Gerenciar Favoritos";
            this.Gerenciar.UseVisualStyleBackColor = true;
            this.Gerenciar.Click += new System.EventHandler(this.Gerenciar_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 440);
            this.Controls.Add(this.Gerenciar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.comboLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.textresultado1);
            this.Controls.Add(this.textresultado2);
            this.Controls.Add(this.textresultado3);
            this.Controls.Add(this.textresultado4);
            this.Controls.Add(this.textresultado5);
            this.Controls.Add(this.textGiphy);
            this.Name = "frmprincipal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGiphy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textresultado5;
        private System.Windows.Forms.TextBox textresultado4;
        private System.Windows.Forms.TextBox textresultado3;
        private System.Windows.Forms.TextBox textresultado2;
        private System.Windows.Forms.TextBox textresultado1;
        private System.Windows.Forms.Button pesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboLink;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Gerenciar;
    }
}