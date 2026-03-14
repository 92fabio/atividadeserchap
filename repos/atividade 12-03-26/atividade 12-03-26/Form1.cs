using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace atividade_12_03_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarNumero_Click(object sender, EventArgs e)
        {
            int verificarNumero = int.Parse(txtCampo.Text);


            if (verificarNumero >= 0)
            {
                btnVerificarNumero.Text = "Você é positivo";
            }

            if (verificarNumero <= 0)
            {
                btnVerificarNumero.Text = "Esse número é negativo";
            }

            if (verificarNumero == 0)
            {
                btnVerificarNumero.Text = "Esse resultado é zero";
            }
        }

        private void btnLeiaNumero_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(txtCampo2.Text);
            int num3 = int.Parse(txtCampo3.Text);

            if (num1 > num2 && num1 > num3)
            {
                MessageBox.Show("O maior número é " + num1);
            }

             if (num2 > num1 && num2 > num3)
            {
                MessageBox.Show("O maior número é " + num2);
            }
            if (num3 > num1 && num3 > num2) 
            {
                MessageBox.Show("O maior número é " + num3);
            }

        
        }
        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLeiaLetra_Click(object sender, EventArgs e)
        {
            string letra = txtCampo.Text;

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                MessageBox.Show("Essa letra é vogal");
            }

            if (letra == "b" || letra == "c" || letra == "d" || letra == "f" || letra == "g" || letra == "h")
            {
                MessageBox.Show("Essa letra é consoante");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string meses = txtCampo.Text;

            string dias28 = "28";
            string dias31 = "31";
            string dias30 = "30";

            if (meses == "01" || meses == "janeiro" || meses == "03" || meses == "março" || meses == "05" || meses == "maio" || meses == "07" || meses == "julho" || meses == "08" || meses == "agosto" || meses == "10" || meses == "outubro" || meses == "12" || meses == "dzembro")
            {
                MessageBox.Show("O mês de " + meses + " possui " + dias31);
            } else  if (meses == "04" || meses == "abril" || meses == "06" || meses == "junho" || meses == "09" || meses == "setembro" || meses == "09" || meses == "novembro")
            {
                MessageBox.Show("O mês de " + meses + " possui " + dias30);
            }
            else if(meses == "02" || meses == "fevereiro")
            {
                MessageBox.Show("Mês de fevereiro possui " + dias28);
            }
            else
            {
                MessageBox.Show("não é um mês valido");
            }
    
            }
        }
    }

