namespace CriarBD
{
    partial class frmCriarBanco
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
            this.btnCriarMDB = new System.Windows.Forms.Button();
            this.btnCriarTabelas = new System.Windows.Forms.Button();
            this.btnCriarRestricoes = new System.Windows.Forms.Button();
            this.Dir = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.Drive = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.SuspendLayout();
            // 
            // btnCriarMDB
            // 
            this.btnCriarMDB.Location = new System.Drawing.Point(12, 216);
            this.btnCriarMDB.Name = "btnCriarMDB";
            this.btnCriarMDB.Size = new System.Drawing.Size(75, 46);
            this.btnCriarMDB.TabIndex = 0;
            this.btnCriarMDB.Text = "Criar MDB\r\n";
            this.btnCriarMDB.UseVisualStyleBackColor = true;
            // 
            // btnCriarTabelas
            // 
            this.btnCriarTabelas.Location = new System.Drawing.Point(123, 216);
            this.btnCriarTabelas.Name = "btnCriarTabelas";
            this.btnCriarTabelas.Size = new System.Drawing.Size(75, 46);
            this.btnCriarTabelas.TabIndex = 1;
            this.btnCriarTabelas.Text = "Criar Tabelas\r\n";
            this.btnCriarTabelas.UseVisualStyleBackColor = true;
            // 
            // btnCriarRestricoes
            // 
            this.btnCriarRestricoes.Location = new System.Drawing.Point(232, 216);
            this.btnCriarRestricoes.Name = "btnCriarRestricoes";
            this.btnCriarRestricoes.Size = new System.Drawing.Size(75, 46);
            this.btnCriarRestricoes.TabIndex = 2;
            this.btnCriarRestricoes.Text = "Criar Restrições";
            this.btnCriarRestricoes.UseVisualStyleBackColor = true;
            // 
            // Dir
            // 
            this.Dir.FormattingEnabled = true;
            this.Dir.IntegralHeight = false;
            this.Dir.Location = new System.Drawing.Point(10, 31);
            this.Dir.Name = "Dir";
            this.Dir.Size = new System.Drawing.Size(297, 179);
            this.Dir.TabIndex = 3;
            // 
            // Drive
            // 
            this.Drive.FormattingEnabled = true;
            this.Drive.Location = new System.Drawing.Point(-1, 4);
            this.Drive.Name = "Drive";
            this.Drive.Size = new System.Drawing.Size(308, 21);
            this.Drive.TabIndex = 4;
            this.Drive.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // frmCriarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 267);
            this.Controls.Add(this.Drive);
            this.Controls.Add(this.Dir);
            this.Controls.Add(this.btnCriarRestricoes);
            this.Controls.Add(this.btnCriarTabelas);
            this.Controls.Add(this.btnCriarMDB);
            this.Name = "frmCriarBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criação do Banco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarMDB;
        private System.Windows.Forms.Button btnCriarTabelas;
        private System.Windows.Forms.Button btnCriarRestricoes;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox Dir;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox Drive;
    }
}

