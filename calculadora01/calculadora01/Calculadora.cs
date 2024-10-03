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
        int escolha;
        while (true)
        {
            try
            {
                Console.WriteLine("Selecione a operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha >= 1 && escolha <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Erro: Selecione uma operação válida entre 1 e 4.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite um número válido.");
            }
        }
        return escolha;
    }
    //----------------------------------------------------------------

    public static void Main()
    {
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

            double numero1 = 0, numero2 = 0;

            // Validação para o primeiro número
            while (true)
            {
                try
                {
                    Console.Write("Digite o primeiro número: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Por favor, insira um número válido.");
                }
            }

            // Validação para o segundo número
            while (true)
            {
                try
                {
                    Console.Write("Digite o segundo número: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Por favor, insira um número válido.");
                }
            }

            Console.WriteLine();
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
