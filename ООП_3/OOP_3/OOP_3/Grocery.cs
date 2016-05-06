using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Grocery:food
    {

        public string TypeEat { get; set; }

        public string CerealVariety { get; set; }

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() + '_' + TypeEat + '_'+CerealVariety + ';');
        }
    }
}
