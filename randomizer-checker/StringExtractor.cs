using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace randomizer_checker {
    class StringExtractor {
        public static void RunRooms() {
            string[] lines = System.IO.File.ReadAllLines("C:/Users/Christopher/Documents/GitHub/randomizer-checker/randomizer-checker/randomizer-checker/in.txt");
            List<string> defs = new List<String>();
            foreach (string line in lines) {
                string str = line;
                string name = Regex.Replace(str, "[()\\- ]", "");
                defs.Add("public const string " + name + " = \"" + str + "\";");
            }
            System.IO.File.WriteAllLines("C:/Users/Christopher/Documents/GitHub/randomizer-checker/randomizer-checker/randomizer-checker/out.txt", defs);
        }
    }
}
