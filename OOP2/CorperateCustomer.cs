using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //:Customer --> inheritance
    class CorperateCustomer:Customer
        //corperate - tüzel
    {
        
        public string FactoryName { get; set; }
        public string TaxNo { get; set; }
    }
}
