using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba
{
    class Araba
    {
        private string marka;
        private string renk;
        private short model;
        public string Marka
        {
            get { return marka;}
            set { marka = value; }
        }
        public string Renk
        {
            get { return renk;}
            set { renk = value; }
        }
        public short Model
        {
            get { return model;}
            set { model = value; }
        }

        public override string ToString()
        {
            return marka+" "+model+" "+renk;
        }
    }
}
