using QW.ExternalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
           HttpClientMatch.downloadJSONData();
            Console.ReadKey();

            HttpClientMatch.getAllMatches();
            Console.ReadKey();
        }
    }
}
