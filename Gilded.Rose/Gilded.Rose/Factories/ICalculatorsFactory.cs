using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Conracts;
using SimpleInjector;

namespace Gilded.Rose.Factories
{
    public interface ICalculatorsFactory
    {
        ICalculator GetInstance(string name);
    }
    public class CalculatorsFactory : Dictionary<string, Func<ICalculator>>, ICalculatorsFactory

    {

        public ICalculator GetInstance(string name)
        {
            var safeName = name.Replace(" ", string.Empty).ToLower();

            if (this.ContainsKey(safeName))
            {
                return this[safeName]();
            }

            return null;

        }
    }
}
