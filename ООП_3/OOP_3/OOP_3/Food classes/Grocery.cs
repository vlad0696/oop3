using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Grocery:VegetableProducts
    {
        #region Grocery property
        public string TypeEat { get; set; }

        public string CerealVariety { get; set; }
        #endregion

        public string AddPropertiesToString()
        {
            return (PropertiesToString() + '_' + TypeEat + '_'+CerealVariety+'_');
        }
    }
    public class GroceryFactory : FoodFactory
    {
        public food GetFood()
        {
            return new Grocery();
        }
    }
}
