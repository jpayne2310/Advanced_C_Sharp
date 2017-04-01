using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appointment_manager
{
    class myValidate
    {
        //checks to see if field is filled in
        public static bool FilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
