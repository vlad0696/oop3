using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, FoodFactory> ListFoodFactory = new Dictionary<string, FoodFactory>();
        public List<food> ListFood = new List<food>();
        public List<TextBox> ListTextBox = new List<TextBox>();
        public List<ComboBox> ListComboBox = new List<ComboBox>();
        public List<TextBox> td = new List<TextBox>();
        ComboBox cb;
        public Form1()
        {
            InitializeComponent();
            cb = comboBoxElements;
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
            td.Add(textBox1);
            td.Add(textBox2);
            td.Add(textBox3);
            td.Add(textBox4);
            td.Add(textBox5);
            td.Add(textBox6);
            td.Add(textBox7);
            td.Add(textBox8);
            td.Add(textBox9);
            td.Add(textBox10);
            td.Add(textBox11);
            td.Add(textBox12);
            td.Add(textBox13);
            td.Add(textBox14);
            foreach(TextBox t in td)
            {
                t.Visible = false;
            }

        }
        public bool GetComboBox(object obj)
        {
            if (obj.ToString() == "Да")
                return true;
            else
                return false;
        }

        #region Get Products

        public Meat GetMeat(string Result)
        {
            Meat meat = new Meat();
            meat.Name = ListTextBox[0].Text;
            meat.Calorific = ListTextBox[1].Text;
            meat.ShelfLife = ListTextBox[2].Text;
            meat.ManufactureDate = ListTextBox[3].Text;
            Result=GetResultString(Result, (meat.ReadyToEat = GetComboBox(ListComboBox[2].SelectedItem)).ToString());
            Result= GetResultString(Result, meat.Animal = ListTextBox[4].Text);
            Result= GetResultString(Result, meat.TypeOfMeatProduct = ListTextBox[10].Text);
            Result= GetResultString(Result, (meat.FreshOrFreez = GetComboBox(ListComboBox[3].SelectedItem)).ToString());
            meat.StringProperty = Result;
            return meat;
        }
        public  Grocery GetgGrocery( string Result)
        {
            Grocery grocery = new Grocery();
            grocery.Name = ListTextBox[0].Text;
            grocery.Calorific = ListTextBox[1].Text;
            grocery.ShelfLife = ListTextBox[2].Text;
            grocery.ManufactureDate = ListTextBox[3].Text;
            Result= GetResultString(Result,  grocery.Vitamins = ListTextBox[5].Text);
            Result=GetResultString(Result, (grocery.WithGMO = GetComboBox(ListComboBox[0].SelectedItem)).ToString());
            Result= GetResultString(Result, grocery.TypeEat = ListTextBox[6].Text);
            Result= GetResultString(Result, grocery.CerealVariety = ListTextBox[7].Text);
            grocery.StringProperty = Result;
            return grocery;
        }
        public MilkFood GetMilck(string result)
        {
            MilkFood milkFood = new MilkFood();
            milkFood.Name = ListTextBox[0].Text;
            milkFood.Calorific = ListTextBox[1].Text;
            milkFood.ShelfLife = ListTextBox[2].Text;
            milkFood.ManufactureDate = ListTextBox[3].Text;
            result = GetResultString(result, milkFood.Animal = ListTextBox[4].Text);
            result = GetResultString(result, (milkFood.ReadyToEat = GetComboBox(ListComboBox[2].SelectedItem)).ToString());
            result = GetResultString(result, milkFood.TypeOfMilckProduct = ListTextBox[11].Text);
            result = GetResultString(result, milkFood.Fatness = ListTextBox[12].Text);
            result = GetResultString(result, (milkFood.LactoseContent = GetComboBox(ListComboBox[4].SelectedItem)).ToString());
            milkFood.StringProperty = result;
            return milkFood;
        }
        public FlourProducts GetFlour(string result)
        {
             FlourProducts flour = new FlourProducts();
            flour.Name = ListTextBox[0].Text;
            flour.Calorific = ListTextBox[1].Text;
            flour.ShelfLife = ListTextBox[2].Text;
            flour.ManufactureDate = ListTextBox[3].Text;
            result = GetResultString(result, flour.Vitamins = ListTextBox[5].Text);
            result = GetResultString(result, (flour.WithGMO = GetComboBox(ListComboBox[0].SelectedItem)).ToString());
            result = GetResultString(result, flour.TypeOfFlourproducts = ListTextBox[8].Text);
            result = GetResultString(result, (flour.ContainsSugar = GetComboBox(ListComboBox[1].SelectedItem)).ToString());
            result = GetResultString(result, flour.GradeFlour = ListTextBox[9].Text);
            flour.StringProperty = result;
            return flour;
        }
        public Beverages GetBeverages(string result)
        {
            Beverages beverages = new Beverages();
            beverages.Name = ListTextBox[0].Text;
            beverages.Calorific = ListTextBox[1].Text;
            beverages.ShelfLife = ListTextBox[2].Text;
            beverages.ManufactureDate = ListTextBox[3].Text;
            result = GetResultString(result, beverages.TypeOfDrink = ListTextBox[13].Text);
            result = GetResultString(result, (beverages.ReadyToEat = GetComboBox(ListComboBox[5].SelectedItem)).ToString());
            result = GetResultString(result, (beverages.Aerated = GetComboBox(ListComboBox[6].SelectedItem)).ToString());
            result = GetResultString(result, (beverages.Alcohol = GetComboBox(ListComboBox[7].SelectedItem)).ToString());
            beverages.StringProperty = result;
            return beverages;
        }
        #endregion
        public string GetResultString(string s,string addsting)
        {
            StringBuilder result = new StringBuilder();
            result.Append(addsting+"_");
            return s += result.ToString();
        }
        public food GetProperties(food CurrenFood)
        { 
            Conserve conserve = new Conserve();
            string result = "";
            StringBuilder Resultstring = new StringBuilder();
            Resultstring.Append(CurrenFood.ClassName()+"_");
            for (int i=0;i<4; i++)
            {
                Resultstring.Append(ListTextBox[i].Text+"_");
            }
            result = Resultstring.ToString();
            switch (CurrenFood.ClassName())
            {
                case ("Молочная продукция"):
                    {
                        return GetMilck(result);                       
                    }
                case "Мясные изделия":
                    {
                        return GetMeat(result);
                    }
                case "Бакалея":
                    {
                        return GetgGrocery(result);
                    }
                case "Напитки":
                    {
                        return GetBeverages(result);
                    }
                case "Мучные продукты ":
                    {
                        return GetFlour(result);
                    }
                case "Консервы":
                    {
                        conserve.Name = ListTextBox[0].Text;
                        conserve.Calorific = ListTextBox[1].Text;
                        conserve.ShelfLife = ListTextBox[2].Text;
                        conserve.ManufactureDate = ListTextBox[3].Text;
                        conserve.StringProperty = Resultstring.ToString();
                        conserve.GroceryConserve = GetgGrocery(result);
                        conserve.MeatConserve = GetMeat(result);
                        return conserve;
                    }
                default:
                    {
                        
                        return conserve;
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
            comboBoxElements.Items.Add(ListFood[ListFood.Count - 1].Name);
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
                //this.Width = 740;
            }
            else
            {
                //this.Width =490;
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


        private void SelectedIndex(object sender, EventArgs e)
        {
            foreach (TextBox t in td)
            {
                t.Visible = false;
            }
            char symbol = '_';
            string[] properties;
            properties =ListFood[comboBoxElements.SelectedIndex].StringProperty.Split(symbol);
            if(properties[0]!="Консервы")
            for (int i=0; i< properties.Length - 1; i++)
            {
                td[i].Text = properties[i];
                td[i].Visible = true;
                td[i].Enabled = false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    td[i].Text = properties[i];
                    td[i].Visible = true;
                    td[i].Enabled = false;
                }
                Conserve conserve = new Conserve();
                conserve = (Conserve)ListFood[comboBoxElements.SelectedIndex];
                properties=conserve.MeatConserve.StringProperty.Split(symbol);
                for (int i = 5; i <9; i++)
                {
                    td[i].Text = properties[i];
                    td[i].Visible = true;
                    td[i].Enabled = false;
                }
                properties = conserve.GroceryConserve.StringProperty.Split(symbol);
                for (int i = 5; i < 9; i++)
                {
                    td[i + 4].Text = properties[i];
                    td[i + 4].Visible = true;
                    td[i + 4].Enabled = false;
                }

            }
           
            
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            
            
            for(int i = 0;i< ListFood.Count+1; i++ )
            {
                if (ListFood[i].Name == comboBoxElements.SelectedItem.ToString())
                {
                    string name = ListFood[i].Name;
                    ListFood[i]=GetProperties(ListFood[i]);
                    ListFood[i].Name = name;
                }
                i++;
            }
            comboBoxElements.SelectedIndex = -1;
        }

        private void buttonSerialization_Click(object sender, EventArgs e)
        {
            Serialize serial = new SerializationXML();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            switch (comboBoxSer.SelectedIndex)
            {
                case (0):
                    {
                        serial = new SerializationXML();
                        break;
                    }
                case (1):
                    {
                        serial = new SerializationBin();
                        break;
                    }
                case (2):
                    {
                        serial = new SerializationTxt();
                        break;
                    }

            }
            serial.Serialize(ListFood, saveFileDialog1.FileName);
           
        }

        private void buttonDeSer_Click(object sender, EventArgs e)
        {
            Serialize serial = new SerializationXML();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            switch (comboBoxSer.SelectedIndex)
            {
                case (0):
                    {
                        serial = new SerializationXML();
                        break;
                    }
                case (1):
                    {
                        serial = new SerializationBin();
                        break;
                    }
                case (2):
                    {
                        serial = new SerializationTxt();
                        break;
                    }

            }
            ListFood = serial.Deserialize(openFileDialog1.FileName);
            comboBoxElements.Items.Clear();
            foreach (food f in ListFood)
            {
                comboBoxElements.Items.Add(f.Name);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            ListFood.RemoveAt(comboBoxElements.SelectedIndex);
            
            comboBoxElements.Items.RemoveAt(comboBoxElements.SelectedIndex);
        }
    }
}
