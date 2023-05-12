using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladoQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa em C# que recebe uma string e verifica se ela é um palíndromo,
            // ou seja, se pode ser lida da mesma forma tanto da esquerda para a direita quanto
            // da direita para a esquerda. Desconsidere espaços em branco e letras maiúsculas ou minúsculas.
            // Se a string for um palíndromo, exiba a mensagem "A string X é um palíndromo"; caso contrário,
            // exiba a mensagem "A string X não é um palíndromo", em que X é a string recebida como entrada.
            while (true)
            {
                Console.WriteLine("Informe uma palavra");
                string entrada = Console.ReadLine();
                string tempEntrada = entrada.Replace(" ", "").ToLower().Trim();
                List<char> palavra = new List<char>();
                foreach (char letra in tempEntrada)
                {
                    palavra.Add(letra);
                }

                List<char> inverso = new List<char>();
                for (int i = 0; i < palavra.Count(); i++)
                {
                    inverso.Add(palavra[(palavra.Count() - 1 - i)]);
                }

                string entradaContrario = "";
                foreach (char letra in inverso)
                {
                    entradaContrario += letra;
                }

                if (tempEntrada == entradaContrario) Console.WriteLine($"\nA string '{entrada}' é palíndromo");
                else Console.WriteLine($"\nA string '{entrada}' não é palíndromo");

                string op = "0";
                do
                {
                    Console.WriteLine("\nDeseja verificar mais uma palavra? \n1. Sim      2. Não");
                    op = Console.ReadLine();
                    if (op == "2") break;
                } while (op != "1");
                if (op == "2") break;
                Console.Clear();
            }
        }
    }
}
