using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;
using randomizer_checker.data;
using randomizer_checker.data.prime1;

namespace randomizer_checker {
    class MainEntry {
        static Prime1Items p1items;
        static Prime1Tricks p1tricks;
        static Prime1Rooms p1rooms;
        static Prime1ItemLocations p1locs;

        static void Main(string[] args) {
            //StringExtractor.RunRooms();

            p1items = new Prime1Items();
            p1tricks = new Prime1Tricks(p1items);
            p1rooms = new Prime1Rooms(p1tricks, (a, b) => null);
            p1locs = new Prime1ItemLocations(p1rooms, p1tricks);

            initSanity();
            List<string> errs = new List<string>();
            errs.AddRange(doorSanityCheck(p1rooms));

            if (errs.Count > 0) {
                Console.WriteLine("Possible problems:");
            } else {
                Console.WriteLine("Sanity check successful!");
            }
            errs.ForEach(Console.WriteLine);
            System.IO.File.WriteAllLines("C:/Users/Christopher/Documents/GitHub/randomizer-checker/randomizer-checker/randomizer-checker/errs.txt", errs);
        }

        static HashSet<string> knownMismatches = new HashSet<String>();

        static void initSanity() {
            //Known door mismatches
            addMismatch(Prime1Rooms.RootTunnel, Prime1Rooms.RootCave);
            addMismatch(Prime1Rooms.RootCave, Prime1Rooms.ArborChamber);
            addMismatch(Prime1Rooms.FrigateCrashSite, Prime1Rooms.WaterfallCavern);
            addMismatch(Prime1Rooms.TempleSecurityStation, Prime1Rooms.TempleLobby);
        }

        static void addMismatch(string a, string b) {
            knownMismatches.Add(a + "-" + b);
            knownMismatches.Add(b + "-" + a);
        }
        static List<String> doorSanityCheck(Rooms rooms) {
            List<String> errs = new List<String>();
            foreach (Room r in rooms.rooms.Values) {
                foreach (Exit e in r.exits) {
                    foreach (Trick t in e.tricks) {
                        if (t.name == Prime1Tricks.Door) {
                            string err = assertDoor(e.dest, r, t.requiredItems);
                            if (err != null)
                                errs.Add(err);
                        }
                    }
                }
            }
            return errs;
        }

        static string assertDoor(Room src, Room dst, List<Item> requiredItems) {
            foreach (Exit e in src.exits) {
                if (e.dest == dst) {
                    foreach (Trick t in e.tricks) {
                        if (t.name == Prime1Tricks.Door) {
                            if (!t.requiredItems.SequenceEqual(requiredItems) && !knownMismatches.Contains(src.name + "-" + dst.name)) {
                                return "WARNING: Doors require different items " + src.name + " <-> " + dst.name + " ([" + String.Join(",", t.requiredItems) + "] != [" + String.Join(",", requiredItems) + "])";
                            } else {
                                return null;
                            }
                        }
                    }
                }
            }
            return "ERROR: Door should exist (but does not): " + src.name + " -> " + dst.name;
        }
    }
}
