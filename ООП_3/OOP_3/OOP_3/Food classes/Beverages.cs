using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Serializable]
    public class Beverages:food
    {
        #region Drinks properties
        public override string ClassName() { return "Напитки"; }

  

        public string TypeOfDrink { get; set; }

        public bool ReadyToEat { get; set; }

        public bool Aerated { get; set; }
   
        public bool Alcohol { get; set; }

        #endregion
        public override void SetProperties(string[] prop)
        {

        }
        public override void SetIntemediate(string[] prop)
        {
            TypeOfDrink = prop[5];
            ReadyToEat = IsItBool(prop[6]);
            Aerated = IsItBool(prop[7]);
            Alcohol = IsItBool(prop[8]);
        
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
