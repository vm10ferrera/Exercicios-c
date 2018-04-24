namespace WindowsFormsApplication1
{
    partial class frmMedia
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
            this.lblAluno = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbl1Bim = new System.Windows.Forms.Label();
            this.txb1Bim = new System.Windows.Forms.TextBox();
            this.lbl2Bim = new System.Windows.Forms.Label();
            this.txb2Bim = new System.Windows.Forms.TextBox();
            this.lbl3Bim = new System.Windows.Forms.Label();
            this.txb3Bim = new System.Windows.Forms.TextBox();
            this.lbl4Bim = new System.Windows.Forms.Label();
            this.txb4Bim = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(40, 27);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(80, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Nome do Aluno";
            this.lblAluno.Click += new System.EventHandler(this.lblAluno_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(126, 24);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl1Bim
            // 
            this.lbl1Bim.AutoSize = true;
            this.lbl1Bim.Location = new System.Drawing.Point(14, 76);
            this.lbl1Bim.Name = "lbl1Bim";
            this.lbl1Bim.Size = new System.Drawing.Size(35, 13);
            this.lbl1Bim.TabIndex = 2;
            this.lbl1Bim.Text = "1 BIM";
            this.lbl1Bim.Click += new System.EventHandler(this.lbl1Bim_Click);
            // 
            // txb1Bim
            // 
            this.txb1Bim.Location = new System.Drawing.Point(55, 73);
            this.txb1Bim.Name = "txb1Bim";
            this.txb1Bim.Size = new System.Drawing.Size(100, 20);
            this.txb1Bim.TabIndex = 3;
            this.txb1Bim.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl2Bim
            // 
            this.lbl2Bim.AutoSize = true;
            this.lbl2Bim.Location = new System.Drawing.Point(170, 76);
            this.lbl2Bim.Name = "lbl2Bim";
            this.lbl2Bim.Size = new System.Drawing.Size(35, 13);
            this.lbl2Bim.TabIndex = 4;
            this.lbl2Bim.Text = "2 BIM";
            this.lbl2Bim.Click += new System.EventHandler(this.lbl2Bim_Click);
            // 
            // txb2Bim
            // 
            this.txb2Bim.Location = new System.Drawing.Point(212, 72);
            this.txb2Bim.Name = "txb2Bim";
            this.txb2Bim.Size = new System.Drawing.Size(100, 20);
            this.txb2Bim.TabIndex = 5;
            this.txb2Bim.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl3Bim
            // 
            this.lbl3Bim.AutoSize = true;
            this.lbl3Bim.Location = new System.Drawing.Point(12, 122);
            this.lbl3Bim.Name = "lbl3Bim";
            this.lbl3Bim.Size = new System.Drawing.Size(35, 13);
            this.lbl3Bim.TabIndex = 6;
            this.lbl3Bim.Text = "3 BIM";
            this.lbl3Bim.Click += new System.EventHandler(this.label4_Click);
            // 
            // txb3Bim
            // 
            this.txb3Bim.Location = new System.Drawing.Point(55, 119);
            this.txb3Bim.Name = "txb3Bim";
            this.txb3Bim.Size = new System.Drawing.Size(100, 20);
            this.txb3Bim.TabIndex = 7;
            this.txb3Bim.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl4Bim
            // 
            this.lbl4Bim.AutoSize = true;
            this.lbl4Bim.Location = new System.Drawing.Point(170, 122);
            this.lbl4Bim.Name = "lbl4Bim";
            this.lbl4Bim.Size = new System.Drawing.Size(35, 13);
            this.lbl4Bim.TabIndex = 8;
            this.lbl4Bim.Text = "4 BIM";
            this.lbl4Bim.Click += new System.EventHandler(this.lbl4Bim_Click);
            // 
            // txb4Bim
            // 
            this.txb4Bim.Location = new System.Drawing.Point(212, 116);
            this.txb4Bim.Name = "txb4Bim";
            this.txb4Bim.Size = new System.Drawing.Size(100, 20);
            this.txb4Bim.TabIndex = 9;
            this.txb4Bim.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(130, 173);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(94, 242);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(16, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "...";
            this.lblNome.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(94, 269);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(69, 13);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Sua média é:";
            this.lbl3.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(161, 269);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 13);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "...";
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 327);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txb4Bim);
            this.Controls.Add(this.lbl4Bim);
            this.Controls.Add(this.txb3Bim);
            this.Controls.Add(this.lbl3Bim);
            this.Controls.Add(this.txb2Bim);
            this.Controls.Add(this.lbl2Bim);
            this.Controls.Add(this.txb1Bim);
            this.Controls.Add(this.lbl1Bim);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblAluno);
            this.Name = "frmMedia";
            this.Text = "Cálculo da Média";
            this.Load += new System.EventHandler(this.frmMedia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbl1Bim;
        private System.Windows.Forms.TextBox txb1Bim;
        private System.Windows.Forms.Label lbl2Bim;
        private System.Windows.Forms.TextBox txb2Bim;
        private System.Windows.Forms.Label lbl3Bim;
        private System.Windows.Forms.TextBox txb3Bim;
        private System.Windows.Forms.Label lbl4Bim;
        private System.Windows.Forms.TextBox txb4Bim;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblResultado;
    }
}

