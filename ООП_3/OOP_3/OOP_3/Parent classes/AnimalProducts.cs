using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Serializable]
    public abstract class AnimalProducts : food
    {
        #region Animal properties
        public bool ReadyToEat { get; set; }

        public string Animal { get; set; }

        public override void SetIntemediate(string[] prop)
        {
            ReadyToEat = IsItBool(prop[5]);
            Animal=prop[6];
        }
        #endregion

    }
}
