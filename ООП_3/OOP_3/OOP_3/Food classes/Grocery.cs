using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Grocery:VegetableProducts
    {

        public string TypeEat { get; set; }

        public string CerealVariety { get; set; }

        public string AddPropertiesToString()
        {
            return (PropertiesToString() + '_' + TypeEat + '_'+CerealVariety+'_');
        }
    }
}
