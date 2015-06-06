using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomizer_checker.model;
using randomizer_checker.data;

namespace randomizer_checker.data.prime1 {
    public enum DoorType {
        BLUE,
        MISSILE,
        WAVE,
        ICE,
        PLASMA
    }
    /// <summary>
    /// This class is a factory to leave room for per-trick customization later
    /// </summary>
    class Prime1Tricks {
        public const string MorphBallTunnel = "Morph Ball Tunnel";
        public const string MorphBallPuzzle = "Morph Ball Puzzle";
        public const string Dash = "Dash";
        public const string HalfPipeBoost = "Half Pipe (Boost Ball)";
        public const string GhettoJump = "Ghetto Jump";
        public const string Door = "Door";
        public const string SpaceJump = "Space Jump";
        public const string DoubleBombJump = "Double Bomb Jump";
        public const string MultiBombJump = "Multi-Bomb Jump";
        public const string HalfPipeBombJump = "Half Pipe Bomb Jump";
        public const string InvisiblePlatforms = "Invisible Platforms";
        public const string GrappleBeam = "Grapple Beam";
        public const string Missile = "Missile";
        public const string SuperMissile = "Super Missile";
        public const string BoostSpinner = "Boost Spinner";
        public const string BoostSpinnerNoBoost = "Boost Spinner (without Boost Ball)";
        public const string PowerBomb = "Power Bomb";
        public const string WaveBeam = "Wave Beam";
        public const string IceBeam = "Ice Beam";
        public const string PlasmaBeam = "Plasma Beam";
        public const string InfiniteBombJump = "InfiniteBombJump";
        public const string BoostBall = "Boost Ball";
        public const string InfiniteBoost = "Infinite Boost";
        public const string FloatyJump = "Floaty Jump";
        public const string GraivtySuit = "Graivty Suit";
        public const string SpiderBall = "Spider Ball";

        private Prime1Items items;

        public Prime1Tricks(Prime1Items items) {
            this.items = items;
        }

        public Trick morphBallTunnel() {
            return new Trick(MorphBallTunnel)
                .addRequiredItem(items.get(Prime1Items.MorphBall));
        }

        public Trick morphBallPuzzleBombs() {
            return new Trick(MorphBallPuzzle)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.MorphBallBombs));
        }

        public Trick dash() {
            return new Trick(Dash);
        }

        public Trick dashSJ() {
            return new Trick(Dash)
                .addRequiredItem(items.get(Prime1Items.SpaceJump));
        }

        public Trick spaceJump() {
            return new Trick(SpaceJump)
                .addRequiredItem(items.get(Prime1Items.SpaceJump));
        }

        public Trick halfPipeBoost() {
            return new Trick(HalfPipeBoost)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.BoostBall));
        }

        public Trick doubleBombJump() {
            return new Trick(DoubleBombJump)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.MorphBallBombs));
        }

        public Trick multiBombJump() {
            return new Trick(MultiBombJump)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.MorphBallBombs));
        }

        public Trick halfPipeBombJump() {
            return new Trick(HalfPipeBombJump)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.MorphBallBombs));
        }

        public Trick ghettoJump() {
            return new Trick(GhettoJump);
        }

        public Trick ghettoSpaceJump() {
            return new Trick(GhettoJump)
                .addRequiredItem(items.get(Prime1Items.SpaceJump));
        }

        public Trick invisiblePlatforms() {
            return new Trick(InvisiblePlatforms);
        }

        public Trick grappleBeam() {
            return new Trick(GrappleBeam)
                .addRequiredItem(items.get(Prime1Items.GrappleBeam));
        }

        public Trick missile() {
            return new Trick(Missile)
                .addRequiredItem(items.get(Prime1Items.MissileExpansion));
        }

        public Trick superMissile() {
            return new Trick(SuperMissile)
                .addRequiredItem(items.get(Prime1Items.MissileExpansion))
                .addRequiredItem(items.get(Prime1Items.SuperMissiles))
                .addRequiredItem(items.get(Prime1Items.ChargeBeam));
        }

        public Trick boostSpinner() {
            return new Trick(BoostSpinner)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.BoostBall));
        }

        public Trick boostSpinnerNoBoost() {
            return new Trick(BoostSpinnerNoBoost)
                .addRequiredItem(items.get(Prime1Items.MorphBall));
        }

        public Trick powerBomb() {
            return new Trick(PowerBomb)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.PowerBombExpansion));
        }

        public Trick wave() {
            return new Trick(WaveBeam)
                .addRequiredItem(items.get(Prime1Items.WaveBeam));
        }

        public Trick ice() {
            return new Trick(IceBeam)
                .addRequiredItem(items.get(Prime1Items.IceBeam));
        }

        public Trick plasma() {
            return new Trick(PlasmaBeam)
                .addRequiredItem(items.get(Prime1Items.PlasmaBeam));
        }

        public Trick boost() {
            return new Trick(BoostBall)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.BoostBall));
        }

        public Trick infiniteBombJump() {
            return new Trick(InfiniteBombJump)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.MorphBallBombs))
                .addDisallowedItem(items.get(Prime1Items.GravitySuit));
        }

        public Trick floatyJumpChozo() {
            return new Trick(FloatyJump)
                .addDisallowedItem(items.get(Prime1Items.GravitySuit));
        }

        public Trick gravity() {
            return new Trick(GraivtySuit)
                .addRequiredItem(items.get(Prime1Items.GravitySuit));
        }

        public Trick infiniteBoost() {
            return new Trick(InfiniteBoost)
                .addRequiredItem(items.get(Prime1Items.BoostBall));
        }

        public Trick spider() {
            return new Trick(SpiderBall)
                .addRequiredItem(items.get(Prime1Items.MorphBall))
                .addRequiredItem(items.get(Prime1Items.SpiderBall));
        }

        public Trick door(DoorType type) {
            Trick res = new Trick(Door);
            switch (type) {
                case DoorType.BLUE:
                    break;
                case DoorType.MISSILE:
                    res.addRequiredItem(items.get(Prime1Items.MissileExpansion));
                    break;
                case DoorType.WAVE:
                    res.addRequiredItem(items.get(Prime1Items.WaveBeam));
                    break;
                case DoorType.ICE:
                    res.addRequiredItem(items.get(Prime1Items.IceBeam));
                    break;
                case DoorType.PLASMA:
                    res.addRequiredItem(items.get(Prime1Items.PlasmaBeam));
                    break;
            }
            return res;
        }

    }
}
