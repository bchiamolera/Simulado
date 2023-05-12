using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladoQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "devs two blu";
            int contador = 0;
            char[] letrasEscondidas = palavra.ToCharArray();
            char[] resposta = palavra.ToCharArray();
            for (int i = 0; i < letrasEscondidas.Length; i++)
            {
                if (resposta[i] == ' ') letrasEscondidas[i] = ' ';
                else
                {
                    letrasEscondidas[i] = '_';
                    contador++;
                }
            }
            int acertos = 0;
            char chute;

            do
            {
                for (int i = 0; i < letrasEscondidas.Length; i++)
                {
                    Console.Write(letrasEscondidas[i]);
                }
                Console.WriteLine();
                chute = char.Parse(Console.ReadLine().Trim().ToLower());
                for (int i = 0;i < resposta.Length; i++)
                {
                    if (chute == letrasEscondidas[i])
                    {
                        Console.WriteLine("Letra já descoberta. (Espaço para continuar)");
                        Console.ReadKey();
                        break;
                    }
                    else if (chute == resposta[i])
                    {
                        letrasEscondidas[i] = chute;
                        acertos++;
                    }
                }
                Console.Clear();
            } while (acertos < contador);
            Console.WriteLine("Palavra: " + palavra);
            Console.WriteLine("\nParabéns!");
            Console.ReadKey();
        }
    }
}
