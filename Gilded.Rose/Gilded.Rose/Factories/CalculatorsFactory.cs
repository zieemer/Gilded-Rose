using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Gilded.Rose.Conracts;

namespace Gilded.Rose.Factories
{
    public class CalculatorsFactory
    {
        private Dictionary<string, Type> calculators;

        public CalculatorsFactory()
        {
            GetCalculators();
        }


        public ICalculator GetInstance(string name)
        {
            string typeName = name.Replace(" ","").ToLower() + "calculator";
            Type t = GetTypeToCreate(typeName);

            if (t == null)
            {
                return null;
            }
            else
            {
                return Activator.CreateInstance(t) as ICalculator;
            }

        }

        private Type GetTypeToCreate(string name)
        {
            if (calculators.ContainsKey(name))
            {
                return calculators[name];
            }

            return null;
        }

        private void GetCalculators()
        {

            calculators= new Dictionary<string, Type>();

            Type[] typesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInAssembly)
            {
                if(type.GetInterface(typeof(ICalculator).ToString())!= null)
                {
                    calculators.Add(type.Name.ToLower(), type);
                }
                
            }
        }
    }
}
