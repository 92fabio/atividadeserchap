namespace WinFormsApp1
{
    partial class txtCampo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIdade = new Button();
            btnTaboada = new Button();
            btnVericarLetra = new Button();
            btnAprendendo = new Button();
            btnContar10 = new Button();
            btnJogar = new Button();
            textCampo = new TextBox();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // btnIdade
            // 
            btnIdade.Location = new Point(155, 122);
            btnIdade.Name = "btnIdade";
            btnIdade.Size = new Size(206, 58);
            btnIdade.TabIndex = 1;
            btnIdade.Text = "Calcular Idade";
            btnIdade.UseVisualStyleBackColor = true;
            btnIdade.Click += btnIdade_Click;
            // 
            // btnTaboada
            // 
            btnTaboada.Location = new Point(393, 122);
            btnTaboada.Name = "btnTaboada";
            btnTaboada.Size = new Size(208, 58);
            btnTaboada.TabIndex = 2;
            btnTaboada.Text = "Calcular Tabuada";
            btnTaboada.UseVisualStyleBackColor = true;
            // 
            // btnVericarLetra
            // 
            btnVericarLetra.Location = new Point(155, 205);
            btnVericarLetra.Name = "btnVericarLetra";
            btnVericarLetra.Size = new Size(206, 57);
            btnVericarLetra.TabIndex = 3;
            btnVericarLetra.Text = "Verficar Letra";
            btnVericarLetra.UseVisualStyleBackColor = true;
            // 
            // btnAprendendo
            // 
            btnAprendendo.Location = new Point(393, 205);
            btnAprendendo.Name = "btnAprendendo";
            btnAprendendo.Size = new Size(208, 57);
            btnAprendendo.TabIndex = 4;
            btnAprendendo.Text = "Estou Aprendendo";
            btnAprendendo.UseVisualStyleBackColor = true;
            btnAprendendo.Click += button4_Click;
            // 
            // btnContar10
            // 
            btnContar10.Location = new Point(155, 289);
            btnContar10.Name = "btnContar10";
            btnContar10.Size = new Size(206, 59);
            btnContar10.TabIndex = 5;
            btnContar10.Text = "Contar até 10";
            btnContar10.UseVisualStyleBackColor = true;
            btnContar10.Click += button5_Click;
            // 
            // btnJogar
            // 
            btnJogar.Location = new Point(393, 289);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(208, 59);
            btnJogar.TabIndex = 6;
            btnJogar.Text = "Mini Jogo";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += button6_Click;
            // 
            // textCampo
            // 
            textCampo.Location = new Point(155, 55);
            textCampo.Name = "textCampo";
            textCampo.Size = new Size(446, 23);
            textCampo.TabIndex = 7;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(155, 92);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 8;
            lbResultado.Text = "Resultado";
            lbResultado.Click += label1_Click;
            // 
            // txtCampo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(textCampo);
            Controls.Add(btnJogar);
            Controls.Add(btnContar10);
            Controls.Add(btnAprendendo);
            Controls.Add(btnVericarLetra);
            Controls.Add(btnTaboada);
            Controls.Add(btnIdade);
            Name = "txtCampo";
            Text = "Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIdade;
        private Button btnTaboada;
        private Button btnVericarLetra;
        private Button btnAprendendo;
        private Button btnContar10;
        private Button btnJogar;
        private TextBox textCampo;
        private Label lbResultado;
    }
}
