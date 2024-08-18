using System;
using System.Collections.Generic;

namespace Dul
{
    public class DateTimeUtility
    {
        public static string ShowTimeOrDate(object dt,string format="yyyy-MM--dd")
        {
            if(dt != null&&DateTime.TryParse(dt.ToString(),out DateTime dateTime))
            {
                if(dateTime.Date==DateTime.Now.Date)
                {
                    return dateTime.ToString("hh:mm:ss");
                }
                else
                {
                    return dateTime.ToString(format);
                }
            }
            else
            {
                return "";
            }
        }
    }

}