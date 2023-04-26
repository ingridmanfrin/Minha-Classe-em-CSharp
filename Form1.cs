using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Classe_em_CSharp
{
    public partial class Form1 : Form
    {
        int v; //variável declarada, sem ter atribuído nenhum valor

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //    //instanciar

            Pessoas pessoa1 = new Pessoas();

            pessoa1.nome = "Leo";
            pessoa1.idade = 23;
            pessoa1.altura = 2;
            pessoa1.nacionalidade = "PT";

            LabelNome.Text = pessoa1.nome = "Fábio ";
            LabelIdade.Text = pessoa1.idade.ToString();
            LabelAltura.Text = pessoa1.altura.ToString();

            //Pessoas pessoa2 = new Pessoas();

            //    LabelAltura.Text = pessoa2.nacionalidade = "BR";

            //    Pessoas p = new Pessoas();

            //    p.nome = "Pedro";
            //    p.idade = 23;
            //    p.falar();
            //    pular(); //não tive que instanciar pois o método está na mesma classe
            //}
            //public void pular()
            //{
            //    Pessoas p1 = new Pessoas();
            //    p1.idade = v + 20;
            //    p1.falar();
        }
    }
}


