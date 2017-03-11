using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatraffic.family
{
	class Father : Calendar
    {
        public Father(string name, string lastname) : base(name, lastname) { }

        public string work()
        {
            return "Su trabajo es programador";
        }
    }
}
