using System.Threading;
class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool jogarDeNovo = true;
        string jogador;
        string computador;
        string resposta = "";

        Console.WriteLine("Bem vindo ao jogo de pedra, papel ou tesoura!\n");

        while (jogarDeNovo)
        {
            jogador = "";
            computador = "";

            while(jogador != "PEDRA" && jogador != "PAPEL" && jogador != "TESOURA")
            {
                Console.WriteLine("Escolha Pedra, Papel ou Tesoura: ");
                jogador = Console.ReadLine();
                jogador = jogador.ToUpper();

                switch(random.Next(1, 4))
                {
                    case 1:
                        computador = "Pedra";
                        break;
                    case 2:
                        computador = "Papel";
                        break;
                    case 3:
                        computador = "Tesoura";
                        break;

                }
            }
            computador = computador.ToUpper();

            Console.Write("\nJo ");
            Thread.Sleep(1000);
            Console.Write("Ken ");
            Thread.Sleep(1000);
            Console.WriteLine("Po!\n");
            Thread.Sleep(1000);

            Console.WriteLine("O jogador escolheu: " + jogador);
            Console.WriteLine("O computador escolheu: " + computador);

            switch (jogador)
            {
                case "PEDRA":
                    if(computador == "PEDRA")
                    {
                        Console.WriteLine("É um empate!");
                    }
                    else if(computador == "PAPEL") {
                        Console.WriteLine("Você perdeu!");
                    }
                    else
                    {
                        Console.WriteLine("Você Ganhou!");
                    }
                    break;
                case "PAPEL":
                    if (computador == "PAPEL")
                    {
                        Console.WriteLine("É um empate!");
                    }
                    else if(computador == "PEDRA")
                    {
                        Console.WriteLine("Você ganhou!");
                    }
                    else
                    {
                        Console.WriteLine("O computador ganhou!");
                    }
                    break;
                case "TESOURA":
                    if(computador == "TESOURA")
                    {
                        Console.WriteLine("É um empate!");
                    }
                    else if (computador == "PAPEL")
                    {
                        Console.WriteLine("Você ganhou!");
                    }
                    else
                    {
                        Console.WriteLine("O computador ganhou!");
                    }
                    break;
            }
            while(resposta != "S" && resposta  != "N") { 
                Console.WriteLine("Você quer jogar de novo?(S/N) ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
            }

            if (resposta == "S")
            {
                jogarDeNovo = true;
            }
            else
            {
                jogarDeNovo = false;
            }

        }
        Console.WriteLine("Obrigado por jogar!");
        Console.ReadKey();
    }
}