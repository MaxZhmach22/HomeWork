
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SpendMoney
{
    [Serializable]
    public class Money
    {


        public decimal Sum { get; set; }
        public string Goods{ get; set; }

        public Money()
        {
        }

        public Money(decimal sum, string goods)
        {
            this.Sum = sum;
            this.Goods = goods;
        }
    }

    public class Day
    {
        string fileName;
        List<Money> perDay;
        

        public string Filename
        {
            set { fileName = value; }
        }

        public Day(string fileName)
        {
            this.fileName = fileName;
            perDay = new List<Money>();
            
        }
        public void Add(decimal sum, string goods)
        {
            perDay.Add(new Money(sum, goods));
        }

        public Money this[int index]//Индексатор 
        {
            get { return perDay[index]; }
        }

        public void Remove(int index)
        {
            perDay.RemoveAt(index);
        }
         
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Money>));
            Stream fStream = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            xmlFormat.Serialize(fStream, perDay);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Money>));
            Stream fStream = new FileStream(fileName, FileMode.Open,
            FileAccess.Read);
            try
            {
                perDay = (List<Money>)xmlFormat.Deserialize(fStream);
                fStream.Close();
            }
            catch (OutOfMemoryException)
            {
                throw;
            }

        }
        public string Print()
        {
            string text = "";
            for (int i = 0; i < perDay.Count; i++)
            {
                text += perDay[i].Goods.ToString() + " " + perDay[i].Sum.ToString()+";";
            }
            return text;
        }
    }
}
