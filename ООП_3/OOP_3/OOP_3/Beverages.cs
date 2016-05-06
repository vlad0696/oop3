using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Beverages:food
    {
        #region Drinks properties

        public string TypeOfDrink { get; set; }

        public bool Aerated { get; set; }




        #endregion 

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() + TypeOfMeatProduct + '_' + FreshOrFreez + '_' + ReadyToEat + +'_' + Animal + ';');
        }
    }
}
