namespace Imc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Feminino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Altura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rb_Feminino);
            this.groupBox1.Controls.Add(this.rb_Masculino);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // txt_Altura
            // 
            this.txt_Altura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.txt_Altura.Location = new System.Drawing.Point(150, 44);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(100, 20);
            this.txt_Altura.TabIndex = 3;
            this.txt_Altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Altura";
            // 
            // rb_Feminino
            // 
            this.rb_Feminino.AutoSize = true;
            this.rb_Feminino.Location = new System.Drawing.Point(21, 44);
            this.rb_Feminino.Name = "rb_Feminino";
            this.rb_Feminino.Size = new System.Drawing.Size(67, 17);
            this.rb_Feminino.TabIndex = 1;
            this.rb_Feminino.Text = "Feminino";
            this.rb_Feminino.UseVisualStyleBackColor = true;
            this.rb_Feminino.CheckedChanged += new System.EventHandler(this.rb_Feminino_CheckedChanged);
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(21, 21);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(76, 17);
            this.rb_Masculino.TabIndex = 0;
            this.rb_Masculino.Text = "Masculino ";
            this.rb_Masculino.UseVisualStyleBackColor = true;
            this.rb_Masculino.CheckedChanged += new System.EventHandler(this.rb_Masculino_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso Ideal:";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(112, 167);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 192);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora I.M.C";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Feminino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}

