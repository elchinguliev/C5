using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C5
{
    public class Card
    {

        public string Pan
        {
            get;
            set;
        }
        public string Pin
        {
            get;
            set;
        }
        public string Cvc
        {
            get;
            set;
        }
        public string Expiredate
        {
            get;
            set;
        }
        public int Balance
        {
            get;
            set;
        }
        public override string ToString()
        {
            return $"PAN : {Pan}\nPIN : {Pin}\nCVC : {Cvc}\nExpire Date : {Expiredate}\nBalance : {Balance}";
        }


    }
}
