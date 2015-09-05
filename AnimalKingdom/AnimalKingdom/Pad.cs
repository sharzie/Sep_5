using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Pad : IPad
    {
        Dictionary<string, string> MyDic = new Dictionary<string, string>();
        public event EventHandler<EventArgs> RangeExceeded;
        public string this[string s] 
        {
            get
            {
                return MyDic[s];
            }
            set
            {
                MyDic[s] = value;
            }
        }
    }
}
