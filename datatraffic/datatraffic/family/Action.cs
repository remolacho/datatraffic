using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datatraffic.family
{
    interface Action
    {
        string sleep(string hour);
        string wake(string hour);
        string bath(string hour);
        string have_breakfast(string hour);
        string to_have_lunch(string hour);
        string dine(string hour);
    }
}
