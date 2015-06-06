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

        public Room addExit(Exit exit) {
            this.exits.Add(exit);
            return this;
        }

        public Room addItem(ItemLocation loc) {
            this.items.Add(loc);
            return this;
        }
    }

    class ItemLocation {
        public string name;
        public List<List<Trick>> entryMethods;
        public List<List<Trick>> exitMethods;

        public ItemLocation(string name) {
            this.name = name;
            this.entryMethods = new List<List<Trick>>();
            this.exitMethods = new List<List<Trick>>();
        }

        public ItemLocation addEntry(params Trick[] tricks) {
            this.entryMethods.Add(new List<Trick>(tricks));
            return this;
        }

        public ItemLocation addExit(params Trick[] tricks) {
            this.exitMethods.Add(new List<Trick>(tricks));
            return this;
        }

        public override string ToString() {
            return "ItemLocation[" + name + ", [" + String.Join(",", entryMethods) + "], [" + String.Join(",", exitMethods) + "]]";
        }
    }

    class Item {
        public Item(string name) {
            this.name = name;
        }
        public string name;
        public int count;

        public Item setCount(int count) {
            this.count = count;
            return this;
        }

        public override string ToString() {
            return "Item[" + name + "]";
        }
    }

    class Exit {
        public Room dest;
        public List<Trick> tricks;

        public Exit(Room dest, params Trick[] tricks) {
            this.dest = dest;
            this.tricks = new List<Trick>();
            foreach (Trick t in tricks)
                this.tricks.Add(t);
        }

        public Exit addTrick(Trick trick) {
            tricks.Add(trick);
            return this;
        }

        public override string ToString() {
            return "Exit[" + dest.name + ", [" + String.Join(",", tricks) + "]]";
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
        public List<Item> requiredItems;
        public List<Item> disallowedItems;

        public Trick(string name) {
            this.name = name;
            this.requiredItems = new List<Item>();
        }

        public Trick setDesc(string desc) {
            this.desc = desc;
            return this;
        }

        public Trick setUrl(string url) {
            this.docUrl = url;
            return this;
        }

        public Trick addRequiredItem(Item item) {
            this.requiredItems.Add(item);
            return this;
        }

        public Trick addDisallowedItem(Item item) {
            this.requiredItems.Add(item);
            return this;
        }

        public override string ToString() {
            return "Trick[" + name + "]";
        }
    }
}
