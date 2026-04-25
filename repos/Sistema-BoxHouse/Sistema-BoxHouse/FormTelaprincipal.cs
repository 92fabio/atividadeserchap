using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_BoxHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Form_Venda formvenda = new Form_Venda();
            formvenda.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormClientes formecliente = new FormClientes();
            formecliente.ShowDialog();
        }
    }
}
