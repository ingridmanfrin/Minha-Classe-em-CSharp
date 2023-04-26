using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Classe_em_CSharp
{
    //Classe combo Propriedades mais Métodos
    public class Pessoas
    {
        //Propriedades da classe

        public string nome;
        public int idade;
        public int altura;
        public string nacionalidade;

        //Métodos da classe

        public void falar()
        {
            //MessageBox.Show("Olá! Eu sou a pessoa que você criou.");
            MessageBox.Show("Olá! Eu sou " + nome + " e tenho " + idade + " anos.");
        }
    }

}
