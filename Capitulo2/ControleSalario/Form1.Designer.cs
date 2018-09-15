namespace ControleSalario
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
            this.components = new System.ComponentModel.Container();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rbNoturno = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rbVeterano = new System.Windows.Forms.RadioButton();
            this.rbCaloouro = new System.Windows.Forms.RadioButton();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxTurno.SuspendLayout();
            this.gbxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(23, 22);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(75, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salario Minimo";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(23, 52);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(97, 13);
            this.lblHorasTrabalhadas.TabIndex = 1;
            this.lblHorasTrabalhadas.Text = "Horas Trabalhadas";
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rbNoturno);
            this.gbxTurno.Controls.Add(this.rbVespertino);
            this.gbxTurno.Controls.Add(this.rbMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(341, 22);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(117, 100);
            this.gbxTurno.TabIndex = 2;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rbNoturno
            // 
            this.rbNoturno.AutoSize = true;
            this.rbNoturno.Location = new System.Drawing.Point(17, 68);
            this.rbNoturno.Name = "rbNoturno";
            this.rbNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbNoturno.TabIndex = 2;
            this.rbNoturno.TabStop = true;
            this.rbNoturno.Text = "Noturno";
            this.rbNoturno.UseVisualStyleBackColor = true;
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Location = new System.Drawing.Point(17, 44);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(75, 17);
            this.rbVespertino.TabIndex = 1;
            this.rbVespertino.TabStop = true;
            this.rbVespertino.Text = "Vespertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Location = new System.Drawing.Point(17, 20);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbMatutino.TabIndex = 0;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(137, 22);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioMinimo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSalarioMinimo, "Informe o valor para o salário minimo ");
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(137, 48);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabalhadas.TabIndex = 4;
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rbVeterano);
            this.gbxCategoria.Controls.Add(this.rbCaloouro);
            this.gbxCategoria.Location = new System.Drawing.Point(26, 90);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(200, 41);
            this.gbxCategoria.TabIndex = 5;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rbVeterano
            // 
            this.rbVeterano.AutoSize = true;
            this.rbVeterano.Location = new System.Drawing.Point(111, 20);
            this.rbVeterano.Name = "rbVeterano";
            this.rbVeterano.Size = new System.Drawing.Size(68, 17);
            this.rbVeterano.TabIndex = 1;
            this.rbVeterano.TabStop = true;
            this.rbVeterano.Text = "Veterano";
            this.rbVeterano.UseVisualStyleBackColor = true;
            // 
            // rbCaloouro
            // 
            this.rbCaloouro.AutoSize = true;
            this.rbCaloouro.Location = new System.Drawing.Point(7, 20);
            this.rbCaloouro.Name = "rbCaloouro";
            this.rbCaloouro.Size = new System.Drawing.Size(61, 17);
            this.rbCaloouro.TabIndex = 0;
            this.rbCaloouro.TabStop = true;
            this.rbCaloouro.Text = "Calouro";
            this.rbCaloouro.UseVisualStyleBackColor = true;
            // 
            // lbxResultado
            // 
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.Location = new System.Drawing.Point(26, 137);
            this.lbxResultado.MultiColumn = true;
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxResultado.Size = new System.Drawing.Size(432, 82);
            this.lbxResultado.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(26, 250);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(248, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(383, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 341);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.lblSalario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rbNoturno;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton rbVeterano;
        private System.Windows.Forms.RadioButton rbCaloouro;
        private System.Windows.Forms.ListBox lbxResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

