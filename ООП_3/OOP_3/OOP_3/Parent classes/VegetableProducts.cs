using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public abstract class VegetableProducts:food
    {
        #region Animal properties
        public bool WithGMO { get; set; }

        public string Vitamins { get; set; }
        
        #endregion

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() + Vitamins + +'_' + WithGMO + '_');
        }
    }
}
