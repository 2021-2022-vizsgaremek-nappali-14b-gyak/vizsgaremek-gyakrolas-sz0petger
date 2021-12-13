using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Exeption
{
    public class NegativOsszegBefizeteseKivetel :Exception
    {
        public NegativOsszegBefizeteseKivetel(string message) : base(message)
        {
            Debug.WriteLine(message);
        }

    }
}
