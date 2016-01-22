namespace Teleimot.Common.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class ValidateRentingAndSellingPrice
    {
        public static bool CanBeRentOrSold(string price)
        {
            return (string.IsNullOrEmpty(price) || int.Parse(price) == 0);
        }
    }
}