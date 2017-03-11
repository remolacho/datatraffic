using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatraffic.family
{
	class Child : Calendar
    {
       public Child(string name, string lastname) : base(name, lastname){}

       public string work()
       {
           return "El no trabaja solo estudia";
       }
    }
}
