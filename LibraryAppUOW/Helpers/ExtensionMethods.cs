﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAppUOW.Helpers
{
    public static class ExtensionMethods
    {
        public static bool AnySafe<T>(this IEnumerable<T> items)
        {
            return items != null && items.Any();
        }
    }
}