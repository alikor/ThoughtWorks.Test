using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {

    [Flags]
    public enum ProductType {
        Other = 0x1,
        Book = 0x2,
        Food = 0x4,
        Medical = 0x8
    }
}
