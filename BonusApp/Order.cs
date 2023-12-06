using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double BonusProvider(double amount);
    public class Order
    {
        public BonusProvider Bonus;
        public List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public double GetValueOfProducts()
        {
            double totalValue = 0;
            foreach (Product p in products)
            {
                totalValue += p.Value;
            }
            return totalValue;
        }
        public double GetBonus()
        {
            double orderValue = GetValueOfProducts();   // i dette eksempel bruges en delegate kaldet 'BonusProvider' og 'GetBonus'-Metoden bruger denne delegate -
            double bonus = Bonus(orderValue);   // til at udregne bonusen ved at kalde den med den samlede værdi af produkterne som argument. 
            return bonus;                               // Jeg har kaldt den 'bonusDelegate' da jeg bruger delegate for bonus.
        }
        public double GetTotalPrice()
        {
            double orderValue = GetValueOfProducts();
            double bonus = GetBonus();
            double totalPrice = orderValue - bonus;
            return totalPrice;
        }

    }
}
