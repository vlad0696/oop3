using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class MilkFood :AnimalProducts
    {
        public override string ClassName() { return "Молочная продукция"; }
        #region Milck properties
        public string TypeOfMilckProduct { get; set; }

        public string Fatness { get; set; }
            
        public bool LactoseContent { get; set; }
        #endregion

        public string AddPropertiesToString()
        {
            return (PropertiesToString()+'_'+TypeOfMilckProduct+'_'+Fatness+'_'+LactoseContent+'_');
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
