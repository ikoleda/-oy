using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace трпо
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader re = new StreamReader("text.txt"))
            {

                string g = re.ReadToEnd();
                Console.WriteLine(g);
                Match oy = Regex.Match(g, @"\d{2}[.]\d{2}[.]\d{4}");
                Console.WriteLine("/////////////");
                if (oy.Success)
                {
                    Console.WriteLine(oy.Captures[0].Value);
                    using (StreamWriter wr = new StreamWriter("text1.txt"))
                    {
                        wr.WriteLine(oy.Captures[0].Value);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}

