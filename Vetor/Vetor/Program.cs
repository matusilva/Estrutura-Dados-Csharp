using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor vetor = new Vetor();

            vetor.insertAtRank(0, "A");
            Console.WriteLine(vetor.toString());

            vetor.insertAtRank(1, "B");
            Console.WriteLine(vetor.toString());

            vetor.insertAtRank(0, "A2");
            Console.WriteLine(vetor.toString());

            //vetor.replaceAtRank(0, "A2");
            //Console.WriteLine(vetor.toString());

            vetor.removeAtRank(1);
            Console.WriteLine(vetor.toString());

            //vetor.insertAtRank(1, "A");
            //Console.WriteLine(vetor.toString());

            //Console.WriteLine(vetor.elemAtRank(1));

            Console.WriteLine("\nImprimindo todo o Vetor");
            Console.WriteLine(vetor.imprimir());

            Console.ReadKey();
        }
    }
}
