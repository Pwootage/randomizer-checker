using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace randomizer_checker {
    class StringExtractor {
        public static void RunRooms() {
            string[] lines = System.IO.File.ReadAllLines("C:/Users/Christopher/Documents/GitHub/randomizer-checker/randomizer-checker/randomizer-checker/Rooms.cs");
            List<string> defs = new List<String>();
            List<string> uses = new List<String>();
            foreach (string line in lines) {
                Match m = Regex.Match(line, "add\\(([A-Za-z]+), \"(.+)\"\\);");
                if (m != null && m.Success) {
                    string zone = m.Groups[1].Value;
                    string str = m.Groups[2].Value;
                    string c = str.Replace(" ", "");
                    defs.Add("        public const string " + c + " = \"" + str + "\";");
                    uses.Add("            add(" + zone + ", " + c + ");");
                }
            }
            System.IO.File.WriteAllLines("C:/Users/Christopher/Documents/GitHub/randomizer-checker/randomizer-checker/randomizer-checker/defs.txt", defs);
            System.IO.File.WriteAllLines("C:/Users/Christopher/Documents/GitHub/randomizer-checker/randomizer-checker/randomizer-checker/uses.txt", uses);
        }
    }
}
