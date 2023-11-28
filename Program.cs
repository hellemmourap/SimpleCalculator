using System;

namespace calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num, num2, opcao, result = 0;
            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione uma operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            opcao = Convert.ToInt32(Console.ReadLine());
            
            switch(opcao)
            {
                case 1: 
                    result = num + num2;
                    break;
                case 2:
                    result = num - num2;
                    break;
                case 3:
                    result = num * num2;
                    break;
                case 4:
                    result = num / num2;
                    break;
                default:
                    Console.WriteLine("Option not found!!!");
                    break;
            }
            Console.WriteLine("Resultado = {0}", result);
        }
    }
}