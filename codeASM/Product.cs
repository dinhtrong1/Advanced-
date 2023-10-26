using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeASM
{
    internal class Product
    {
        private int id;
        private string name;
        private string description;
        private decimal price;
        private int quantity;

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The name can't be null");
                }
                name = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The description can't be null");
                }
                description = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The product price must be greater than 0");
                }
                price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The product quantity must be greater than 0");
                }
                quantity = value;
            }
        }

        public Product(string name, string description, decimal price, int quantity)
        {
            if (Program.products.Count > 0)
            {
                int setID = Program.products.ElementAt(Program.products.Count - 1).ID;
                this.id = setID + 1;
            }
            else
            {
                this.id = 1;
            }
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ID: {id} Name: {Name} Price: {Price} Quantity: {Quantity} Description: {Description}";
        }

        public bool CheckAvailable()
        {
            if (Quantity > 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckDuplicated(string name)
        {
            foreach (Product product in Program.products)
            {
                if (product.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
