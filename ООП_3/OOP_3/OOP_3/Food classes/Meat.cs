using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Meat:AnimalProducts
    {
        #region Meat properties
        public string TypeOfMeatProduct { get; set; }
            
        public bool FreshOrFreez { get; set; }

        #endregion

        public string AddPropertiesToString()
        {
            return (PropertiesToString() +TypeOfMeatProduct+'_' + FreshOrFreez + '_');
        }
    }
    public class MeatFactory : FoodFactory
    {
        public food GetFood()
        {
            return new Meat();
        }
    }
}
