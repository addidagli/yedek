using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OnlineBookStore
{
    class Customer
    {
        private int customerID;
        private string name;
        private string adress;
        private string email;
        private string username;
        private string password;
        private Image image;
        private static Customer instance;
        public Customer() { }
        public static Customer getInstance()
        {
            if (instance == null)
                instance = new Customer();
            return instance;
        }
        public int CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

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

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
    }
}
