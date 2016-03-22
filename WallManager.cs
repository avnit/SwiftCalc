using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcousticalModeling
{
    public class WallManager
    {
        public Materials ConcreteTile = new Materials("Concrete/ Tile", .01,  .01, .015, .02, .02, .02);

        public Materials WoodOnJoists = new Materials("Wood On Joists", .15,.11,.1,.07,.06,.07);

        public Materials CarpetOnConcrete = new Materials("Carpet On Concrete",.02,.06,.14,.37,.6,.65);

        public Materials CarpetOnFoam = new Materials("Carpet On Foam",.08,.24,.57,.69,.71,.73);

        public Materials UnglazedBrick = new Materials("Unglzazed Brick",.03,.03,.03,.01,.05,.07);

        public Materials UnglazedPaintedBrick = new Materials("Unglazed Painted Brick",.01,.01,.02,.02,.02,.03);

        public Materials Glass = new Materials("Glass",.18,.06,.04,.03,.02,.02);

        public Materials MarbleTile = new Materials("Marble Tile",.01,.01,.01,.01,.02,.02);

        public Materials PlywoodPanel38= new Materials("3/8'' Plywood Panel",.28,.22,.17,.09,.1,.11);

        public Materials  AcousticalCeiling = new Materials("Acoustic Ceiling Tile",.05,.22,.52,.56,.45,.32);

        public Materials PlasterLime = new Materials("Plaster, Lime",.02,.03,.01,.05,.04,.03);

        public Materials[] Coefficients = new Materials[11];
        public WallManager()
        {
            Coefficients = new Materials[11] {ConcreteTile, WoodOnJoists, CarpetOnConcrete, CarpetOnFoam, UnglazedBrick, UnglazedPaintedBrick, Glass, MarbleTile, PlywoodPanel38, AcousticalCeiling, PlasterLime };
        }

        /* Wall WallOne = new Wall();
         Wall WallTwo = new Wall();
         Wall WallThree = new Wall();
         Wall WallFour = new Wall();
         Wall WallFive = new Wall();
         Wall WallSix = new Wall();*/

    }
}
