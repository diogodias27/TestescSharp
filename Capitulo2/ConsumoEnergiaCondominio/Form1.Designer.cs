namespace ConsumoEnergiaCondominio
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
            this.lblNumeroCasa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.lblApresentar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroCasa
            // 
            this.lblNumeroCasa.AutoSize = true;
            this.lblNumeroCasa.Location = new System.Drawing.Point(12, 15);
            this.lblNumeroCasa.Name = "lblNumeroCasa";
            this.lblNumeroCasa.Size = new System.Drawing.Size(46, 13);
            this.lblNumeroCasa.TabIndex = 0;
            this.lblNumeroCasa.Text = "N° Casa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumo";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(64, 12);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(49, 20);
            this.txtNumeroCasa.TabIndex = 2;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(185, 12);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(40, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(308, 15);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 170);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(15, 236);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(106, 23);
            this.btnProcessarDados.TabIndex = 6;
            this.btnProcessarDados.Text = "Processar Dados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // lblApresentar
            // 
            this.lblApresentar.AutoSize = true;
            this.lblApresentar.Location = new System.Drawing.Point(279, 241);
            this.lblApresentar.Name = "lblApresentar";
            this.lblApresentar.Size = new System.Drawing.Size(25, 13);
            this.lblApresentar.TabIndex = 7;
            this.lblApresentar.Text = "------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 283);
            this.Controls.Add(this.lblApresentar);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeroCasa);
            this.Name = "Form1";
            this.Text = "Consumo Energia Eletrica ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroCasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.Label lblApresentar;
    }
}

