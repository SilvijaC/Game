using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();

            var goodsList = new FileReader().ReadGoodsFromFile("Goods.txt");
            form.SetGoodsList(goodsList);

            var countryList = new List<string>() 
            { 
                "Lithuania", "Any other"    
            };
            form.SetCountryList(countryList);

            var deliveryTypeList = new List<string>()
            {
                "Post Office", "Courier Services","Post Machine"
            };
            form.SetDeliveryTypeList(deliveryTypeList);

            Application.Run(form);

        }
    }
}
