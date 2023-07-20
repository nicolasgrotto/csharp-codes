internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool jogarDeNovo = true;
        int num;
        int min = 1;
        int max = 100;
        int escolha;
        int tentativas;
        string resposta = "";
        
        while(jogarDeNovo)
        {
            escolha = 0;
            tentativas = 0;
            num = random.Next(min, max + 1);
            while(escolha != num)
            {

                try{ 
                    Console.WriteLine("Tente adivinhar o número certo entre 1 e 100: ");
                    escolha = Convert.ToInt32(Console.ReadLine());
                   }
                catch(Exception){ Console.WriteLine("Digite um número inteiro!"); }

                if(escolha != 0) { 

                    Console.WriteLine("Seu número escolhido é: " + escolha + "\n");

                    if(escolha > num)
                    {
                        Console.WriteLine("O número certo é menor que esse. ");
                    }
                    else if(escolha < num)
                    {
                        Console.WriteLine("O número certo é maior que esse.\n ");
                    }
                    tentativas++;
                }

            }
            Console.WriteLine("Parabéns! você acertou! O número certo era: " + num);

            if(tentativas <= 3)
            {
                Console.WriteLine("Você só usou " + tentativas + "! Parabéns, você foi muito bem!");
            }
            else if(tentativas >= 10)
            {
                Console.WriteLine("Você usou mais de " + tentativas + " tentativas! Muito ruim.");
            }
            else
            {
                Console.WriteLine("Você levou " + tentativas + " tentativas para passar, até que você foi bem.");
            }

            while(resposta != "S" &&  resposta != "N") {
                Console.WriteLine("\nVocê quer jogar de novo(S/N)? ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
            }

            if(resposta == "S")
            {
                jogarDeNovo = true;
            }
            else
            {
                jogarDeNovo = false;
            }

        }

        Console.WriteLine("Certo...Muito obrigado por jogar meu jogo de adivinhação!");

        Console.Beep();

        Console.ReadKey();

    }
}