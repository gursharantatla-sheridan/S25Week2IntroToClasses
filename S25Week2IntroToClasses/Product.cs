using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S25Week2IntroToClasses
{
    public class Product
    {
        // fields
        private int id;
        private string _name;
        private double _price;

        // auto-implemented property
        public int Quantity { get; set; }

        // constructors
        public Product()
        {
            id = 0;
            _name = "";
            _price = 0;
        }

        public Product(int id, string name, double price)
        {
            this.id = id;
            _name = name;
            _price = price;
        }

        // properties
        public int Id
        {
            //get { return id; }
            get => id;
            set 
            {
                if (value >= 0)
                    id = value; 
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
