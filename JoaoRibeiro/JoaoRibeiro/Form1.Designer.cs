namespace JoaoRibeiro
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblTela = new System.Windows.Forms.Label();
            this.txtParcela1 = new System.Windows.Forms.TextBox();
            this.txtParcela2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(68, 55);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(0, 13);
            this.lblTela.TabIndex = 1;
            // 
            // txtParcela1
            // 
            this.txtParcela1.Location = new System.Drawing.Point(13, 28);
            this.txtParcela1.Name = "txtParcela1";
            this.txtParcela1.Size = new System.Drawing.Size(100, 20);
            this.txtParcela1.TabIndex = 2;
            // 
            // txtParcela2
            // 
            this.txtParcela2.Location = new System.Drawing.Point(13, 71);
            this.txtParcela2.Name = "txtParcela2";
            this.txtParcela2.Size = new System.Drawing.Size(100, 20);
            this.txtParcela2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(24, 155);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtParcela2);
            this.Controls.Add(this.txtParcela1);
            this.Controls.Add(this.lblTela);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.TextBox txtParcela1;
        private System.Windows.Forms.TextBox txtParcela2;
        private System.Windows.Forms.Label lblResultado;
    }
}

