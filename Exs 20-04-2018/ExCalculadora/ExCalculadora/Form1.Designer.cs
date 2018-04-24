namespace WindowsFormsApplication1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.rSomar = new System.Windows.Forms.Label();
            this.rSub = new System.Windows.Forms.Label();
            this.rMulti = new System.Windows.Forms.Label();
            this.rDivi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(42, 247);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(275, 83);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(275, 152);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(275, 215);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 7;
            this.btnMulti.Text = "Multiplicar";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(275, 283);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.button4_Click);
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(45, 119);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(100, 20);
            this.txbValor1.TabIndex = 9;
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(45, 199);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(100, 20);
            this.txbValor2.TabIndex = 10;
            // 
            // rSomar
            // 
            this.rSomar.AutoSize = true;
            this.rSomar.Location = new System.Drawing.Point(382, 92);
            this.rSomar.Name = "rSomar";
            this.rSomar.Size = new System.Drawing.Size(16, 13);
            this.rSomar.TabIndex = 11;
            this.rSomar.Text = "...";
            // 
            // rSub
            // 
            this.rSub.AutoSize = true;
            this.rSub.Location = new System.Drawing.Point(382, 162);
            this.rSub.Name = "rSub";
            this.rSub.Size = new System.Drawing.Size(16, 13);
            this.rSub.TabIndex = 12;
            this.rSub.Text = "...";
            // 
            // rMulti
            // 
            this.rMulti.AutoSize = true;
            this.rMulti.Location = new System.Drawing.Point(385, 224);
            this.rMulti.Name = "rMulti";
            this.rMulti.Size = new System.Drawing.Size(16, 13);
            this.rMulti.TabIndex = 13;
            this.rMulti.Text = "...";
            // 
            // rDivi
            // 
            this.rDivi.AutoSize = true;
            this.rDivi.Location = new System.Drawing.Point(388, 292);
            this.rDivi.Name = "rDivi";
            this.rDivi.Size = new System.Drawing.Size(16, 13);
            this.rDivi.TabIndex = 14;
            this.rDivi.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 356);
            this.Controls.Add(this.rDivi);
            this.Controls.Add(this.rMulti);
            this.Controls.Add(this.rSub);
            this.Controls.Add(this.rSomar);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.Label rSomar;
        private System.Windows.Forms.Label rSub;
        private System.Windows.Forms.Label rMulti;
        private System.Windows.Forms.Label rDivi;
    }
}

