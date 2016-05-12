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
        private Dictionary<string, FoodFactory> ListFoodFactory = new Dictionary<string, FoodFactory>();
        public List<food> ListFood = new List<food>();
        public List<TextBox> ListTextBox = new List<TextBox>();
        public List<ComboBox> ListComboBox = new List<ComboBox>();
        
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
            ListTextBox.Add(textBoxProductName);//0
            ListTextBox.Add(textBoxCal);//1
            ListTextBox.Add(textBoxShelfLife);//2
            ListTextBox.Add(textBoxDataManufacture);//3
            ListTextBox.Add(textBoxAnimal);//4
            ListTextBox.Add(textBoxVitamins);//5
            ListTextBox.Add(textBoxTypeCereal);//6
            ListTextBox.Add(textBoxSortCereal);//7
            ListTextBox.Add(textBoxTypeFlour);//8
            ListTextBox.Add(textBoxSortFlour);//9
            ListTextBox.Add(textBoxMeatType);//10
            ListTextBox.Add(textBoxTypeMilck);//11
            ListTextBox.Add(textBoxFatness);//12
            ListTextBox.Add(textBoxTypeDrink);//13
            ListComboBox.Add(comboBoxGMO);//0 
            ListComboBox.Add(comboBoxSugar);//1
            ListComboBox.Add(comboBoxReadyToEat);//2
            ListComboBox.Add(comboBoxFreez);//3
            ListComboBox.Add(comboBoxLactose);//4
            ListComboBox.Add(comboBoxGaz);//5
            ListComboBox.Add(comboBoxdrinkRady);//6
            ListComboBox.Add(comboBoxAlcohol);//7
            foreach(TextBox t in ListTextBox)//8
            {
                t.Text = "";
            }

        }
        public bool GetComboBox(object obj)
        {
            if (obj.ToString() == "Да")
                return true;
            else
                return false;
        }

        public Meat GetMeat()
        {
            Meat meat = new Meat();
            meat.Name = ListTextBox[0].Text;
            meat.Calorific = ListTextBox[1].Text;
            meat.ShelfLife = ListTextBox[2].Text;
            meat.ManufactureDate = ListTextBox[3].Text;
            meat.ReadyToEat = GetComboBox(ListComboBox[2].SelectedItem);
            meat.Animal = ListTextBox[4].Text;
            meat.TypeOfMeatProduct = ListTextBox[10].Text;
            meat.FreshOrFreez = GetComboBox(ListComboBox[3].SelectedItem);
            return meat;
        }
        public  Grocery GetgGrocery()
        {
            Grocery grocery = new Grocery();
            grocery.Name = ListTextBox[0].Text;
            grocery.Calorific = ListTextBox[1].Text;
            grocery.ShelfLife = ListTextBox[2].Text;
            grocery.ManufactureDate = ListTextBox[3].Text;
            grocery.Vitamins = ListTextBox[5].Text;
            grocery.WithGMO = GetComboBox(ListComboBox[0].SelectedItem);
            grocery.TypeEat = ListTextBox[6].Text;
            grocery.CerealVariety = ListTextBox[7].Text;
            return grocery;
        }
        public food GetProperties(food CurrenFood)
        { 
            Conserve conserve = new Conserve();
            
            Beverages beverages = new Beverages();
            
            MilkFood milkFood = new MilkFood();
            FlourProducts flour = new FlourProducts();
            
            
            switch (CurrenFood.ClassName())
            {
                case ("Молочная продукция"):
                    {
                        milkFood.Name = ListTextBox[0].Text;
                        milkFood.Calorific = ListTextBox[1].Text;
                        milkFood.ShelfLife = ListTextBox[2].Text;
                        milkFood.ManufactureDate = ListTextBox[3].Text;
                        milkFood.ReadyToEat = GetComboBox(ListComboBox[2].SelectedItem);
                        milkFood.Animal = ListTextBox[4].Text;
                        milkFood.TypeOfMilckProduct = ListTextBox[11].Text;
                        milkFood.LactoseContent = GetComboBox(ListComboBox[4].SelectedItem);
                        milkFood.Fatness = ListTextBox[12].Text;
                        return milkFood;
                    }
                case "Мясные изделия":
                    {
                        return GetMeat();
                    }
                case "Бакалея":
                    {
                        return GetgGrocery();
                    }
                case "Напитки":
                    {
                        beverages.Name = ListTextBox[0].Text;
                        beverages.Calorific = ListTextBox[1].Text;
                        beverages.ShelfLife = ListTextBox[2].Text;
                        beverages.ManufactureDate = ListTextBox[3].Text;
                        beverages.TypeOfDrink = ListTextBox[5].Text;
                        beverages.ReadyToEat = GetComboBox(ListComboBox[0].SelectedItem);
                        beverages.Aerated = GetComboBox(ListComboBox[0].SelectedItem);
                        beverages.Alcohol= GetComboBox(ListComboBox[0].SelectedItem);
                        return beverages;
                    }
                case "Мучные продукты ":
                    {
                        flour.Name = ListTextBox[0].Text;
                        flour.Calorific = ListTextBox[1].Text;
                        flour.ShelfLife = ListTextBox[2].Text;
                        flour.ManufactureDate = ListTextBox[3].Text;
                        flour.Vitamins = ListTextBox[5].Text;
                        flour.WithGMO = GetComboBox(ListComboBox[0].SelectedItem);
                        flour.TypeOfFlourproducts = ListTextBox[8].Text;
                        flour.ContainsSugar = GetComboBox(ListComboBox[1].SelectedItem);
                        flour.GradeFlour = ListTextBox[9].Text;
                        return flour;
                    }
                case "Консервы":
                    {
                        conserve.GroceryConserve = GetgGrocery();
                        conserve.MeatConserve = GetMeat();
                        return conserve;
                    }
                default:
                    {
                        return beverages;
                    }

             }

        }

        void CreateFoodElement(FoodFactory Factory)
        {
                           
            ListFood.Add(GetProperties(Factory.GetFood()));
            foreach (TextBox tb in ListTextBox)
            {
                tb.Text = "";
            }
            foreach(ComboBox cb in ListComboBox)
            {
                cb.SelectedIndex = -1;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateFoodElement(ListFoodFactory[comboBoxMain.SelectedItem.ToString()]);
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
                case "Консервы":
                    {
                        AnimalProducts.Visible = true;
                        panelVegetableProducts.Visible = true;
                        panelMeat.Visible = true;
                        panelCereal.Visible = true;
                        panelDrinks.Visible = false;
                        panelFlour.Visible = false;
                        panelMilck.Visible = false;
                        break;
                    }
             

            }
            if (comboBoxMain.SelectedItem.ToString() == "Консервы")
            {
                panelVegetableProducts.Location= new Point(470,12);
            }
            else
            {
                panelVegetableProducts.Location = new Point(227, 12);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListFoodFactory.Add("Молочная продукция", new MilckFactory());
            ListFoodFactory.Add("Мясные изделия", new MeatFactory());
            ListFoodFactory.Add("Бакалея", new GroceryFactory());
            ListFoodFactory.Add("Мучные продукты ", new FlourFactory());
            ListFoodFactory.Add("Напитки", new BeveragesFactory());
            ListFoodFactory.Add("Консервы", new ConserveFacotry());           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
