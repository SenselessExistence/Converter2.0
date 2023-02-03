using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter2._0
{
    public class Operation
    {
        public Operation()
        {

        }
        Dictionary<string, double> Money = new Dictionary<string, double>()
        {
            {"USD", 1 },
            {"EUR", 1.08 },
            {"UAH", 0.025 }

        };

        public string? Convertation(double input, string typeOfMoney, string typeOfMoney2)
        {
             return Convert.ToString(Math.Round(input * Money[typeOfMoney] / Money[typeOfMoney2], 2));
        }
    }
}
