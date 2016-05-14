using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_3
{
    [Serializable]
    [XmlInclude(typeof(Beverages)), XmlInclude(typeof(Conserve)), XmlInclude(typeof(FlourProducts)), XmlInclude(typeof(Grocery)), XmlInclude(typeof(Meat)), XmlInclude(typeof(MilkFood))]
    public abstract class food
    {
        protected bool IsItBool(string s)
        {
            if (s == "True")
            {
                return true;
            }
            return false;
        }
        #region Properties parent class
        public abstract string ClassName();

        public abstract void SetProperties(string[] prop);
        public string Name { get; set; }

        public string Calorific { get; set; }

        public string ShelfLife { get; set; }

        public string ManufactureDate { get; set; }
        
        public string StringProperty { get; set; }

        #endregion

        #region Method parent class
        public abstract void SetIntemediate(string[] prop);
       public void SetMainProperties(string[] prop)
        {
            Name = prop[1];
            Calorific = prop[2];
            ShelfLife = prop[3];
            ManufactureDate = prop[4];
        }

        #endregion

    }

   public interface FoodFactory
    {
        food GetFood();

    }
}
