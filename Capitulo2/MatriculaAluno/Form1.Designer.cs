namespace MatriculaAluno
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_ultimoAniversario = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.txt_Ultimo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(3, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome ";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(3, 42);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(85, 13);
            this.lbl_nascimento.TabIndex = 1;
            this.lbl_nascimento.Text = "Ano Nascimento";
            // 
            // lbl_ultimoAniversario
            // 
            this.lbl_ultimoAniversario.AutoSize = true;
            this.lbl_ultimoAniversario.Location = new System.Drawing.Point(154, 42);
            this.lbl_ultimoAniversario.Name = "lbl_ultimoAniversario";
            this.lbl_ultimoAniversario.Size = new System.Drawing.Size(114, 13);
            this.lbl_ultimoAniversario.TabIndex = 2;
            this.lbl_ultimoAniversario.Text = "Ano ultimo Aniversario ";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(56, 6);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(255, 20);
            this.txt_Nome.TabIndex = 3;
            this.txt_Nome.Enter += new System.EventHandler(this.txt_Nome_Enter);
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(94, 39);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(47, 20);
            this.txt_nascimento.TabIndex = 4;
            this.txt_nascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Ultimo_Validating);
            // 
            // txt_Ultimo
            // 
            this.txt_Ultimo.Location = new System.Drawing.Point(274, 39);
            this.txt_Ultimo.Name = "txt_Ultimo";
            this.txt_Ultimo.Size = new System.Drawing.Size(53, 20);
            this.txt_Ultimo.TabIndex = 5;
            this.txt_Ultimo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Ultimo_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Identificar Categoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Location = new System.Drawing.Point(182, 75);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(145, 25);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "&Nome";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 109);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Ultimo);
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_ultimoAniversario);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Matricula Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_ultimoAniversario;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.TextBox txt_Ultimo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCategoria;
    }
}

