using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Serializable]
    public abstract class VegetableProducts:food
    {
        #region Animal properties
        public bool WithGMO { get; set; }

        public string Vitamins { get; set; }

        #endregion

        public override void  SetIntemediate(string[] prop)
        {
            WithGMO = IsItBool(prop[6]);
            Vitamins = prop[5];
        }
    }
}
