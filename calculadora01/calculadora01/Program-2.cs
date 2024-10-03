//using System;

//class Program2
//{
//    static void Main()
//    {
//        bool continuar = true;

//        while (continuar)
//        {
        
//            Console.WriteLine();
//            Console.WriteLine("Inicializando...");
//            for (int i = 0; i < 3; i++) 
//            {
//                Console.Write(".");
//                Thread.Sleep(500); 
//            }
//            Console.WriteLine(); 

//            Console.Write("Digite o primeiro número: ");
//            double numero1 = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Digite o segundo número: ");
//            double numero2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine();

         
//            Console.WriteLine("Selecione a operação:");
//            Console.WriteLine("1 - Adição");
//            Console.WriteLine("2 - Subtração");
//            Console.WriteLine("3 - Multiplicação");
//            Console.WriteLine("4 - Divisão");

//            int escolha = Convert.ToInt32(Console.ReadLine());

//            double resultado = 0;
      
//            switch (escolha)
//            {
//                case 1: // Adição
//                    resultado = numero1 + numero2;
//                    Console.WriteLine($"Resultado da adição: {resultado}");
//                    Console.WriteLine();
//                    break;
//                case 2: // Subtração
//                    resultado = numero1 - numero2;
//                    Console.WriteLine($"Resultado da subtração: {resultado}");
//                    Console.WriteLine();
//                    break;
//                case 3: // Multiplicação
//                    resultado = numero1 * numero2;
//                    Console.WriteLine($"Resultado da multiplicação: {resultado}");
//                    Console.WriteLine();
//                    break;
//                case 4: // Divisão
//                    if (numero2 != 0) 
//                    {
//                        resultado = numero1 / numero2;
//                        Console.WriteLine($"Resultado da divisão: {resultado}");
//                        Console.WriteLine();
//                    }
//                    else
//                    {
//                        Console.WriteLine("Erro: Divisão por zero não é permitida!");
//                        Console.WriteLine();
//                    }
//                    break;
//                default: 
//                    Console.WriteLine("Opção inválida! Selecione uma operação válida.");
//                    Console.WriteLine();
//                    break;
//            }

//            Console.WriteLine("Deseja realizar outra operação? S/N");
//            string resposta = Console.ReadLine().ToUpper();


//            if (resposta == "N")
//            {
//                continuar = false;
//                Console.WriteLine();
//                Console.WriteLine("Encerrando o programa...");
//            }
//        }
//    }
//}
