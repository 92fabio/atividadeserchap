namespace atividade_12_03_26
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnVerificarNumero = new System.Windows.Forms.Button();
            this.btnLeiaNumero = new System.Windows.Forms.Button();
            this.btnLeiaLetra = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCalculeSalario = new System.Windows.Forms.Button();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.txtCampo3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(207, 47);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(404, 20);
            this.txtCampo.TabIndex = 0;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(207, 80);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "Resultado";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // btnVerificarNumero
            // 
            this.btnVerificarNumero.Location = new System.Drawing.Point(198, 219);
            this.btnVerificarNumero.Name = "btnVerificarNumero";
            this.btnVerificarNumero.Size = new System.Drawing.Size(183, 66);
            this.btnVerificarNumero.TabIndex = 2;
            this.btnVerificarNumero.Text = "Verifique Número";
            this.btnVerificarNumero.UseVisualStyleBackColor = true;
            this.btnVerificarNumero.Click += new System.EventHandler(this.btnVerificarNumero_Click);
            // 
            // btnLeiaNumero
            // 
            this.btnLeiaNumero.Location = new System.Drawing.Point(387, 219);
            this.btnLeiaNumero.Name = "btnLeiaNumero";
            this.btnLeiaNumero.Size = new System.Drawing.Size(215, 66);
            this.btnLeiaNumero.TabIndex = 3;
            this.btnLeiaNumero.Text = "Leia Número";
            this.btnLeiaNumero.UseVisualStyleBackColor = true;
            this.btnLeiaNumero.Click += new System.EventHandler(this.btnLeiaNumero_Click);
            // 
            // btnLeiaLetra
            // 
            this.btnLeiaLetra.Location = new System.Drawing.Point(198, 299);
            this.btnLeiaLetra.Name = "btnLeiaLetra";
            this.btnLeiaLetra.Size = new System.Drawing.Size(183, 63);
            this.btnLeiaLetra.TabIndex = 4;
            this.btnLeiaLetra.Text = "Leia Letra";
            this.btnLeiaLetra.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "Leia Dias";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(198, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 63);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnCalculeSalario
            // 
            this.btnCalculeSalario.Location = new System.Drawing.Point(387, 378);
            this.btnCalculeSalario.Name = "btnCalculeSalario";
            this.btnCalculeSalario.Size = new System.Drawing.Size(215, 60);
            this.btnCalculeSalario.TabIndex = 7;
            this.btnCalculeSalario.Text = "Calcule Sálario";
            this.btnCalculeSalario.UseVisualStyleBackColor = true;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(477, 123);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(125, 20);
            this.txtCampo2.TabIndex = 8;
            // 
            // txtCampo3
            // 
            this.txtCampo3.Location = new System.Drawing.Point(477, 159);
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(125, 20);
            this.txtCampo3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "2° Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "1° Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "3° Número";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCampo3);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.btnCalculeSalario);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLeiaLetra);
            this.Controls.Add(this.btnLeiaNumero);
            this.Controls.Add(this.btnVerificarNumero);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtCampo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnVerificarNumero;
        private System.Windows.Forms.Button btnLeiaNumero;
        private System.Windows.Forms.Button btnLeiaLetra;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCalculeSalario;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.TextBox txtCampo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

