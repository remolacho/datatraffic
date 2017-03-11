using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatraffic.family
{
    class Calendar : Action
    {
        private string firstname, lastname;

		public Calendar(string n, string ln) 
        {
            this.firstname = n;
            this.lastname = ln;
        }

		public Calendar()
        {
            // TODO: Complete member initialization
        }

        public string name
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public string last_name
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public string sleep(string hour)
        {
            return "va a domir a las " + hour;
        }

        public string wake(string hour)
        {
            return "va a despertar a las " + hour;
        }

        public string bath(string hour)
        {
            return "se va a bañar a las " + hour;
        }

        public string have_breakfast(string hour)
        {
            return "va a desayunar a las " + hour;
        }

        public string to_have_lunch(string hour)
        {
            return "va a almorzar a las " + hour;
        }

        public string dine(string hour)
        {
            return "va a cenar a las " + hour;
        }
    }
}
