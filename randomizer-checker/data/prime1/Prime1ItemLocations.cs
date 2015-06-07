using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;
using randomizer_checker.data;

namespace randomizer_checker.data.prime1 {
    class Prime1ItemLocations : ItemLocations {

        public const string Alcove = "Alcove";
        public const string LandingSite = "Landing Site";
        public const string ArtifactTemple = "Artifact Temple";
        public const string RootCave = "Root Cave";
        public const string ArborChamber = "Arbor Chamber";
        public const string TransportTunnelB = "Transport Tunnel B";
        public const string FrigateCrashSite = "Frigate Crash Site";
        public const string OvergrownCavern = "Overgrown Cavern";
        public const string CargoFreightLifttoDeckGamma = "Cargo Freight Lift to Deck Gamma";
        public const string BiohazardContainment = "Biohazard Containment";
        public const string HydroAccessTunnel = "Hydro Access Tunnel";
        public const string GreatTreeChamber = "Great Tree Chamber";
        public const string LifeGroveTunnel = "Life Grove Tunnel";
        public const string LifeGroveStart = "Life Grove (Start)";
        public const string LifeGroveSpinner = "Life Grove (Spinner)";


        public Prime1ItemLocations(Prime1Rooms rooms, Prime1Tricks tricks) : base() {

            //Tallon Item Locations
            add(Alcove);
            add(LandingSite);
            add(ArtifactTemple);
            add(RootCave);
            add(ArborChamber);
            add(TransportTunnelB);
            add(FrigateCrashSite);
            add(OvergrownCavern);
            add(CargoFreightLifttoDeckGamma);
            add(BiohazardContainment);
            add(HydroAccessTunnel);
            add(GreatTreeChamber);
            add(LifeGroveTunnel);
            add(LifeGroveStart);
            add(LifeGroveSpinner);

            //Add to respective rooms
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.Alcove)
                .addItem(get(Alcove));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.LandingSite)
                .addItem(get(LandingSite));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.ArtifactTemple)
                .addItem(get(ArtifactTemple));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.RootCave)
                .addItem(get(RootCave));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.ArborChamber)
                .addItem(get(ArborChamber));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.TransportTunnelB)
                .addItem(get(TransportTunnelB));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.FrigateCrashSite)
                .addItem(get(FrigateCrashSite));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.OvergrownCavern)
                .addItem(get(OvergrownCavern));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.CargoFreightLifttoDeckGamma)
                .addItem(get(CargoFreightLifttoDeckGamma));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.BiohazardContainment)
                .addItem(get(BiohazardContainment));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.HydroAccessTunnel)
                .addItem(get(HydroAccessTunnel));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.GreatTreeChamber)
                .addItem(get(GreatTreeChamber));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.LifeGroveTunnel)
                .addItem(get(LifeGroveTunnel));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.LifeGrove)
                .addItem(get(LifeGroveStart))
                .addItem(get(LifeGroveSpinner));
            rooms.get(Prime1Rooms.TallonOverworld, Prime1Rooms.TallonEastOOB)
                .addItem(get(LifeGroveSpinner)); //Obtainable oob

            //Tallon Item Location Requirements (NOT ROOM REQUIREMENTS)
            get(Alcove)
                .addExit(tricks.ghettoJump())
                .addExit(tricks.spaceJump())
                .addExit(tricks.doubleBombJump());
            get(LandingSite)
                .addEntry(tricks.morphBallTunnel())
                .addExit(tricks.morphBallTunnel());
            get(RootCave)
                .addEntry(tricks.doubleBombJump(), tricks.invisiblePlatforms(), tricks.grappleBeam())
                .addEntry(tricks.spaceJump(), tricks.invisiblePlatforms(), tricks.dashSJ());
            get(FrigateCrashSite)
                .addEntry(tricks.dash())
                .addEntry(tricks.ghettoJump());
            get(OvergrownCavern)
                .addEntry(tricks.morphBallTunnel())
                .addExit(tricks.morphBallTunnel());
            get(CargoFreightLifttoDeckGamma)
                .addEntry(tricks.missile());
            get(BiohazardContainment)
                .addEntry(tricks.superMissile());
            get(HydroAccessTunnel)
                .addEntry(tricks.morphBallPuzzleBombs());
            get(GreatTreeChamber)
                .addEntry(tricks.doubleBombJump(), tricks.invisiblePlatforms(), tricks.dash())
                .addEntry(tricks.invisiblePlatforms(), tricks.spaceJump());
            get(LifeGroveTunnel)
                .addEntry(tricks.morphBallPuzzleBombs(), tricks.multiBombJump(), tricks.halfPipeBombJump())
                .addEntry(tricks.morphBallPuzzleBombs(), tricks.halfPipeBoost());
            get(LifeGroveSpinner)
                .addEntry(tricks.powerBomb(), tricks.morphBallPuzzleBombs(), tricks.boostSpinnerNoBoost(), tricks.doubleBombJump(), tricks.dash())
                .addEntry(tricks.powerBomb(), tricks.morphBallPuzzleBombs(), tricks.boostSpinnerNoBoost(), tricks.spaceJump())
                .addEntry(tricks.powerBomb(), tricks.morphBallPuzzleBombs(), tricks.boostSpinner(), tricks.doubleBombJump(), tricks.dash())
                .addEntry(tricks.powerBomb(), tricks.morphBallPuzzleBombs(), tricks.boostSpinner(), tricks.spaceJump());
            
        }
    }
}
