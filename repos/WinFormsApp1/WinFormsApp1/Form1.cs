namespace WinFormsApp1
{
    public partial class txtCampo : Form
    {
        public txtCampo()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // etapa 1 - gerar um número aleatorio
            Random aleatorio = new Random();
            int numeroSorteado = aleatorio.Next(1, 11);

            string numeroSecretoSorteado = lbResultado.Text;
            string numeroDigitadoUsuario = textCampo.Text;
           
            if (numeroSecretoSorteado == "Resultado")
            {
                lbResultado.Text = numeroSecretoSorteado.ToString();
                numeroSecretoSorteado = numeroSecretoSorteado.ToString();
                lbResultado.Visible = false;
            }
          
            // etapa 2 - pegar valor do usuario e validar se é igual ao número sorteado
            if (numeroSecretoSorteado == numeroDigitadoUsuario)
            {
                MessageBox.Show("Parabéns você ganhou!! ");
            }
            // etapa 3 - validar se o número é maior que o número sorteado
            if (int.Parse(numeroDigitadoUsuario) > int.Parse(numeroDigitadoUsuario))
            {
                MessageBox.Show("O número que você digitou é MAIOR que o valor secreto");
            }
            //etapa 4 - validar se o número é menor que o sorteado
            if (int.Parse(numeroDigitadoUsuario) < int.Parse(numeroSecretoSorteado))
            {
                MessageBox.Show("O numero que você digitou é MENOR que o valor secreto");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numeroUsuario = 7;
            int contador = 0;

            while (contador < 10)  
            {
                if (contador == numeroUsuario)
                {
                    // continue da 'um pulo' no codico, ele faz o lopo voltar para o começo e ignore o resto do laço
                    // continue

                    // break finaliza a execução do loop todo, diferente do continue que vai rodar até finalizar o 
                    // laço o break força o laço a ser finalizado
                    break;
                
                }
                MessageBox.Show("Contagem " + contador);
                contador++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnIdade_Click(object sender, EventArgs e)
        {

            if (textCampo.Text != string.Empty)
            {

                int idadeUsuario = int.Parse(textCampo.Text);

                // se a idadecdo usuario for maior ou igaul a 18
                // resultado: Você é maior de idade

                if (idadeUsuario >= 18)
                {
                    //MessageBox.Show("Você é MAIOR de idade");
                    lbResultado.Text = "Você é MAIOR de idade";


                } else
                {
                    //MessgeBOx.Show("Você é MENOR de idade");
                    lbResultado.Text = "Você é MENOR de idade";
                }
            } else
            {
                MessageBox.Show("Por favor insira a sua idade",
                    "Mensage de Aviso");
            }





        }
    }
}
