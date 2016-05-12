using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class FlourProducts:VegetableProducts
    {
        #region Flour Propeties
        public override string ClassName() { return "Мучные продукты "; }
        public string TypeOfFlourproducts { get; set; }

        public bool ContainsSugar { get; set; }

        public string GradeFlour { get; set; }


        #endregion

        public string AddPropertiesToString()
        {
            return (PropertiesToString() +TypeOfFlourproducts + '_' + ContainsSugar + '_' + GradeFlour+'_');
        }
    }
    public class FlourFactory : FoodFactory
    {
        public food GetFood()
        {
            return new FlourProducts();
        }
    }
}
