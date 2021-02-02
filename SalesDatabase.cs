using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTracker
{
    public class SalesDatabase
    {
        public BindingList<SalesSettings.Sale> Sales { get; set; }
    }

}
