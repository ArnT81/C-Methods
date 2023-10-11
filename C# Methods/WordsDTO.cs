using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Methods
{

    public class WordsDTO
    {
        public string[] StringArray { get; set; }
        public bool TheBool { get; set; }
        public string TheString { get; set; }

        public WordsDTO(string[] stringArray, bool thebool, string theString )
        {
            StringArray = stringArray;
            TheBool = thebool;
            TheString = theString;
        }
    }
}
