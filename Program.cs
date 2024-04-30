using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Vendedores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vendedores = new string[5];
            double[] vendas = new double[5];
            double[] comissao = new double[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite o nome dos vendedores: ");
                vendedores[i] = Console.ReadLine();

                Console.WriteLine("Digite as vendas do vendedor: ");
                vendas[i] = double.Parse(Console.ReadLine());

                if (vendas[i] <= 20000)
                {
                    comissao[i] = vendas[i] * 0.05;


                }
                else if (vendas[i] <= 40000)
                {
                    comissao[i] = vendas[i] * 0.07;


                }
                else
                {
                    comissao[i] = vendas[i] * 0.05;
                }
                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine("Vendedor: " + vendedores[j] +
                        "Valor da venda: " + vendas[j].ToString("C") +
                        "Valor da comissão: " + comissao[j].ToString("C"));
                    
                }
            }
            Console.ReadKey();
        }

            

         
    }
}
