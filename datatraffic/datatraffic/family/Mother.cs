using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatraffic.family
{
	class Mother : Calendar
    {
        public Mother(string name, string lastname) : base(name, lastname) { }

        public string work() 
		{
            return "Su trabajo es ama de casa";
        }
         
    }
}
