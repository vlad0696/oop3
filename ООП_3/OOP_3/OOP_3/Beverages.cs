using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Beverages:food
    {
        #region Drinks properties

        public string TypeOfDrink { get; set; }

        public bool Aerated { get; set; }

        public bool ReadyToEat { get; set; }

        public string Alcohol { get; set; }

        #endregion 

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() + TypeOfDrink + '_' + Aerated + '_' + ReadyToEat + +'_' + Alcohol + ';');
        }
    }
}
