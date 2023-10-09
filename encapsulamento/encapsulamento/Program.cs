using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Fabio Henrique de Souza Venancio Pinheiro 3JDM
namespace encapsulamento
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Jogador jogador1 = new Jogador("Jogador1");
            Console.Write("Infome o nome do player 1: ");
            jogador1.Nome = Console.ReadLine();

            Jogador jogador2 = new Jogador("Jogador2");
            Console.Write("Infome o nome do player 2: ");
            jogador2.Nome = Console.ReadLine();

            jogador1.AumentarPontuacao(10);
            jogador2.AumentarPontuacao(5);

            jogador1.AumentarPontuacao(-5);

            jogador1.Apresentar();
            jogador2.Apresentar();
;
            Console.ReadKey();
        }
    }
    class Jogador
    {
        private string nome;
        private int pontuacao;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Pontuacao
        {
            get { return pontuacao; }
            private set { pontuacao = value; }
        }

        public Jogador(string nome)
        {
            this.nome = nome;
            pontuacao = 0;
        }


        public void AumentarPontuacao(int valor)
        {
            if (valor > 0)
            {
                pontuacao += valor;
            }
            else
            {
                Console.WriteLine("O valor deve ser positivo.");
            }
        }

        public void Apresentar()
        {
            Console.WriteLine("Nome do Personagem: " + this.nome);
            Console.WriteLine("Pontuação do Personagem: " + this.pontuacao);
        }
    }
}

