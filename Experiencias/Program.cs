using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiencias {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, quantidade, total, coelhos, ratos, sapos;
            char tipo;
            double percentualCoelhos, percentualRatos, percentualSapos;

            Console.Write("Quantos casos de teste serao digitados? ");
            n = int.Parse(Console.ReadLine());

            total = 0;
            coelhos = 0;
            ratos = 0;
            sapos = 0;

            for (i = 0; i < n; i++) {
                Console.Write("Quantidade de cobaias: ");
                quantidade = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                tipo = char.Parse(Console.ReadLine());
                total = total + quantidade;

                if (tipo == 'c') {
                    coelhos = coelhos + quantidade;
                }
                else if (tipo == 'r') {
                    ratos = ratos + quantidade;
                }
                else if (tipo == 's') {
                    sapos = sapos + quantidade;
                }
            }

            percentualCoelhos = (double)coelhos * 100 / total;
            percentualRatos = (double)ratos * 100 / total;
            percentualSapos = (double)sapos * 100 / total;

            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL: ");
            Console.WriteLine("Total: " + total + " cobaias.");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);

            Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2", CI));
            Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2", CI));
            Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2", CI));
        }
    }
}







