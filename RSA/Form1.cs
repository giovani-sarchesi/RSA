using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        public int P;
        public int Q;
        public int Z;
        public int N;
        public int D;
        public int E;
        public string textoOriginal;
        public string textoCriptografado;
        public string textoDescriptografado;
        public List<int> fatoracaoZ = new List<int>();
        public List<int> fatoracaoD = new List<int>();
        public List<int> valoresIguais = new List<int>();
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarChaves_Click(object sender, EventArgs e)
        {
            try
            {

                //Verifica se os valores de P e Q foram selecionados.
                if (cbxP.SelectedItem == null || cbxQ.SelectedItem == null)
                    throw new Exception("Obrigatório selecionar valores para P e Q.");

                //Atribui valor as variáveis inicias P, Q
                P = Convert.ToInt32(cbxP.SelectedItem);
                Q = Convert.ToInt32(cbxQ.SelectedItem);

                //Gerando valores de N e Z
                N = P * Q;
                Z = (P - 1) * (Q - 1);

                //Setando valores no front e zera lista de Fatoração Z
                txtN.Text = N.ToString();
                txtZ.Text = Z.ToString();
                fatoracaoZ.Clear();

                //Realizando fatoração de Z
                for(int x = 1; x <= Z; x++)
                {
                    if(Z%x == 0)
                    {
                        fatoracaoZ.Add(x);
                    }
                }

                //Achando divisores para encontrar o valor de D
                for(int y = 17; y <= 100; y++)
                {
                    fatoracaoD.Clear();
                    valoresIguais.Clear();
                    //Achando divisores "valor" de D, ainda provisório
                    for(int w = 1; w <=y; w++)
                    {
                        if(y%w == 0)
                        {
                            fatoracaoD.Add(w);
                        }
                    }

                    //Verificando valores que são iguais entre 
                    //os divisores de Z e D
                    foreach(int vlrD in fatoracaoD)
                    {
                        if(fatoracaoZ.Contains(vlrD))
                            valoresIguais.Add(vlrD);
                    }

                    //Verificando se apenas o 1 é igual nas duas listas
                    //caso seja, o valor de D foi encontrado e a estrutura
                    //de repetição é quebrada
                    if(valoresIguais.Count == 1)
                    {
                        D = y; 
                        txtD.Text = D.ToString();
                        break;
                    }
                }

                //Achando o valor de E
                for (int j = 1; j < Z; j++)
                {
                    if (j * D % Z == 1)
                    {
                        E = j;
                        txtE.Text = E.ToString();
                        break;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textoCriptografado = "";
                textoDescriptografado = "";
                //byte[] bytesTextoOriginal;
                //byte[] bytesTextoCriptografado;
                //byte[] bytesTextoDescriptografado;

                if (E == 0 || D == 0 || N == 0)
                {
                    throw new Exception("Para criptografar, gere as chaves.");
                }
                if (string.IsNullOrEmpty(txtOriginal.Text))
                {
                    throw new Exception("Para criptografar, informe um texto.");
                }

                textoOriginal = txtOriginal.Text;

                long resultado = 1;
                for(int i = 0; i < D; i++)
                {
                    resultado = resultado * Convert.ToInt64(textoOriginal);
                }

                textoCriptografado = textoCriptografado + (resultado % N);

                txtCriptografado.Text = textoCriptografado;

                resultado = 1;
                for (int i = 0; i < E; i++)
                {
                    resultado = resultado * Convert.ToInt64(textoCriptografado);
                }

                textoDescriptografado = textoDescriptografado + (resultado % N);

                txtDescriptografado.Text = textoDescriptografado;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
