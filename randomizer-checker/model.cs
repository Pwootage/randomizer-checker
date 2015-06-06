using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomizer_checker.model {
    class Room {
        public string zone;
        public string name;
        public List<ItemLocation> items = new List<ItemLocation>();
        public List<Exit> exits = new List<Exit>();

        public Room(string zone, string name) {
            this.name = name;
            this.zone = zone;
        }

        public void addExit(Exit exit) {
            this.exits.Add(exit);
        }

        public void addItem(ItemLocation loc) {
            this.items.Add(loc);
        }
    }

    class ItemLocation {
        public ItemLocation(string name) {
            this.name = name;
            this.entryMethods = new List<Trick>();
            this.exitMethods = new List<Trick>();
        }

        public string name;
        public List<Trick> entryMethods;
        public List<Trick> exitMethods;

        public void addEntry(Trick trick) {
            this.entryMethods.Add(trick);
        }

        public void addExit(Trick trick) {
            this.exitMethods.Add(trick);
        }
    }

    class Item {
        public Item(string name) {
            this.name = name;
        }
        public string name;
    }

    class Exit {
        public string name;
        /// <summary>
        /// Trick required to use this "exit"
        /// </summary>
        public Room dest;
        public Trick trick;

        public Exit(string name, Room dest, Trick trick) {
            this.name = name;
            this.dest = dest;
            this.trick = trick;
        }
    }

    class Trick {
        public string name;
        /// <summary>
        /// Optional documentation URL (video, for example)
        /// </summary>
        public string docUrl;
        /// <summary>
        /// Description of trick in question (how to perform, where to perform, etc)
        /// </summary>
        public string desc;
        /// <summary>
        /// Difficulty rating for this instance of this type of trick; 1-100.
        /// </summary>
        public int difficulty;

        public Trick(string name, int difficulty) {
            this.name = name;
            this.difficulty = difficulty;
        }
    }
}
