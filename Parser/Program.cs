using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new LocaleResource());

            Console.WriteLine(engine.Parser(Format.Date, "en_US", "YYYY/dd/MM"));           
        }
    }
}
