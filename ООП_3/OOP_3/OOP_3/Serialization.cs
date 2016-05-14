using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace OOP_3
{
   public  interface Serialize
    {
        void Serialize(List<food> FoodList, string fileName);
        List<food> Deserialize(string fileName);
    }
    public class SerializationXML : Serialize
    {
        List<food> Serialize.Deserialize(string fileName)
        {
            food[] FoodArr;
            List<food>  f = new List<food>();
            XmlSerializer xml = new XmlSerializer(typeof(food[]));
            using (var fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                try
                {
                    FoodArr = (food[])xml.Deserialize(fStream);

                    return FoodArr.ToList<food>();
                }
                catch
                {
                    MessageBox.Show("Неверный тип файла");
                   
                }
                return f;
            }
        }

        void Serialize.Serialize(List<food> FoodList, string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(food[]));
            using (var fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xml.Serialize(fStream, FoodList.ToArray());
            }
        }
    }
    public class SerializationBin : Serialize
    {
        public void Serialize(List<food> jewList, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, jewList);
            }
        }

        public List<food> Deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return (List<food>)formatter.Deserialize(fs);
            }
        }
    }
    public class SerializationTxt : Serialize
    {
        public Dictionary<string, FoodFactory> ListFoodFactory = new Dictionary<string, FoodFactory>();
         void FFactory()
        {
            ListFoodFactory.Add("Молочная продукция", new MilckFactory());
            ListFoodFactory.Add("Мясные изделия", new MeatFactory());
            ListFoodFactory.Add("Бакалея", new GroceryFactory());
            ListFoodFactory.Add("Мучные продукты ", new FlourFactory());
            ListFoodFactory.Add("Напитки", new BeveragesFactory());
            ListFoodFactory.Add("Консервы", new ConserveFacotry());
        }
        public List<food> Deserialize(string fileName)
        {
            List<food> ListFood = new List<food>();
            FFactory();
            string[] lines = File.ReadAllLines(fileName);
            
                foreach (string info in lines)
                {
                      string[] Properties = info.Split(new char[] { '_' });
                if (Properties[0] != "Консервы")
                {
                    ListFood.Add(ListFoodFactory[(Properties[0])].GetFood());
                    ListFood[ListFood.Count - 1].StringProperty = info;
                    ListFood[ListFood.Count - 1].SetMainProperties(Properties);
                    ListFood[ListFood.Count - 1].SetIntemediate(Properties);
                    ListFood[ListFood.Count - 1].SetProperties(Properties);
                }
                else
                {
                    Properties = info.Split(new char[] { '_' });
                    ListFood.Add(ListFoodFactory[(Properties[0])].GetFood());
                    ListFood[ListFood.Count - 1].StringProperty = info;
                    
                }
                
            }
            return ListFood;
        }

        public void Serialize(List<food> FoodList, string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                foreach (food f in FoodList)
                {
                    if (f.ClassName() != "Консервы")
                    {
                        file.WriteLine(f.StringProperty);
                    }
                    else
                    {
                        Conserve conserve = new Conserve();
                        conserve = (Conserve)f;
                        file.WriteLine(conserve.StringProperty + "$" + conserve.MeatConserve.StringProperty + "$" + conserve.GroceryConserve.StringProperty);
                    }
                }
            }

        }
    }
}
