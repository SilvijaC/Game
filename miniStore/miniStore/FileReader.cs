using System.Collections.Generic;

namespace miniStore
{
    class FileReader
    {
        public List<Goods> ReadGoodsFromFile(string fileName)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(fileName);
            string line = null;
            List<Goods> goodsList = new List<Goods>();
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split('|');
                string name = data[0];
                double price = double.Parse(data[1]);
                var item = new Goods(name, price);

                goodsList.Add(item);
            }
            reader.Close();

            return goodsList;
        }
    }
}
