using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Primos p = new Primos();

            Console.WriteLine("desejas tu até q numero?");
            p.limit = int.Parse(Console.ReadLine());

            p.initNumbers(p.limit);

            p.markAndDelete();

            p.numbersAsString();
        }
    }
}
