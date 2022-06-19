using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTopics.Basics.Helpers;

namespace CSharpTopics.Basics
{
    public class EventPractice
    {
        public static void Main(string[] args)
        {
            PrimeGenerator primeGenerator = new PrimeGenerator();
            primeGenerator.PrimeGenerationComplete += PrimeGenerator_PrimeGenerationComplete;
            Thread t = new Thread(() => primeGenerator.Generate(500000));
            t.Start();
            Console.WriteLine("Ended");
        }

        private static void PrimeGenerator_PrimeGenerationComplete(List<int> primes)
        {
            //foreach (var prime in primes)
            //    Console.WriteLine(prime);
            Console.WriteLine("Done");
        }

    }

}
