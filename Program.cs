using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das operações:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicaçao");
            Console.WriteLine("--------------------------");
            float operador = float.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;

            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("1 - Soma");
            Console.WriteLine("Digite o primeiro valor:");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor + segundoValor;



            Console.WriteLine($"A soma dos dois valores é : {resultado}");
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("Digite o primeiro valor:");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor - segundoValor;



            Console.WriteLine($"A soma dos dois valores é : {resultado}");
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("Digite o primeiro valor:");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor / segundoValor;



            Console.WriteLine($"A soma dos dois valores é : {resultado}");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("4 - Multiplicaçao");
            Console.WriteLine("Digite o primeiro valor:");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor * segundoValor;



            Console.WriteLine($"A soma dos dois valores é : {resultado}");
        }
    }

}