using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Restaurant.Bll
{
    public static class ParserOfName
    {
        public enum NameOrSurname
        {
            Name = 0,
            Surname = 1
        }

        public static string? ParseForNameSurname(string name, NameOrSurname nameOrSurname)
        {
            string nameWithoutSpaces = Regex.Replace(name, @"\s+", " ").Trim();
            string[] subStrings = nameWithoutSpaces.Split(' ');
            
            if (subStrings.Length == 0 || (subStrings.Length == 1 && nameOrSurname == NameOrSurname.Surname))
            {
                return null;
            }
            
            return nameOrSurname == NameOrSurname.Name ? subStrings[0] : subStrings[1];
        }
    }
}
