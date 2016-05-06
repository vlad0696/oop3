using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class MilkFood :food
    {
        #region Milck properties
        public string TypeOfMilckProduct { get; set; }

        public string Fatness { get; set; }
            
        public bool LactoseContent { get; set; }
        
        public string Animal { get; set; }
                  
        #endregion
        public override string PropertiesToString()
        {
            return (ParentPropetiesToString()+'_'+TypeOfMilckProduct+'_'+Fatness+'_'+LactoseContent+'_'+Animal+';');
        }
    }
}
