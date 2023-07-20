// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    
    //Função Soma
    static string Soma(double n1, double n2)
    {
        return string.Format("{0} + {1} = {2}", n1, n2, n1 + n2);
    }
    //Função Subtração
    static string Subtracao(double n1, double n2)
    {
        return string.Format("{0} - {1} = {2}", n1, n2, n1 - n2);
    }
    //Função Multiplicação
    static string Multiplicacao(double n1, double n2)
    {
        return string.Format("{0} x {1} = {2}", n1, n2, n1 * n2);
    }
    //Função Divisão
    static string Divisao(double n1, double n2)
    {
        if (n2 == 0)
        {
            return string.Format("{0} / {1} = 0", n1, n2);
        }
        return string.Format("{0} / {1} = {2}", n1, n2, n1 / n2);
    }
    public static void Main(string[] args)
    {
        string operacoes;
        int operacoesInt;
        string stringN1, stringN2;
        double n1, n2;

        Console.WriteLine("[1] Soma");
        Console.WriteLine("[2] Subtração");
        Console.WriteLine("[3] Multiplicação");
        Console.WriteLine("[4] Divisão");
        Console.Write("Digite a operação que deseja: ");

        while (true)
        {
            operacoes = Console.ReadLine();
            if (int.TryParse(operacoes, out _))
            { //Verificar se "operacoes" é um numero
                operacoesInt = Convert.ToInt32(operacoes);//Convert.ToInt32
                if (operacoesInt >= 1 && operacoesInt <= 4)
                {


                    while (true)
                    {
                        Console.Write("\tDigite um número: ");
                        stringN1 = Console.ReadLine();
                        if (double.TryParse(stringN1, out _))
                            break;
                    }
                    n1 = Convert.ToDouble(stringN1);

                    while (true)
                    {
                        Console.Write("\tDigite outro número: ");
                        stringN2 = Console.ReadLine();
                        if (double.TryParse(stringN2, out _))
                            break;
                    }
                    n2 = Convert.ToDouble(stringN2);

                    if (operacoesInt == 1)
                    {
                        Console.WriteLine(Soma(n1, n2));
                    }
                    else if (operacoesInt == 2)
                    {
                        Console.WriteLine(Subtracao(n1, n2));
                    }
                    else if (operacoesInt == 3)
                    {
                        Console.WriteLine(Multiplicacao(n1, n2));
                    }
                    else if (operacoesInt == 4)
                    {
                        Console.WriteLine(Divisao(n1, n2));
                    }
                    else
                    {
                        Console.WriteLine("Digite uma operação válida");
                    }
                    Console.Beep();
                    Console.ReadKey();

                }
            }
        }



    }
}
