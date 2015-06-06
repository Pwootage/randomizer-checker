using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;

namespace randomizer_checker {
    class Rooms {
        //Zones
        public const string TallonOverworld = "Tallon Overworld";
        public const string ChozoRuins = "Chozo Ruins";
        public const string MagmoorCaverns = "Magmoor Caverns";
        public const string PhendrenaDrifts = "Phendrena Drifts";
        public const string PhazonMines = "Phazon Mines";

        //Rooms
        //Tallon
        public const string LandingSite = "Landing Site";
        public const string Alcove = "Alcove";
        public const string TallonCanyon = "Tallon Canyon";
        public const string RootTunnel = "Root Tunnel";
        public const string RootCave = "Root Cave";
        public const string ArborChamber = "Arbor Chamber";
        public const string TransportTunnelB = "Transport Tunnel B";
        public const string TransporttoMagmoorCavernsEast = "Transport to Magmoor Caverns East";
        public const string TransportTunnelA = "Transport Tunnel A";
        public const string TransporttoChozoRuinsWest = "Transport to Chozo Ruins West";
        public const string Gully = "Gully";
        public const string TempleHall = "Temple Hall";
        public const string TempleSecurityStation = "Temple Security Station";
        public const string TempleLobby = "Temple Lobby";
        public const string ArtifactTemple = "Artifact Temple";
        public const string WaterfallCavern = "Waterfall Cavern";
        public const string FrigateCrashSite = "Frigate Crash Site";
        public const string OvergrownCavern = "Overgrown Cavern";
        public const string TransportTunnelC = "Transport Tunnel C";
        public const string TransporttoChozoRuinsEast = "Transport to Chozo Ruins East";
        public const string FrigateAccessTunnel = "Frigate Access Tunnel";
        public const string MainVentalationShaftSectionC = "Main Ventalation Shaft Section C";
        public const string MainVentalationShaftSectionB = "Main Ventalation Shaft Section B";
        public const string MainVentalationShaftSectionA = "Main Ventalation Shaft Section A";
        public const string ReactorCoare = "Reactor Coare";
        public const string ReactorAccess = "Reactor Access";
        public const string SaveStation = "Save Station";
        public const string CargoFreightLifttoDeckGamma = "Cargo Freight Lift to Deck Gamma";
        public const string DeckBetaTransitHall = "Deck Beta Transit Hall";
        public const string BiohazardContainment = "Biohazard Containment";
        public const string DeckBetaSecurityhall = "Deck Beta Security hall";
        public const string BiotechResearchArea1 = "Biotech Research Area 1";
        public const string DeckBetaConduitHall = "Deck Beta Conduit Hall";
        public const string ConnectionElevatortoDeckBeta = "Connection Elevator to Deck Beta";
        public const string HydroAccessTunnel = "Hydro Access Tunnel";
        public const string GreatTreeHall = "Great Tree Hall";
        public const string GreatTreeChamber = "Great Tree Chamber";
        public const string TransportTunnelD = "Transport Tunnel D";
        public const string TransporttoChozoRuinsSouth = "Transport to Chozo Ruins South";
        public const string LifeGroveTunnel = "Life Grove Tunnel";
        public const string LifeGrove = "Life Grove";
        public const string TransportTunnelE = "Transport Tunnel E";
        public const string TransporttoPhazonMinesEast = "Transport to Phazon Mines East";


        public Dictionary<String, Room> rooms = new Dictionary<string, Room>();

        public Rooms() {
            //Tallon's Rooms
            add(TallonOverworld, LandingSite);
            add(TallonOverworld, Alcove);
            add(TallonOverworld, TallonCanyon);
            add(TallonOverworld, RootTunnel);
            add(TallonOverworld, RootCave);
            add(TallonOverworld, ArborChamber);
            add(TallonOverworld, TransportTunnelB);
            add(TallonOverworld, TransporttoMagmoorCavernsEast);
            add(TallonOverworld, TransportTunnelA);
            add(TallonOverworld, TransporttoChozoRuinsWest);
            add(TallonOverworld, Gully);
            add(TallonOverworld, TempleHall);
            add(TallonOverworld, TempleSecurityStation);
            add(TallonOverworld, TempleLobby);
            add(TallonOverworld, ArtifactTemple);
            add(TallonOverworld, WaterfallCavern);
            add(TallonOverworld, FrigateCrashSite);
            add(TallonOverworld, OvergrownCavern);
            add(TallonOverworld, TransportTunnelC);
            add(TallonOverworld, TransporttoChozoRuinsEast);
            add(TallonOverworld, FrigateAccessTunnel);
            add(TallonOverworld, MainVentalationShaftSectionC);
            add(TallonOverworld, MainVentalationShaftSectionB);
            add(TallonOverworld, MainVentalationShaftSectionA);
            add(TallonOverworld, ReactorCoare);
            add(TallonOverworld, ReactorAccess);
            add(TallonOverworld, SaveStation);
            add(TallonOverworld, CargoFreightLifttoDeckGamma);
            add(TallonOverworld, DeckBetaTransitHall);
            add(TallonOverworld, BiohazardContainment);
            add(TallonOverworld, DeckBetaSecurityhall);
            add(TallonOverworld, BiotechResearchArea1);
            add(TallonOverworld, DeckBetaConduitHall);
            add(TallonOverworld, ConnectionElevatortoDeckBeta);
            add(TallonOverworld, HydroAccessTunnel);
            add(TallonOverworld, GreatTreeHall);
            add(TallonOverworld, GreatTreeChamber);
            add(TallonOverworld, TransportTunnelD);
            add(TallonOverworld, TransporttoChozoRuinsSouth);
            add(TallonOverworld, LifeGroveTunnel);
            add(TallonOverworld, LifeGrove);
            add(TallonOverworld, TransportTunnelE);
            add(TallonOverworld, TransporttoPhazonMinesEast);

        }

        private void add(string zone, string name) {
            rooms.Add(zone + "- " + name, new Room(zone, name));
        }

        public Room get(string zone, string name) {
            return rooms[zone + "-" + name];
        }

        public Room tallon(string name) {
            return get(TallonOverworld, name);
        }


    }
}
