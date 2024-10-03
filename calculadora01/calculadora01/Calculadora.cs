using System;

public class Calculadora
{
    //-------------------------Métodos--------------------------------
    public double Soma(double a, double b)
    {
        return a + b;
    }
    public double Subtracao(double a, double b)
    {
        return a - b;
    }
    public double Multiplicacao(double a, double b)
    {
        return a * b;
    }
    public double Divisao(double a, double b)
    {
        return a / b;
    }

    // Método para exibir o menu de operações e retornar a escolha
    public int MostrarMenu()
    {
        Console.WriteLine("Selecione a operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int escolha = Convert.ToInt32(Console.ReadLine());
        return escolha;
    }
    //----------------------------------------------------------------

    public static void Main()
    {
        // Instancia a classe Calculadora
        Calculadora calc = new Calculadora();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine();
            Console.WriteLine("Inicializando...");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Chamando metodo do Menu
            int escolha = calc.MostrarMenu();

            double resultado = 0;

            switch (escolha)
            {
                case 1: // Adição
                    resultado = calc.Soma(numero1, numero2);
                    Console.WriteLine($"Resultado da adição: {resultado}");
                    break;
                case 2: // Subtração
                    resultado = calc.Subtracao(numero1, numero2);
                    Console.WriteLine($"Resultado da subtração: {resultado}");
                    break;
                case 3: // Multiplicação
                    resultado = calc.Multiplicacao(numero1, numero2);
                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
                    break;
                case 4: // Divisão
                    if (numero2 != 0)
                    {
                        resultado = calc.Divisao(numero1, numero2);
                        Console.WriteLine($"Resultado da divisão: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("Deseja realizar outra operação? S/N");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "N")
            {
                continuar = false;
                Console.WriteLine();
                Console.WriteLine("Encerrando o programa...");
            }
        }
    }
}
