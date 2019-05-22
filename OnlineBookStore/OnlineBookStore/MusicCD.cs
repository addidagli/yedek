using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class MusicCD : Product
    {
        private string MusicName;
        private string singer;
        private string type;
        private string demo;
        public MusicCD() { }

        private static MusicCD instance;
        public static MusicCD getInstance()
        {
            if (instance == null)
                instance = new MusicCD();
            return instance;
        }
        public string Musicname
        {
            get
            {
                return MusicName;
            }

            set
            {
                MusicName = value;
            }
        }
        public string Singer
        {
            get
            {
                return singer;
            }

            set
            {
                singer = value;
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
