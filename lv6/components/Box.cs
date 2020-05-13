using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    class Box : ICollection
    {
        private List<Product> products;
        public Box()
        {
            this.products = new List<Product>();
        }
        public Box(List<Note> notes)
        {
            this.products = new List<Product>(products.ToArray());
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public void Clear()
        {
            foreach (Product product in products)
            {
                products.Remove(product);
            }
        }
        public int Count { get { return this.products.Count; } }
        public Product this[int index] { get { return this.products[index]; } }
        public IIterator GetIterator() { return new ProductIterator(this); }
    }
}
