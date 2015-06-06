using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;
using randomizer_checker.data;

namespace randomizer_checker.data.prime1 {
    class Prime1Items : Items {
        public const string MissileExpansion = "Missile Expansion";
        public const string EnergyTank = "Energy Tank";
        public const string PowerBombExpansion = "Power Bomb Expansion";
        public const string Artifact = "Artifact";
        public const string MorphBall = "Morph Ball";
        public const string MorphBallBombs = "Morph Ball Bombs";
        public const string WaveBeam = "Wave Beam";
        public const string IceBeam = "Ice Beam";
        public const string PlasmaBeam = "Plasma Beam";
        public const string ChargeBeam = "Charge Beam";
        public const string SuperMissiles = "Super Missiles";
        public const string Wavebuster = "Wavebuster";
        public const string IceSpreader = "Ice Spreader";
        public const string Flamethrower = "Flamethrower";
        public const string SpaceJump = "Space Jump";
        public const string ThermalVisor = "Thermal Visor";
        public const string XRayVisor = "X-Ray Visor";
        public const string BoostBall = "Boost Ball";
        public const string SpiderBall = "Spider Ball";
        public const string GrappleBeam = "Grapple Beam";
        public const string VariaSuit = "Varia Suit";
        public const string GravitySuit = "Gravity Suit";
        public const string PhazonSuit = "Phazon Suit";

        public Prime1Items() {
            //Prime 1 item list
            add(MissileExpansion);
            add(EnergyTank);
            add(PowerBombExpansion);
            add(Artifact);
            add(MorphBall);
            add(MorphBallBombs);
            add(WaveBeam);
            add(IceBeam);
            add(PlasmaBeam);
            add(ChargeBeam);
            add(SuperMissiles);
            add(Wavebuster);
            add(IceSpreader);
            add(Flamethrower);
            add(SpaceJump);
            add(ThermalVisor);
            add(XRayVisor);
            add(BoostBall);
            add(SpiderBall);
            add(GrappleBeam);
            add(VariaSuit);
            add(GravitySuit);
            add(PhazonSuit);

            //Set counts as needed
            get(MissileExpansion).setCount(50);
            get(EnergyTank).setCount(14);
            get(PowerBombExpansion).setCount(5);
            get(Artifact).setCount(12);
        }
    }
}
