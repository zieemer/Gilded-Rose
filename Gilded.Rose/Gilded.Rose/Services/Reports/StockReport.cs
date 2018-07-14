using System;
using Gilded.Rose.Conracts;

namespace Gilded.Rose.Services.Reports
{
    public class StockReport : IReport
    {
        public void Print(string name, int sellin, int quality)
        {
            Console.WriteLine($"Stock: {name} |s: {sellin} |q: {quality}");
        }
    }
}
