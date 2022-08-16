namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primeiroDigito;
        double segundoDigito;
        double resultado;
        bool soma = false;
        bool sub = false;
        bool mult = false;
        bool div = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "1";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "1";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "1";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "1";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "1";

            }
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "2";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "2";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "2";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "2";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "2";

            }
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "3";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "3";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "3";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "3";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "3";

            }
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "4";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "4";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "4";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "4";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "4";

            }

        }

        private void botao5_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "5";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "5";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "5";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "5";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "5";

            }

        }

        private void botao6_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "6";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "6";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "6";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "6";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "6";

            }

        }

        private void botao7_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "7";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "7";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "7";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "7";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "7";

            }

        }

        private void botao8_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "8";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "8";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "8";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "8";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "8";

            }

        }

        private void botao9_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "9";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "9";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "9";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "9";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "9";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblValor.Text = lblValor.Text + "0";

            if (lblValor.Text.Contains("+"))
            {
                lblValor.Text = "0";
            }
            else if (lblValor.Text.Contains("-"))
            {
                lblValor.Text = "0";
            }
            else if (lblValor.Text.Contains("*"))
            {
                lblValor.Text = "0";
            }
            else if (lblValor.Text.Contains("/"))
            {
                lblValor.Text = "0";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblValor.Text = "";
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            segundoDigito = Convert.ToDouble(lblValor.Text);
            if (div == true)
            {
                resultado = primeiroDigito / segundoDigito;
                lblValor.Text = Convert.ToString(resultado);
                div = false;
            }

            if (mult == true)
            {
                resultado = primeiroDigito * segundoDigito;
                lblValor.Text = Convert.ToString(resultado);
                mult = false;
            }

            if (soma == true)
            {

                resultado = primeiroDigito + segundoDigito;
                lblValor.Text = Convert.ToString(resultado);
                soma = false;
            }

            if (sub == true)
            {
                resultado = primeiroDigito - segundoDigito;
                lblValor.Text = Convert.ToString(resultado);
                sub = false;
            }

        }
        private void botaoMais_Click(object sender, EventArgs e)
        {
            primeiroDigito = Convert.ToDouble(lblValor.Text);
            lblValor.Text = "+";
            soma = true;

        }

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            primeiroDigito = Convert.ToDouble(lblValor.Text);
            lblValor.Text = "-";
            sub = true;

        }

        private void botaoVezes_Click(object sender, EventArgs e)
        {
            primeiroDigito = Convert.ToDouble(lblValor.Text);
            lblValor.Text = "*";
            mult = true;
        }

        private void botaoDividido_Click(object sender, EventArgs e)
        {
            primeiroDigito = Convert.ToDouble(lblValor.Text);
            lblValor.Text = "/";
            div = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!lblValor.Text.Contains("+"))
            {
                lblValor.Text = lblValor.Text + ",";
            }
            else if (!lblValor.Text.Contains("-"))
            {
                lblValor.Text = lblValor.Text + ",";
            }
            else if (!lblValor.Text.Contains("*"))
            {
                lblValor.Text = lblValor.Text + ",";
            }
            else if (!lblValor.Text.Contains("/"))
            {
                lblValor.Text = lblValor.Text + ",";
            }
        }
    }
}