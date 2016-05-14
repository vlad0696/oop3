using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Serializable]
    public class MilkFood :AnimalProducts
    {
        public override string ClassName() { return "Молочная продукция"; }

      
        #region Milck properties
        public string TypeOfMilckProduct { get; set; }

        public string Fatness { get; set; }
            
        public bool LactoseContent { get; set; }
        #endregion
        public override void SetProperties(string[] prop)
        {
            TypeOfMilckProduct = prop[7];
            Fatness = prop[9];
            LactoseContent = IsItBool(prop[8]);

        }

    }

    public class MilckFactory : FoodFactory
    {
        public food GetFood()
        {
            return new MilkFood();
        }
    }
}
