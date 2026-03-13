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
            int num1 = int.Parse(txtCampo.Text);
            int num2 = int.Parse(txtCampo2.Text);
            int num3 = int.Parse(txtCampo3.Text);

            if (num1 >  num2 > 0)
            {
                result = Convert.ToDouble(n1);
            
            {
                result = Convert.ToDouble(n2);
            }
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
    }
}
