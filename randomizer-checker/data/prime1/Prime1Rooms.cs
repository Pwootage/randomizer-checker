using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;
using randomizer_checker.data;

namespace randomizer_checker.data.prime1 {
    class Prime1Rooms : Rooms {
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
        public const string CanyonCavern = "Canyon Cavern";
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
        public const string ReactorCore = "Reactor Core";
        public const string ReactorAccess = "Reactor Access";
        public const string SaveStation = "Save Station";
        public const string CargoFreightLifttoDeckGamma = "Cargo Freight Lift to Deck Gamma";
        public const string DeckBetaTransitHall = "Deck Beta Transit Hall";
        public const string BiohazardContainment = "Biohazard Containment";
        public const string DeckBetaSecurityHall = "Deck Beta Security Hall";
        public const string BiotechResearchArea1 = "Biotech Research Area 1";
        public const string DeckBetaConduitHall = "Deck Beta Conduit Hall";
        public const string ConnectionElevatortoDeckBeta = "Connection Elevator to Deck Beta";
        public const string HydroAccessTunnel = "Hydro Access Tunnel";
        public const string GreatTreeHallUpper = "Great Tree Hall (Upper)";
        public const string GreatTreeHallLower = "Great Tree Hall (Lower)";
        public const string GreatTreeChamber = "Great Tree Chamber";
        public const string TransportTunnelD = "Transport Tunnel D";
        public const string TransporttoChozoRuinsSouth = "Transport to Chozo Ruins South";
        public const string LifeGroveTunnel = "Life Grove Tunnel";
        public const string LifeGrove = "Life Grove";
        public const string TransportTunnelE = "Transport Tunnel E";
        public const string TransporttoPhazonMinesEast = "Transport to Phazon Mines East";

        private Func<String, String, DoorType?> doorConverter;
        private Prime1Tricks tricks;

