using System;

namespace miniStore
{
    public class Parcel : IHasPriceCalculation
    {
        public string DeliverySize { get => GetDeliverySize(); }
        public int BasketSize { get; private set; }
        public string DeliveryType { get; private set; }
        public double SumWithouthShipping { get; private set; }
        public string DeliveryCountry { get; private set; }

        public Parcel(int basketSize, string deliveryType, double sumWithouthShipping,
            string deliveryCountry)
        {
            //if (string.IsNullOrEmpty(deliveryType))
            //{
            //    throw new ArgumentException("Delivery date cannot be null or empty");
            //}

            this.BasketSize = basketSize;
            this.DeliveryType = deliveryType;
            this.SumWithouthShipping = sumWithouthShipping;
            this.DeliveryCountry = deliveryCountry;
        }
        private double CalculateDeliveryCost()
        {
            double sumDelivery = 0;
            if(DeliveryCountry != "Lithuania")
            {
                sumDelivery += 6.50;
            }
            else
            {
                if(DeliveryType == "Post Office")
                {
                    sumDelivery += 1.50;
                }
                else if(DeliveryType == "Courier Services")
                {
                    sumDelivery += 3.50;
                }
                else
                {
                    sumDelivery += 2.50;
                }
            }
            return sumDelivery;
        }

        public double CalculateTotalPrice()
        {
            double result = SumWithouthShipping + CalculateDeliveryCost();
            return result;
        }

        private string GetDeliverySize()
        {
            if (BasketSize <= 3)
            {
                return "S";
            }

            if (BasketSize > 3 && BasketSize < 7)
            {
                return "M";
            }

            return "L";
        }
    }
}