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
    public partial class Form_Venda : Form
    {
        BindingList<Produtos> listas = new BindingList<Produtos>();
        double valortotal = 0;

        public Form_Venda()
        {
            InitializeComponent();
            Produtos p1 = new Produtos("ração",15);
            Produtos p2 = new Produtos ("brinquedo",50);
            Produtos p3 = new Produtos ("coleira",22.66);
            listas.Add(p1);
            listas.Add(p2);
            listas.Add(p3);
            dgvCompra.Columns.Add("coluna1", "nome do produto");
            dgvCompra.Columns.Add("coluna2", "quantidade do produto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = cbProduto.Text;
            int quantidade = (int)numQuantidade.Value;
            if(nome != string.Empty && quantidade >0)
                // localizando o produto na lista
            {
                dgvCompra.Rows.Add(nome, quantidade);
                Produtos localizarproduto = listas.FirstOrDefault(p => p.Nome_produto == nome);
                double valorproduto = localizarproduto.Preco;
                valortotal = valortotal + (valorproduto * quantidade);
                lbValor.Text = $"TOTAL DO PEDIDO: R$ {valortotal}";

            }

        }
    }
}
