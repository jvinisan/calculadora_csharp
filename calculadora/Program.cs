using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - adição");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - multiplicação");
            Console.WriteLine("4 - divisão");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int primeiro_numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int segundo_numero = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(primeiro_numero, segundo_numero);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(primeiro_numero, segundo_numero);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(primeiro_numero, segundo_numero);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(primeiro_numero, segundo_numero);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ERRO! Opção inválida, digite outro número");
                        break;
                    }
            }

            Console.WriteLine("O resultado da operação com os número {0} e {1} é: {2}", primeiro_numero, segundo_numero, resultado);
            Console.ReadLine();

        }

        public static int Adicao(int primeiro_numero, int segundo_numero)
        {
            int resultado = primeiro_numero + segundo_numero;
            return resultado;
        }

        public static int Subtracao(int primeiro_numero, int segundo_numero)
        {
            int resultado = primeiro_numero - segundo_numero;
            return resultado;
        }

        public static int Multiplicacao(int primeiro_numero, int segundo_numero)
        {
            int resultado = primeiro_numero * segundo_numero;
            return resultado;
        }

        public static int Divisao(int primeiro_numero, int segundo_numero)
        {
            int resultado = primeiro_numero / segundo_numero;
            return resultado;
        }

    }
}
