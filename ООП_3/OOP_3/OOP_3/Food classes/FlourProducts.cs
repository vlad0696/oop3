using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Serializable]
    public  class FlourProducts:VegetableProducts
     {
        #region Flour Propeties
        public override string ClassName() { return "Мучные продукты "; }

        public string TypeOfFlourproducts { get; set; }

        public bool ContainsSugar { get; set; }

        public string GradeFlour { get; set; }


        public override void SetProperties(string[] prop)
        {
            TypeOfFlourproducts = prop[7];
            GradeFlour = prop[8];
            ContainsSugar  = IsItBool(prop[8]);

        }
        #endregion


    }
    public class FlourFactory : FoodFactory
    {
        public food GetFood()
        {
            return new FlourProducts();
        }
    }
}
