using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComp.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, Product product)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", $" + Price);          
            sb.Append(", Quantity: " + Quantity);            
            sb.Append(", Subtotal: $" + subTotal());
            

           
            return sb.ToString();
        }
    }
}
