using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class Magazine : Product
    {
        private string MagazineName;
        private string issue; //the issue of the magazine
        private string type; //enum yapısı ile yap  (Actual, News, Sport, computer, technology, etc.)
        public Magazine() { }

        private static Magazine instance;
        public static Magazine getInstance()
        {
            if (instance == null)
                instance = new Magazine();
            return instance;
        }
        public string Magazinename
        {
            get
            {
                return MagazineName;
            }

            set
            {
                MagazineName = value;
            }
        }
        public string Issue
        {
            get
            {
                return issue;
            }

            set
            {
                issue = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
