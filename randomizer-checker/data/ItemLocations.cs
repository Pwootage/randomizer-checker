using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;

namespace randomizer_checker {
    class ItemLocations {
        public Dictionary<String, ItemLocation> locations = new Dictionary<string, ItemLocation>();

        public ItemLocations() {
        }

        protected void add(string name) {
            this.locations.Add(name, new ItemLocation(name));
        }

        public ItemLocation get(string name) {
            return locations[name];
        }

    }
}
