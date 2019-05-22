using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OnlineBookStore
{
    public abstract class Product
    {
        string name;
        int id;
        double price;
        private Image image;

        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }
        public void printProperties() //shows the all properties of the items.
        {

        }

    }
}
