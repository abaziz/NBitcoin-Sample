using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin_Sample.Chapters;

namespace NBitcoin_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter1 chapter = new Chapter1();
            chapter.Lesson1();
            Console.WriteLine("\n\n\nPress enter to continue.");
            Console.ReadLine(); 
        }
    }
}
