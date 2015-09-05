using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public interface IPad
    {
        string this[string s] { get; set; }
        event EventHandler<EventArgs> RangeExceeded;
    }
}
