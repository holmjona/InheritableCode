using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeTheMoney {
    class SuperHero : Person {
        private string _CapeColor;

        public SuperHero(string fName, string last):base(fName,last) {
            //FirstName = fName;
            //LastName = last;
        }

        public string CapeColor {
            get { return _CapeColor; }
            set { _CapeColor = value; }
        }

        public override string Sing() {
            return "Yodela-he-hoo";
        }
        public override Person CopyMe() {
            return this;
        }
        public override string ToString() {
            
        }

    }
}
