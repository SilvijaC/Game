using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace miniStore
{
    public partial class Form1 : Form
    {
        private double currentTotal = 0;
        public Form1()
        {
            InitializeComponent();
            DeliveryPanel.Visible = false;
        }

        public void SetGoodsList(List<Goods> goodsList)
        {
            foreach (var item in goodsList)
            {
                ItemListBox.Items.Add(item);
            }

        }

        public void SetCountryList(List<string> countryList)
        {
            foreach (var country in countryList)
            {
                CountryBox.Items.Add(country);
            }

        }
        public void SetDeliveryTypeList(List<string> deliveryTypeList)
        {
            foreach (var type in deliveryTypeList)
            {
                DeliveryTypeBox.Items.Add(type);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var selectedItems = ItemListBox.CheckedItems;
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("No item is selected");
                return;
            }

            AddItemsToBasket(selectedItems);
            ClearSelection();
            CalculateTotal();
        }

        private void AddItemsToBasket(IList list)
        {
            foreach (var selectedItem in list)
            {
                BasketBox.Items.Add(selectedItem);
            }
        }

        private void ClearSelection()
        {
            foreach (var selectedIndex in ItemListBox.CheckedIndices)
            {
                int idx = (int)selectedIndex;
                ItemListBox.SetItemChecked(idx, false);
            }
        }

        public void CalculateTotal()
        {
            double sum = 0;
            foreach (var item in BasketBox.Items)
            {
                var goodsItem = item as Goods;
                sum += goodsItem.Price;
                SumBox.Text = sum.ToString() + " EUR";
            }
            currentTotal = sum;
        }

        private void ContinueToDelivery_Click(object sender, EventArgs e)
        {
            if(BasketBox.Items.Count == 0)
            {
                MessageBox.Show("You can't continue with empty basket");
                return;
            }
            DeliveryPanel.Visible = true;
            ItemSelectionPanel.Enabled = false;
        }

        private void PriceCalculation_Click(object sender, EventArgs e)
        {
            if(CountryBox.SelectedIndex == -1 || DeliveryTypeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Country and Delivery type should be selected");
                return;
            }
            int basketSize = BasketBox.Items.Count;
            string deliveryType = DeliveryTypeBox.SelectedItem as string;
            string deliveryCountry = CountryBox.SelectedItem as string;
            Parcel parcel = new Parcel(basketSize, deliveryType, currentTotal, deliveryCountry);
            SetBasketSize(parcel.DeliverySize);
            SetTotalPriceWithShipping(parcel.CalculateTotalPrice());
        }

        private void SetBasketSize(string deliverySize)
        {
            BasketSizeBox.Text = deliverySize;
        }
        private void SetTotalPriceWithShipping(double price)
        {
            PriceBox.Text = price.ToString() + " EUR";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is completed succesfully");
            Close();
        }
    }
}
