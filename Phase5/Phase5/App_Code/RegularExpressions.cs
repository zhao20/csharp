using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase5.App_code
{
    public class RegularExpressions
    {
        public const string TelephoneValidation = @"^[0-9 ]+$";
        public const string IntegerValidation = @"^[0-9]*$";
        public const string ZipcodeValidation = @"^([0-9]{5})([\-]{1}[0-9]{4})?$";
        public const string PhoneValidation = @"^\(?[\d]{3}\)?[\s-]?[\d]{3}[\s-]?[\d]{4}$";
    }
}