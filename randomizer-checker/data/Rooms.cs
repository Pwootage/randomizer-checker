using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;

namespace randomizer_checker.data {
    class Rooms {

        protected Rooms() {
        }

        public Dictionary<String, Room> rooms = new Dictionary<string, Room>();


        protected void add(string zone, string name) {
            rooms.Add(zone + "-" + name, new Room(zone, name));
        }

        public Room get(string zone, string name) {
            return rooms[zone + "-" + name];
        }
    }
}
