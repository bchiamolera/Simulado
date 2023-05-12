using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladoQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            int num = 1;
            string op = "";
            do {
                Console.Clear();
                do
                {
                    Console.WriteLine("Informe número inteiros (Digite 0 para encerrar):");
                    num = int.Parse(Console.ReadLine());
                    if (num != 0) numList.Add(num);
                    Console.Clear();
                } while (num != 0);

                int tempNum = 0;

                for (int i = 0; i < numList.Count(); i++) {
                    for (int j = i + 1; j < numList.Count(); j++)
                    {
                        if (numList[i] > numList[j])
                        {
                            tempNum = numList[i];
                            numList[i] = numList[j];
                            numList[j] = tempNum;
                        }
                    }
                }
                Console.WriteLine("Lista de número em ordem crescente: ");
                foreach (int numero in numList)
                {
                    Console.Write(numero + " ");
                }
                Console.WriteLine();
                while (op != "1")
                {
                    Console.WriteLine("Deseja informar uma nova lista? \n1. Sim       2. Não");
                    op = Console.ReadLine();
                    if (op == "2") break;
                    Console.Clear();
                }
            } while (op != "2");
        }
    }
}
