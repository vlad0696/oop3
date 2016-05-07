using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public abstract class AnimalProducts : food
    {
        #region Animal properties
        public bool ReadyToEat { get; set; }

        public string Animal { get; set; }

        #endregion

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() + ReadyToEat + +'_' + Animal + '_');
        }
    }
}
