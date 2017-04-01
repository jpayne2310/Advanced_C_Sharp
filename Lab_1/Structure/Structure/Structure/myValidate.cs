using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure
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

        //checks for unacceptable words
        public static bool HasBadWords(string temp)
        {
            bool result = false;

            if (temp.Contains("poop") || temp.Contains("feces") ||
                temp.Contains("homework"))
            {
                result = true;
            }
            return result;
        }

        //check for minimum string length
        public static bool MinRequirement(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen || temp.Length == 0)
            {
                result = true;
            }

            return result;
        }

        //check for maximum string length
        public static bool MaxRequirement(string temp, int maxlen)
        {
            bool result = false;

            if (temp.Length <= maxlen)
            {
                result = true;
            }

            return result;
        }

        //check for required string length
        public static bool LengthRequirement(string temp, int lenreq)
        {
            bool result = false;

            if (temp.Length == lenreq || temp.Length == 0)
            {
                result = true;
            }

            return result;
        }

        //check for valid email
        public static bool IsEmailValid(string temp)
        {
            bool result = true;
            if (temp.Length != 0)
            {
                //look for position of @
                int atLocation = temp.IndexOf("@");
                //look for position of last period
                int periodLocation = temp.LastIndexOf(".");

                //check for minimum length
                if (temp.Length < 8)
                {
                    result = false;
                }

                //check for 2 character before @
                else if (atLocation < 2)
                {
                    result = false;
                }

                //check for 2 characters between @ and (.)
                else if ((atLocation + 2) >= periodLocation)
                {
                    result = false;
                }

                //chechk for at least two character after (.)
                else if (periodLocation >= (temp.Length - 2))
                {
                    result = false;
                }
            }
            return result;
        }

        //check to see if combo box selection changed
        public static bool IsItemSeleced(int temp)
        {
            bool result = false;

            if (temp == 0)
            {
                result = true;
            }

            return result;
        }

    }
}
