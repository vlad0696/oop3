using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Conserve:food
    {
        public override string ClassName()
        {
            return "Консервы";
        }
        public Meat MeatConserve = new Meat();
        public Grocery GroceryConserve = new Grocery();

        public override string PropertiesToString()
        {
            return (MeatConserve.PropertiesToString() + '&' + GroceryConserve.PropertiesToString());
        }
                
    }
    public class ConserveFacotry : FoodFactory
    {
        public food GetFood()
        {
            return new Conserve();
        }
    }
}
