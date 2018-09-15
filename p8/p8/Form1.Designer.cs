namespace p8
{
    partial class Form1
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
            this.text_Exame1 = new System.Windows.Forms.TextBox();
            this.label_Exame1 = new System.Windows.Forms.Label();
            this.label_Exame2 = new System.Windows.Forms.Label();
            this.label_Exame3 = new System.Windows.Forms.Label();
            this.label_Classificacao_final = new System.Windows.Forms.Label();
            this.text_Exame2 = new System.Windows.Forms.TextBox();
            this.text_Exame3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTAS DO ALUNO:";
            // 
            // text_Exame1
            // 
            this.text_Exame1.Location = new System.Drawing.Point(145, 89);
            this.text_Exame1.Name = "text_Exame1";
            this.text_Exame1.Size = new System.Drawing.Size(100, 20);
            this.text_Exame1.TabIndex = 1;
            this.text_Exame1.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // label_Exame1
            // 
            this.label_Exame1.AutoSize = true;
            this.label_Exame1.Location = new System.Drawing.Point(50, 92);
            this.label_Exame1.Name = "label_Exame1";
            this.label_Exame1.Size = new System.Drawing.Size(56, 13);
            this.label_Exame1.TabIndex = 2;
            this.label_Exame1.Text = "EXAME 1:";
            // 
            // label_Exame2
            // 
            this.label_Exame2.AutoSize = true;
            this.label_Exame2.Location = new System.Drawing.Point(50, 119);
            this.label_Exame2.Name = "label_Exame2";
            this.label_Exame2.Size = new System.Drawing.Size(56, 13);
            this.label_Exame2.TabIndex = 3;
            this.label_Exame2.Text = "EXAME 2:";
            // 
            // label_Exame3
            // 
            this.label_Exame3.AutoSize = true;
            this.label_Exame3.Location = new System.Drawing.Point(50, 152);
            this.label_Exame3.Name = "label_Exame3";
            this.label_Exame3.Size = new System.Drawing.Size(56, 13);
            this.label_Exame3.TabIndex = 4;
            this.label_Exame3.Text = "EXAME 3:";
            // 
            // label_Classificacao_final
            // 
            this.label_Classificacao_final.AutoSize = true;
            this.label_Classificacao_final.Location = new System.Drawing.Point(35, 209);
            this.label_Classificacao_final.Name = "label_Classificacao_final";
            this.label_Classificacao_final.Size = new System.Drawing.Size(125, 13);
            this.label_Classificacao_final.TabIndex = 5;
            this.label_Classificacao_final.Text = "CLASSIFICAÇÃO FINAL:";
            // 
            // text_Exame2
            // 
            this.text_Exame2.Location = new System.Drawing.Point(145, 119);
            this.text_Exame2.Name = "text_Exame2";
            this.text_Exame2.Size = new System.Drawing.Size(100, 20);
            this.text_Exame2.TabIndex = 6;
            this.text_Exame2.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // text_Exame3
            // 
            this.text_Exame3.Location = new System.Drawing.Point(145, 152);
            this.text_Exame3.Name = "text_Exame3";
            this.text_Exame3.Size = new System.Drawing.Size(100, 20);
            this.text_Exame3.TabIndex = 7;
            this.text_Exame3.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.text_Exame3);
            this.Controls.Add(this.text_Exame2);
            this.Controls.Add(this.label_Classificacao_final);
            this.Controls.Add(this.label_Exame3);
            this.Controls.Add(this.label_Exame2);
            this.Controls.Add(this.label_Exame1);
            this.Controls.Add(this.text_Exame1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Exame1;
        private System.Windows.Forms.Label label_Exame1;
        private System.Windows.Forms.Label label_Exame2;
        private System.Windows.Forms.Label label_Exame3;
        private System.Windows.Forms.Label label_Classificacao_final;
        private System.Windows.Forms.TextBox text_Exame2;
        private System.Windows.Forms.TextBox text_Exame3;
    }
}

