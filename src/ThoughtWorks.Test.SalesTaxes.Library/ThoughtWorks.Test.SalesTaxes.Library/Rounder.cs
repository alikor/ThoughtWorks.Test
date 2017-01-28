using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThoughtWorks.Test.SalesTaxes.Library {
    public sealed class Rounder  {

        #region IRounder Members

        public static decimal Round(decimal value) {
            var ceiling = Math.Ceiling(value * 20);
            if (ceiling == 0) {
                return 0;
            }
            return ceiling / 20;
        }

        #endregion
    }
}
