using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> Tabela = new List<int>() { 987, 236, 547, 72, 138, 790, 83, -435, 234, 34 };

            txtMedia.Text = Convert.ToString(RetornaMedia(Tabela));

        }

        public double RetornaMedia(List<int> tabela)
        {
            if (tabela.Count < 0 || tabela.Count >= 100)
            {
                return -1;
            }

            double somaMedia = 0;
            int divisores;

            List<int> listNumeros = new List<int>();

            foreach (var item in tabela)
            {
                    divisores = 0;

                    for (int i = 1; i <= item; i++)
                    {
                        if (item % i == 0)
                        {
                            divisores++;
                        }
                    }

                if (item > 0 && divisores != 2)
                {
                    listNumeros.Add(item);

                }
            }

            foreach (var numero in listNumeros)
            {
                somaMedia =+ numero;
            }

            return somaMedia;
        }
    }
}
