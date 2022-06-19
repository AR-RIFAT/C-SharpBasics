using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTopics.Basics
{
    public class DelegatesPractice
    {
        public static void Main(string[] args)
        {
            AddProcessPrint(5, 8, Print2);
        }

        public delegate int TestDelegate(int msg);

        public static void AddProcessPrint(int a, int b, TestDelegate processor)
        {
            Console.WriteLine(processor(a + b));
        }

        public static int Print(int output)
        {
            return 1 * output;
        }

        public static int Print2(int output)
        {
            return 2 * output;
        }
    }
}
