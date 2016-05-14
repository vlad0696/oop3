using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Serializable]
    public class Conserve:food
    {
        public override string ClassName()
        {
            return "Консервы";
        }
        
        public Meat MeatConserve = new Meat();
        public Grocery GroceryConserve = new Grocery();
        public override void SetProperties(string[] prop)
        {
            MeatConserve.SetIntemediate(prop);
            MeatConserve.SetProperties(prop);
            GroceryConserve.SetIntemediate(prop);
            GroceryConserve.SetProperties(prop);
        }

        public override void SetIntemediate(string[] prop)
        {
            throw new NotImplementedException();
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