        public Prime1Rooms(Prime1Tricks tricks, Func<String, String, DoorType?> doorConverter) {
            this.doorConverter = doorConverter;
            this.tricks = tricks;
            //Tallon's Rooms
            add(TallonOverworld, LandingSite);
            add(TallonOverworld, Alcove);
            add(TallonOverworld, CanyonCavern);
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
            add(TallonOverworld, ReactorCore);
            add(TallonOverworld, ReactorAccess);
            add(TallonOverworld, SaveStation);
            add(TallonOverworld, CargoFreightLifttoDeckGamma);
            add(TallonOverworld, DeckBetaTransitHall);
            add(TallonOverworld, BiohazardContainment);
            add(TallonOverworld, DeckBetaSecurityHall);
            add(TallonOverworld, BiotechResearchArea1);
            add(TallonOverworld, DeckBetaConduitHall);
            add(TallonOverworld, ConnectionElevatortoDeckBeta);
            add(TallonOverworld, HydroAccessTunnel);
            add(TallonOverworld, GreatTreeHallUpper);
            add(TallonOverworld, GreatTreeHallLower);
            add(TallonOverworld, GreatTreeChamber);
            add(TallonOverworld, TransportTunnelD);
            add(TallonOverworld, TransporttoChozoRuinsSouth);
            add(TallonOverworld, LifeGroveTunnel);
            add(TallonOverworld, LifeGrove);
            add(TallonOverworld, TransportTunnelE);
            add(TallonOverworld, TransporttoPhazonMinesEast);

            //Exits 
            //Tallon's Exits
            //Doors
            //door(TallonOverworld, , , DoorType.BLUE);
            door(TallonOverworld, LandingSite, Gully, DoorType.BLUE, tricks.dash());
            door(TallonOverworld, LandingSite, Alcove, DoorType.BLUE, tricks.dash());
            door(TallonOverworld, LandingSite, TempleHall, DoorType.BLUE);
            door(TallonOverworld, LandingSite, CanyonCavern, DoorType.BLUE);
            door(TallonOverworld, LandingSite, WaterfallCavern, DoorType.BLUE);

            door(TallonOverworld, Alcove, LandingSite, DoorType.BLUE);

            door(TallonOverworld, TempleHall, LandingSite, DoorType.BLUE);
            door(TallonOverworld, TempleHall, TempleSecurityStation, DoorType.BLUE);

            door(TallonOverworld, CanyonCavern, LandingSite, DoorType.BLUE);
            door(TallonOverworld, CanyonCavern, TallonCanyon, DoorType.BLUE);

            door(TallonOverworld, Gully, LandingSite, DoorType.BLUE);
            door(TallonOverworld, Gully, TallonCanyon, DoorType.BLUE);

            door(TallonOverworld, WaterfallCavern, LandingSite, DoorType.BLUE);
            door(TallonOverworld, WaterfallCavern, FrigateCrashSite, DoorType.MISSILE);

            door(TallonOverworld, TallonCanyon, Gully, DoorType.BLUE, tricks.morphBallPuzzleBombs(), tricks.halfPipeBoost());
            door(TallonOverworld, TallonCanyon, TransportTunnelA, DoorType.BLUE);
            door(TallonOverworld, TallonCanyon, RootTunnel, DoorType.BLUE);
            door(TallonOverworld, TallonCanyon, CanyonCavern, DoorType.BLUE);

            door(TallonOverworld, RootTunnel, TallonCanyon, DoorType.BLUE);
            door(TallonOverworld, RootTunnel, RootCave, DoorType.MISSILE);

            door(TallonOverworld, RootCave, RootTunnel, DoorType.BLUE);
            door(TallonOverworld, RootCave, TransportTunnelB, DoorType.BLUE);
            door(TallonOverworld, RootCave, ArborChamber, DoorType.PLASMA, tricks.doubleBombJump(), tricks.invisiblePlatforms(), tricks.grappleBeam(), tricks.dash());
            door(TallonOverworld, RootCave, ArborChamber, DoorType.PLASMA, tricks.spaceJump(), tricks.invisiblePlatforms(), tricks.dashSJ());

            door(TallonOverworld, ArborChamber, RootCave, DoorType.BLUE);

            door(TallonOverworld, TransportTunnelA, TallonCanyon, DoorType.BLUE);
            door(TallonOverworld, TransportTunnelA, TransporttoChozoRuinsWest, DoorType.BLUE);

            door(TallonOverworld, TransportTunnelB, RootCave, DoorType.BLUE);
            door(TallonOverworld, TransportTunnelB, TransporttoMagmoorCavernsEast, DoorType.BLUE);

            door(TallonOverworld, TransporttoMagmoorCavernsEast, TransportTunnelB, DoorType.BLUE);

            door(TallonOverworld, TransporttoChozoRuinsWest, TransportTunnelA, DoorType.BLUE);

            door(TallonOverworld, FrigateCrashSite, WaterfallCavern, DoorType.ICE);
            door(TallonOverworld, FrigateCrashSite, OvergrownCavern, DoorType.ICE, tricks.dash(), tricks.multiBombJump(), tricks.ghettoJump(), tricks.morphBallTunnel());
            door(TallonOverworld, FrigateCrashSite, OvergrownCavern, DoorType.ICE, tricks.spaceJump(), tricks.ghettoSpaceJump(), tricks.morphBallTunnel());
            door(TallonOverworld, FrigateCrashSite, FrigateAccessTunnel, DoorType.ICE);

            door(TallonOverworld, OvergrownCavern, FrigateCrashSite, DoorType.ICE, tricks.morphBallTunnel());
            door(TallonOverworld, OvergrownCavern, TransportTunnelC, DoorType.ICE, tricks.morphBallTunnel());

            door(TallonOverworld, TransportTunnelC, OvergrownCavern, DoorType.ICE, tricks.morphBallTunnel());
            door(TallonOverworld, TransportTunnelC, TransporttoChozoRuinsEast, DoorType.ICE, tricks.morphBallTunnel());

            door(TallonOverworld, TransporttoChozoRuinsEast, TransportTunnelC, DoorType.ICE);

            door(TallonOverworld, TempleSecurityStation, TempleHall, DoorType.BLUE);
            door(TallonOverworld, TempleSecurityStation, TempleLobby, DoorType.MISSILE);

            door(TallonOverworld, TempleLobby, TempleSecurityStation, DoorType.BLUE);
            door(TallonOverworld, TempleLobby, ArtifactTemple, DoorType.BLUE);

            door(TallonOverworld, ArtifactTemple, TempleLobby, DoorType.BLUE);

            door(TallonOverworld, FrigateAccessTunnel, FrigateCrashSite, DoorType.ICE);
            door(TallonOverworld, FrigateAccessTunnel, MainVentalationShaftSectionC, DoorType.BLUE);

            door(TallonOverworld, MainVentalationShaftSectionC, FrigateAccessTunnel, DoorType.BLUE);
            door(TallonOverworld, MainVentalationShaftSectionC, MainVentalationShaftSectionB, DoorType.BLUE);

            door(TallonOverworld, MainVentalationShaftSectionB, MainVentalationShaftSectionC, DoorType.BLUE, tricks.wave());
            door(TallonOverworld, MainVentalationShaftSectionB, MainVentalationShaftSectionA, DoorType.BLUE, tricks.wave());

            door(TallonOverworld, MainVentalationShaftSectionA, MainVentalationShaftSectionB, DoorType.BLUE);
            door(TallonOverworld, MainVentalationShaftSectionA, ReactorCore, DoorType.BLUE);

            door(TallonOverworld, ReactorCore, MainVentalationShaftSectionA, DoorType.BLUE);
            door(TallonOverworld, ReactorCore, ReactorAccess, DoorType.BLUE, tricks.ghettoJump(), tricks.wave());

            door(TallonOverworld, ReactorAccess, ReactorCore, DoorType.BLUE);
            door(TallonOverworld, ReactorAccess, SaveStation, DoorType.BLUE);
            door(TallonOverworld, ReactorAccess, CargoFreightLifttoDeckGamma, DoorType.BLUE);

            door(TallonOverworld, SaveStation, ReactorAccess, DoorType.BLUE);

            door(TallonOverworld, CargoFreightLifttoDeckGamma, ReactorAccess, DoorType.BLUE);
            door(TallonOverworld, CargoFreightLifttoDeckGamma, DeckBetaTransitHall, DoorType.BLUE, tricks.infiniteBombJump(), tricks.wave());
            door(TallonOverworld, CargoFreightLifttoDeckGamma, DeckBetaTransitHall, DoorType.BLUE, tricks.boost(), tricks.ghettoJump(), tricks.wave());
            door(TallonOverworld, CargoFreightLifttoDeckGamma, DeckBetaTransitHall, DoorType.BLUE, tricks.spaceJump(), tricks.wave());

            door(TallonOverworld, DeckBetaTransitHall, CargoFreightLifttoDeckGamma, DoorType.BLUE);
            door(TallonOverworld, DeckBetaTransitHall, BiohazardContainment, DoorType.BLUE);

            door(TallonOverworld, BiohazardContainment, DeckBetaTransitHall, DoorType.BLUE);
            door(TallonOverworld, BiohazardContainment, DeckBetaSecurityHall, DoorType.BLUE, tricks.wave());

            door(TallonOverworld, DeckBetaSecurityHall, BiohazardContainment, DoorType.BLUE);
            door(TallonOverworld, DeckBetaSecurityHall, BiotechResearchArea1, DoorType.BLUE);

            door(TallonOverworld, BiotechResearchArea1, DeckBetaSecurityHall, DoorType.BLUE);
            door(TallonOverworld, BiotechResearchArea1, DeckBetaConduitHall, DoorType.BLUE, tricks.wave());

            door(TallonOverworld, DeckBetaConduitHall, BiotechResearchArea1, DoorType.BLUE);
            door(TallonOverworld, DeckBetaConduitHall, ConnectionElevatortoDeckBeta, DoorType.BLUE);

            door(TallonOverworld, ConnectionElevatortoDeckBeta, DeckBetaConduitHall, DoorType.BLUE, tricks.spaceJump(), tricks.gravity());
            door(TallonOverworld, ConnectionElevatortoDeckBeta, DeckBetaConduitHall, DoorType.BLUE, tricks.doubleBombJump(), tricks.gravity());
            door(TallonOverworld, ConnectionElevatortoDeckBeta, HydroAccessTunnel, DoorType.BLUE);

            door(TallonOverworld, HydroAccessTunnel, ConnectionElevatortoDeckBeta, DoorType.BLUE, tricks.infiniteBoost());
            door(TallonOverworld, HydroAccessTunnel, ConnectionElevatortoDeckBeta, DoorType.BLUE, tricks.morphBallPuzzleBombs(), tricks.gravity());
            door(TallonOverworld, HydroAccessTunnel, GreatTreeHallLower, DoorType.BLUE, tricks.infiniteBoost());
            door(TallonOverworld, HydroAccessTunnel, GreatTreeHallLower, DoorType.BLUE, tricks.morphBallPuzzleBombs(), tricks.gravity());

            //GTH is two parts: upper and lower (since there is a complex transition)
            door(TallonOverworld, GreatTreeHallLower, HydroAccessTunnel, DoorType.BLUE);
            door(TallonOverworld, GreatTreeHallLower, TransportTunnelE, DoorType.ICE);
            door(TallonOverworld, GreatTreeHallLower, GreatTreeHallUpper, DoorType.BLUE, tricks.boost(), tricks.doubleBombJump(), tricks.dash());
            door(TallonOverworld, GreatTreeHallLower, GreatTreeHallUpper, DoorType.BLUE, tricks.boost(), tricks.spaceJump());

            door(TallonOverworld, GreatTreeHallUpper, GreatTreeHallLower, DoorType.BLUE, tricks.doubleBombJump());
            door(TallonOverworld, GreatTreeHallUpper, GreatTreeChamber, DoorType.BLUE, tricks.doubleBombJump(), tricks.dash(), tricks.invisiblePlatforms());
            door(TallonOverworld, GreatTreeHallUpper, GreatTreeChamber, DoorType.BLUE, tricks.spaceJump(), tricks.invisiblePlatforms());
            door(TallonOverworld, GreatTreeHallUpper, TransportTunnelD, DoorType.ICE);
            door(TallonOverworld, GreatTreeHallUpper, LifeGroveTunnel, DoorType.ICE, tricks.doubleBombJump(), tricks.dash(), tricks.spider(), tricks.powerBomb());
            door(TallonOverworld, GreatTreeHallUpper, LifeGroveTunnel, DoorType.ICE, tricks.spaceJump(), tricks.powerBomb());

            door(TallonOverworld, LifeGroveTunnel, GreatTreeHallUpper, DoorType.ICE, tricks.boost());
            door(TallonOverworld, LifeGroveTunnel, GreatTreeHallUpper, DoorType.ICE, tricks.halfPipeBombJump(), tricks.multiBombJump());
            door(TallonOverworld, LifeGroveTunnel, LifeGrove, DoorType.BLUE, tricks.boost());
            door(TallonOverworld, LifeGroveTunnel, LifeGrove, DoorType.BLUE, tricks.halfPipeBombJump(), tricks.multiBombJump());

            door(TallonOverworld, LifeGrove, LifeGroveTunnel, DoorType.BLUE, tricks.doubleBombJump(), tricks.dash(), tricks.powerBomb(), tricks.morphBallPuzzleBombs());
            door(TallonOverworld, LifeGrove, LifeGroveTunnel, DoorType.BLUE, tricks.spaceJump());

            door(TallonOverworld, TransportTunnelE, GreatTreeHallLower, DoorType.ICE);
            door(TallonOverworld, TransportTunnelE, TransporttoPhazonMinesEast, DoorType.ICE);
            door(TallonOverworld, TransporttoPhazonMinesEast, TransportTunnelE, DoorType.ICE);

            door(TallonOverworld, GreatTreeChamber, GreatTreeHallUpper, DoorType.BLUE);

            door(TallonOverworld, TransportTunnelD, GreatTreeHallUpper, DoorType.ICE);
            door(TallonOverworld, TransportTunnelD, TransporttoChozoRuinsSouth, DoorType.ICE);

            door(TallonOverworld, TransporttoChozoRuinsSouth, TransportTunnelD, DoorType.ICE);
        }

        public Room tallon(string name) {
            return get(TallonOverworld, name);
        }

        private DoorType getDoorType(string roomA, string roomB, DoorType defaultType) {
            return doorConverter(roomA, roomB).GetValueOrDefault(defaultType);
        }

        private void door(string zone, string roomA, string roomB, DoorType aToB, string desc, string docUrl, params Trick[] doorAccessTricks) {
            Exit ab = new Exit(get(zone, roomB))
                .addTrick(tricks.door(aToB).setUrl(docUrl).setDesc(desc));
            foreach (Trick t in doorAccessTricks)
                ab.addTrick(t);
            get(zone, roomA).addExit(ab);
        }

        private void door(string zone, string roomA, string roomB, DoorType aToB, params Trick[] doorAccessTricks) {
            door(zone, roomA, roomB, aToB, null, null, doorAccessTricks);
        }
    }
}
