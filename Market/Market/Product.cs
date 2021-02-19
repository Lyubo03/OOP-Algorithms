
using System;

namespace Market
{
    class Product
    {
        private string nameOfProduct;
        private decimal priceOfProduct;
        public void SetName(string name)
        {
            if (name == null)
            {
                throw new Exception("There is no product without name!");
            }
            else
            {
                this.nameOfProduct = name;
            }
        }
        public void SetPrice(decimal productPrice)
        {
            if (productPrice <= 0)
            {
                throw new Exception("There is nothing priceless!");
            }
            else
            {
                this.priceOfProduct = productPrice;
            }
        }
        public string NameOfProduct
        {
            get { return nameOfProduct; }
        }
        public decimal ProductPrice
        {
            get { return priceOfProduct; }
        }
    }
}