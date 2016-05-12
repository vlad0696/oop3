﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_3
{
    [Serializable]
    public abstract class food
    {

        #region Properties parent class
        public abstract string ClassName();
        public string TypeOfProduct { get; set; }

        public string Name { get; set; }

        public string Calorific { get; set; }

        public string ShelfLife { get; set; }

        public string ManufactureDate { get; set; }

        #endregion

        #region Method parent class
        public string ParentPropetiesToString()
        {
            return (TypeOfProduct+'_'+ Name+'_'+Calorific+'_'+ShelfLife+'_'+ManufactureDate+'_');
        }
        protected void SetProperties(string[] prop)
        {
            Name = prop[0];
            Calorific = prop[1];
            ShelfLife = prop[2];
            ManufactureDate = prop[3];
        }

        public abstract string PropertiesToString();
        #endregion

    }

    interface FoodFactory
    {
        food GetFood();
    }
}
