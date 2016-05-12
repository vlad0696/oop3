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
        public override string ClassName() { return "Напитки"; }
        public string TypeOfDrink { get; set; }

        public bool Aerated { get; set; }

        public bool ReadyToEat { get; set; }
        
        public bool Alcohol { get; set; }

        #endregion 

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() + TypeOfDrink + '_' + Aerated + '_' + ReadyToEat +'_');
        }


    }
    public class BeveragesFactory : FoodFactory
    {
        public food GetFood()
        {
            return new Beverages();
        }
    }
}
