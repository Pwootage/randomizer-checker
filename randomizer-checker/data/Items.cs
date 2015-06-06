using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;

namespace randomizer_checker.data {
    class Items {

        protected Items() {
        }

        public Dictionary<String, Item> items = new Dictionary<string, Item>();


        protected void add(string name) {
            items.Add(name, new Item(name));
        }

        public Item get(string name) {
            return items[name];
        }
    }
}
