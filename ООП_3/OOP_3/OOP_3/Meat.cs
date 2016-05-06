using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Meat:food
    {
        #region Meat properties
        public string TypeOfMeatProduct { get; set; }
        
        public string Animal { get; set; }
            
        public bool FreshOrFreez { get; set; }

        public bool ReadyToEat { get; set; }
        #endregion

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() +TypeOfMeatProduct+'_' + FreshOrFreez + '_' + ReadyToEat + + '_' + Animal + ';');
        }
    }
}
