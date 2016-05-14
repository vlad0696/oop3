using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Serializable]
    public class Meat:AnimalProducts
    {
        #region Meat properties
        public override string ClassName() { return "Мясные изделия"; }
        public string TypeOfMeatProduct { get; set; }
            
        public bool FreshOrFreez { get; set; }

        public override void SetProperties(string[] prop)
        {
            TypeOfMeatProduct = prop[7];
            FreshOrFreez=IsItBool( prop[8]);

        }
        #endregion


    }
    public class MeatFactory : FoodFactory
    {
        public food GetFood()
        {
            return new Meat();
        }
    }
}
