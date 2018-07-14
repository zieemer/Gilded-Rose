using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services
{
    public class UnvalidStockReport : IReport
    {
        public void Print(string name, int sellin, int quality)
        {
            Console.WriteLine($"No such a Item");
        }
    }
}
