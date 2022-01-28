using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    class Patterns
    {
        //public static string regex = "^([A-Za-z0-9]+[.#+_])*[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
        //public static string RegexRulesFor3char = "^([0-9]*[a-zA-Z]{3,})[0-9a-zA-Z]*$";
        //public static string Regex_Pincode = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        //public static string regex = "^[0-9]*[A-Za-z]{3,}[0-9A-Za-z]*$";
        //public static string regex = "^[1-9][0-9]{5}$";
        //public static string regex = "^^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        //public static string regex = "^[A-Za-z0-9]+[@][A-Za-z]+[.][a-z]{3}$"; //email regex
        //public static string regex = "^[A-Za-z0-9]+([.#_][A-Za-z0-9]+)[@][A-Za-z]+[.][a-z]{2,3}[.][a-z]{2}$";
        public static string regex = "^[A-Za-z0-9]+([.#_+][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2})?$";
        public static string regex2 = "^[A-Z][a-z]{2,}$";
        public static string regex3 = "^[A-Z][a-z]{2,}$";
        public static string regex4 = "^[0-9]{2}[ ][0-9]{10}$";
        public static string regex5 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#?$&])[a-zA-Z0-9!@#?$&]{8,}$";
        public bool validateEmail(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, regex2);
        }
        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, regex3);
        }
        public bool validateMobile(string mobile)
        {
            return Regex.IsMatch(mobile, regex4);
        }
        public bool password(string password1)
        {
            return Regex.IsMatch(password1, regex5);
        }

    }

}
