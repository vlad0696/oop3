using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnimalProducts.Visible = false;
            panelMeat.Visible = false;
            panelMilck.Visible = false;
            panelDrinks.Visible = false;
            panelVegetableProducts.Visible = false;
            panelFlour.Visible = false;
            panelCereal.Visible = false;

            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMain_Click(object sender, EventArgs e)
        {
            switch (comboBoxMain.SelectedItem.ToString()) {
                case "Молочная продукция":
                    {
                        panelDrinks.Visible = false;
                        panelVegetableProducts.Visible = false;
                        AnimalProducts.Visible = true;
                        panelMilck.Visible = true;
                        panelMeat.Visible = false;
                        break;
                    }
                case "Мясные изделия":
                    {

                        panelDrinks.Visible = false;
                        panelVegetableProducts.Visible = false;
                        AnimalProducts.Visible = true;
                        panelMilck.Visible = false;
                        panelMeat.Visible = true;
                        break;
                    }
                case "Бакалея":
                    {
                        panelDrinks.Visible = false;
                        panelVegetableProducts.Visible = true;
                        panelCereal.Visible = true;
                        panelFlour.Visible = false;
                        AnimalProducts.Visible = false;
                        break;
                    }
                case "Мучные продукты ":
                    {
                        panelDrinks.Visible = false;
                        panelVegetableProducts.Visible = true;
                        panelCereal.Visible = false;
                        panelFlour.Visible = true;
                        AnimalProducts.Visible = false;
                        
                        break;
                    }
                case "Напитки":
                    {
                        panelDrinks.Visible = true;
                        AnimalProducts.Visible = false;
                        panelVegetableProducts.Visible = false;
                        break;
                    }


            }

        }
    }
}
