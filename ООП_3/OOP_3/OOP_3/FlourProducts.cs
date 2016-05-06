using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class FlourProducts:food
    {
        #region Flour Propeties
        public string TypeOfFlourproducts { get; set; }

        public string ContainsSugar { get; set; }

        public string GradeFlour { get; set; }


        #endregion

        public override string PropertiesToString()
        {
            return (ParentPropetiesToString() +TypeOfFlourproducts + '_' + ContainsSugar + '_' + GradeFlour + ';');
        }
    }
}
