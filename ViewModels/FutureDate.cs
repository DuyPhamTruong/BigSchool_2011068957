﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool_2011068957.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid =DateTime.TryParseExact(Convert.ToString(value),
            "M/d/yyyy",
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);
            return (isValid&& dateTime>DateTime.Now);
        }

    }
}