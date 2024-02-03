using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "We are from WADA-58 batch";
            var output = data.Split(' ');
            for(int i = 0; i < output.Count(); i++)
            {
                Console.WriteLine($"{i+1}.{output[i]}");
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);

            }
            string s = "https://atcomputer.net.bd/";
            var outpu1t = s.Split('/');
            for (int i = 0; i < outpu1t.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.{outpu1t[i]}");
            }
             
            Console.ReadKey();
        }
    }
}
