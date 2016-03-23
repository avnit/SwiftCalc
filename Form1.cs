using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcousticalModeling
{
    public partial class Form1 : Form
    {
        public WallManager WallM = new WallManager();
        WallMaterials wall1Mat = new WallMaterials();
        bool TileConcrete = false;
        bool WoodOnJoists = false;
        bool CarpetOnConcrete = false;
        bool CarpetOnFoam = false;
        bool UnglazedBrick = false;
        bool UnglazedPaintedBrick = false;
        bool Glass = false;
        bool MarbleTile = false;
        bool PlywoodPanel = false;
        bool AcousticCeilingTiles = false;
        bool RoughPlasterOnLath = false;

        int numRowsFilled = 0;

        Wall[] Walls = new Wall[6];
        double[] WallOneCoef = new double[6];
        double[] WallTwoCoef = new double[6];
        double[] WallThreeCoef = new double[6];
        double[] WallFourCoef = new double[6];
        double[] WallFiveCoef = new double[6];
        double[] WallSixCoef = new double[6];
        public double[][] global = new double[6][];


        List<Materials> SelectMaterials = new List<Materials>();
        public Form1()
        {
            InitializeComponent();
            Walls[0] = new Wall();
            Walls[1] = new Wall();
            Walls[2] = new Wall();
            Walls[3] = new Wall();
            Walls[4] = new Wall();
            Walls[5] = new Wall();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WallMaterials WallOne = new WallMaterials();
            //WallOne.Show();
        }

        public double[] material(string materialInput, double[] values)
        {
            double[] mv = new double[6];

            //  Walls[1].SetMaterial(WallM.ConcreteTile);
            return mv;
            // WallTwoCoef = new double[] { WallM.Coefficients[0]._htz125, WallM.Coefficients[0]._htz250, WallM.Coefficients[0]._htz500, WallM.Coefficients[0]._htz1k, WallM.Coefficients[0]._htz2k, WallM.Coefficients[0]._htz4k };
        }


        private void button2_Click(object sender, EventArgs e)
        {
            numRowsFilled += 0;
            if (TileConcrete == true)
            {
                Walls[1].SetMaterial(WallM.ConcreteTile);

                WallTwoCoef = new double[] { WallM.Coefficients[0]._htz125, WallM.Coefficients[0]._htz250, WallM.Coefficients[0]._htz500, WallM.Coefficients[0]._htz1k, WallM.Coefficients[0]._htz2k, WallM.Coefficients[0]._htz4k };
            }

            if (WoodOnJoists == true)
            {
                Walls[1].SetMaterial(WallM.WoodOnJoists);

                WallTwoCoef = new double[] { WallM.Coefficients[1]._htz125, WallM.Coefficients[1]._htz250, WallM.Coefficients[1]._htz500, WallM.Coefficients[1]._htz1k, WallM.Coefficients[1]._htz2k, WallM.Coefficients[1]._htz4k };
            }

            if (CarpetOnConcrete == true)
            {
                Walls[1].SetMaterial(WallM.CarpetOnConcrete);

                WallTwoCoef = new double[] { WallM.Coefficients[2]._htz125, WallM.Coefficients[2]._htz250, WallM.Coefficients[2]._htz500, WallM.Coefficients[2]._htz1k, WallM.Coefficients[2]._htz2k, WallM.Coefficients[2]._htz4k };
            }

            if (CarpetOnFoam == true)
            {
                Walls[1].SetMaterial(WallM.CarpetOnFoam);

                WallTwoCoef = new double[] { WallM.Coefficients[3]._htz125, WallM.Coefficients[3]._htz250, WallM.Coefficients[3]._htz500, WallM.Coefficients[3]._htz1k, WallM.Coefficients[3]._htz2k, WallM.Coefficients[3]._htz4k };
            }

            if (UnglazedBrick == true)
            {
                Walls[1].SetMaterial(WallM.UnglazedBrick);

                WallTwoCoef = new double[] { WallM.Coefficients[4]._htz125, WallM.Coefficients[4]._htz250, WallM.Coefficients[4]._htz500, WallM.Coefficients[4]._htz1k, WallM.Coefficients[4]._htz2k, WallM.Coefficients[4]._htz4k };
            }

            if (UnglazedPaintedBrick == true)
            {
                Walls[1].SetMaterial(WallM.UnglazedPaintedBrick);

                WallTwoCoef = new double[] { WallM.Coefficients[5]._htz125, WallM.Coefficients[5]._htz250, WallM.Coefficients[5]._htz500, WallM.Coefficients[5]._htz1k, WallM.Coefficients[5]._htz2k, WallM.Coefficients[5]._htz4k };
            }

            if (Glass == true)
            {
                Walls[1].SetMaterial(WallM.Glass);

                WallTwoCoef = new double[] { WallM.Coefficients[6]._htz125, WallM.Coefficients[6]._htz250, WallM.Coefficients[6]._htz500, WallM.Coefficients[6]._htz1k, WallM.Coefficients[6]._htz2k, WallM.Coefficients[6]._htz4k };
            }

            if (MarbleTile == true)
            {
                Walls[1].SetMaterial(WallM.MarbleTile);

                WallTwoCoef = new double[] { WallM.Coefficients[7]._htz125, WallM.Coefficients[7]._htz250, WallM.Coefficients[7]._htz500, WallM.Coefficients[7]._htz1k, WallM.Coefficients[7]._htz2k, WallM.Coefficients[7]._htz4k };
            }

            if (PlywoodPanel == true)
            {
                Walls[1].SetMaterial(WallM.PlywoodPanel38);

                WallTwoCoef = new double[] { WallM.Coefficients[8]._htz125, WallM.Coefficients[8]._htz250, WallM.Coefficients[8]._htz500, WallM.Coefficients[8]._htz1k, WallM.Coefficients[8]._htz2k, WallM.Coefficients[8]._htz4k };
            }

            if (AcousticCeilingTiles == true)
            {
                Walls[1].SetMaterial(WallM.AcousticalCeiling);

                WallTwoCoef = new double[] { WallM.Coefficients[9]._htz125, WallM.Coefficients[9]._htz250, WallM.Coefficients[9]._htz500, WallM.Coefficients[9]._htz1k, WallM.Coefficients[9]._htz2k, WallM.Coefficients[9]._htz4k };
            }

            if (RoughPlasterOnLath == true)
            {
                Walls[1].SetMaterial(WallM.PlasterLime);

                WallTwoCoef = new double[] { WallM.Coefficients[10]._htz125, WallM.Coefficients[10]._htz250, WallM.Coefficients[10]._htz500, WallM.Coefficients[10]._htz1k, WallM.Coefficients[10]._htz2k, WallM.Coefficients[10]._htz4k };
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TileConcrete == true)
            {
                Walls[2].SetMaterial(WallM.ConcreteTile);

                WallThreeCoef = new double[] { WallM.Coefficients[0]._htz125, WallM.Coefficients[0]._htz250, WallM.Coefficients[0]._htz500, WallM.Coefficients[0]._htz1k, WallM.Coefficients[0]._htz2k, WallM.Coefficients[0]._htz4k };
            }

            if (WoodOnJoists == true)
            {
                Walls[2].SetMaterial(WallM.WoodOnJoists);
                WallThreeCoef = new double[] { WallM.Coefficients[1]._htz125, WallM.Coefficients[1]._htz250, WallM.Coefficients[1]._htz500, WallM.Coefficients[1]._htz1k, WallM.Coefficients[1]._htz2k, WallM.Coefficients[1]._htz4k };
            }

            if (CarpetOnConcrete == true)
            {
                Walls[2].SetMaterial(WallM.CarpetOnConcrete);
                WallThreeCoef = new double[] { WallM.Coefficients[2]._htz125, WallM.Coefficients[2]._htz250, WallM.Coefficients[2]._htz500, WallM.Coefficients[2]._htz1k, WallM.Coefficients[2]._htz2k, WallM.Coefficients[2]._htz4k };
            }

            if (CarpetOnFoam == true)
            {
                Walls[2].SetMaterial(WallM.CarpetOnFoam);
                WallThreeCoef = new double[] { WallM.Coefficients[3]._htz125, WallM.Coefficients[3]._htz250, WallM.Coefficients[3]._htz500, WallM.Coefficients[3]._htz1k, WallM.Coefficients[3]._htz2k, WallM.Coefficients[3]._htz4k };
            }

            if (UnglazedBrick == true)
            {
                Walls[2].SetMaterial(WallM.UnglazedBrick);
                WallThreeCoef = new double[] { WallM.Coefficients[4]._htz125, WallM.Coefficients[4]._htz250, WallM.Coefficients[4]._htz500, WallM.Coefficients[4]._htz1k, WallM.Coefficients[4]._htz2k, WallM.Coefficients[4]._htz4k };
            }


            if (UnglazedPaintedBrick == true)
            {
                Walls[2].SetMaterial(WallM.UnglazedPaintedBrick);
                WallThreeCoef = new double[] { WallM.Coefficients[5]._htz125, WallM.Coefficients[5]._htz250, WallM.Coefficients[5]._htz500, WallM.Coefficients[5]._htz1k, WallM.Coefficients[5]._htz2k, WallM.Coefficients[5]._htz4k };
            }

            if (Glass == true)
            {
                Walls[2].SetMaterial(WallM.Glass);
                WallThreeCoef = new double[] { WallM.Coefficients[6]._htz125, WallM.Coefficients[6]._htz250, WallM.Coefficients[6]._htz500, WallM.Coefficients[6]._htz1k, WallM.Coefficients[6]._htz2k, WallM.Coefficients[6]._htz4k };
            }

            if (MarbleTile == true)
            {
                Walls[2].SetMaterial(WallM.MarbleTile);
                WallThreeCoef = new double[] { WallM.Coefficients[7]._htz125, WallM.Coefficients[7]._htz250, WallM.Coefficients[7]._htz500, WallM.Coefficients[7]._htz1k, WallM.Coefficients[7]._htz2k, WallM.Coefficients[7]._htz4k };
            }

            if (PlywoodPanel == true)
            {
                Walls[2].SetMaterial(WallM.PlywoodPanel38);
                WallThreeCoef = new double[] { WallM.Coefficients[8]._htz125, WallM.Coefficients[8]._htz250, WallM.Coefficients[8]._htz500, WallM.Coefficients[8]._htz1k, WallM.Coefficients[8]._htz2k, WallM.Coefficients[8]._htz4k };
            }

            if (AcousticCeilingTiles == true)
            {
                Walls[2].SetMaterial(WallM.AcousticalCeiling);
                WallThreeCoef = new double[] { WallM.Coefficients[9]._htz125, WallM.Coefficients[9]._htz250, WallM.Coefficients[9]._htz500, WallM.Coefficients[9]._htz1k, WallM.Coefficients[9]._htz2k, WallM.Coefficients[9]._htz4k };
            }

            if (RoughPlasterOnLath == true)
            {
                Walls[2].SetMaterial(WallM.PlasterLime);
                WallThreeCoef = new double[] { WallM.Coefficients[10]._htz125, WallM.Coefficients[10]._htz250, WallM.Coefficients[10]._htz500, WallM.Coefficients[10]._htz1k, WallM.Coefficients[10]._htz2k, WallM.Coefficients[10]._htz4k };

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TileConcrete == true)
            {
                Walls[3].SetMaterial(WallM.ConcreteTile);
                WallFourCoef = new double[] { WallM.Coefficients[0]._htz125, WallM.Coefficients[0]._htz250, WallM.Coefficients[0]._htz500, WallM.Coefficients[0]._htz1k, WallM.Coefficients[0]._htz2k, WallM.Coefficients[0]._htz4k };
            }

            if (WoodOnJoists == true)
            {
                Walls[3].SetMaterial(WallM.WoodOnJoists);
                WallFourCoef = new double[] { WallM.Coefficients[1]._htz125, WallM.Coefficients[1]._htz250, WallM.Coefficients[1]._htz500, WallM.Coefficients[1]._htz1k, WallM.Coefficients[1]._htz2k, WallM.Coefficients[1]._htz4k };
            }

            if (CarpetOnConcrete == true)
            {
                Walls[3].SetMaterial(WallM.CarpetOnConcrete);
                WallFourCoef = new double[] { WallM.Coefficients[2]._htz125, WallM.Coefficients[2]._htz250, WallM.Coefficients[2]._htz500, WallM.Coefficients[2]._htz1k, WallM.Coefficients[2]._htz2k, WallM.Coefficients[2]._htz4k };
            }


            if (UnglazedPaintedBrick == true)
            {
                Walls[3].SetMaterial(WallM.UnglazedPaintedBrick);
                WallFourCoef = new double[] { WallM.Coefficients[5]._htz125, WallM.Coefficients[5]._htz250, WallM.Coefficients[5]._htz500, WallM.Coefficients[5]._htz1k, WallM.Coefficients[5]._htz2k, WallM.Coefficients[5]._htz4k };
            }

            if (Glass == true)
            {
                Walls[3].SetMaterial(WallM.Glass);
                WallFourCoef = new double[] { WallM.Coefficients[6]._htz125, WallM.Coefficients[6]._htz250, WallM.Coefficients[6]._htz500, WallM.Coefficients[6]._htz1k, WallM.Coefficients[6]._htz2k, WallM.Coefficients[6]._htz4k };
            }

            if (MarbleTile == true)
            {
                Walls[3].SetMaterial(WallM.MarbleTile);
                WallFourCoef = new double[] { WallM.Coefficients[7]._htz125, WallM.Coefficients[7]._htz250, WallM.Coefficients[7]._htz500, WallM.Coefficients[7]._htz1k, WallM.Coefficients[7]._htz2k, WallM.Coefficients[7]._htz4k };
            }

            if (PlywoodPanel == true)
            {
                Walls[3].SetMaterial(WallM.PlywoodPanel38);
                WallFourCoef = new double[] { WallM.Coefficients[8]._htz125, WallM.Coefficients[8]._htz250, WallM.Coefficients[8]._htz500, WallM.Coefficients[8]._htz1k, WallM.Coefficients[8]._htz2k, WallM.Coefficients[8]._htz4k };
            }

            if (AcousticCeilingTiles == true)
            {
                Walls[3].SetMaterial(WallM.AcousticalCeiling);
                WallFourCoef = new double[] { WallM.Coefficients[9]._htz125, WallM.Coefficients[9]._htz250, WallM.Coefficients[9]._htz500, WallM.Coefficients[9]._htz1k, WallM.Coefficients[9]._htz2k, WallM.Coefficients[9]._htz4k };
            }

            if (RoughPlasterOnLath == true)
            {
                Walls[3].SetMaterial(WallM.PlasterLime);
                WallFourCoef = new double[] { WallM.Coefficients[10]._htz125, WallM.Coefficients[10]._htz250, WallM.Coefficients[10]._htz500, WallM.Coefficients[10]._htz1k, WallM.Coefficients[10]._htz2k, WallM.Coefficients[10]._htz4k };
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (TileConcrete == true)
            {
                Walls[4].SetMaterial(WallM.ConcreteTile);
                WallFiveCoef = new double[] { WallM.Coefficients[0]._htz125, WallM.Coefficients[0]._htz250, WallM.Coefficients[0]._htz500, WallM.Coefficients[0]._htz1k, WallM.Coefficients[0]._htz2k, WallM.Coefficients[0]._htz4k };
            }

            if (WoodOnJoists == true)
            {
                Walls[4].SetMaterial(WallM.WoodOnJoists);
                WallFiveCoef = new double[] { WallM.Coefficients[1]._htz125, WallM.Coefficients[1]._htz250, WallM.Coefficients[1]._htz500, WallM.Coefficients[1]._htz1k, WallM.Coefficients[1]._htz2k, WallM.Coefficients[1]._htz4k };
            }

            if (CarpetOnConcrete == true)
            {
                Walls[4].SetMaterial(WallM.CarpetOnConcrete);
                WallFiveCoef = new double[] { WallM.Coefficients[2]._htz125, WallM.Coefficients[2]._htz250, WallM.Coefficients[2]._htz500, WallM.Coefficients[2]._htz1k, WallM.Coefficients[2]._htz2k, WallM.Coefficients[2]._htz4k };
            }

            if (CarpetOnFoam == true)
            {
                Walls[4].SetMaterial(WallM.CarpetOnFoam);
                WallFiveCoef = new double[] { WallM.Coefficients[3]._htz125, WallM.Coefficients[3]._htz250, WallM.Coefficients[3]._htz500, WallM.Coefficients[3]._htz1k, WallM.Coefficients[3]._htz2k, WallM.Coefficients[3]._htz4k };
            }

            if (UnglazedBrick == true)
            {
                Walls[4].SetMaterial(WallM.UnglazedBrick);
                WallFiveCoef = new double[] { WallM.Coefficients[4]._htz125, WallM.Coefficients[4]._htz250, WallM.Coefficients[4]._htz500, WallM.Coefficients[4]._htz1k, WallM.Coefficients[4]._htz2k, WallM.Coefficients[4]._htz4k };
            }


            if (UnglazedPaintedBrick == true)
            {
                Walls[4].SetMaterial(WallM.UnglazedPaintedBrick);
                WallFiveCoef = new double[] { WallM.Coefficients[5]._htz125, WallM.Coefficients[5]._htz250, WallM.Coefficients[5]._htz500, WallM.Coefficients[5]._htz1k, WallM.Coefficients[5]._htz2k, WallM.Coefficients[5]._htz4k };
            }

            if (Glass == true)
            {
                Walls[4].SetMaterial(WallM.Glass);
                WallFiveCoef = new double[] { WallM.Coefficients[6]._htz125, WallM.Coefficients[6]._htz250, WallM.Coefficients[6]._htz500, WallM.Coefficients[6]._htz1k, WallM.Coefficients[6]._htz2k, WallM.Coefficients[6]._htz4k };
            }

            if (MarbleTile == true)
            {
                Walls[4].SetMaterial(WallM.MarbleTile);
                WallFiveCoef = new double[] { WallM.Coefficients[7]._htz125, WallM.Coefficients[7]._htz250, WallM.Coefficients[7]._htz500, WallM.Coefficients[7]._htz1k, WallM.Coefficients[7]._htz2k, WallM.Coefficients[7]._htz4k };
            }

            if (PlywoodPanel == true)
            {
                Walls[4].SetMaterial(WallM.PlywoodPanel38);
                WallFiveCoef = new double[] { WallM.Coefficients[8]._htz125, WallM.Coefficients[8]._htz250, WallM.Coefficients[8]._htz500, WallM.Coefficients[8]._htz1k, WallM.Coefficients[8]._htz2k, WallM.Coefficients[8]._htz4k };
            }

            if (AcousticCeilingTiles == true)
            {
                Walls[4].SetMaterial(WallM.AcousticalCeiling);
                WallFiveCoef = new double[] { WallM.Coefficients[9]._htz125, WallM.Coefficients[9]._htz250, WallM.Coefficients[9]._htz500, WallM.Coefficients[9]._htz1k, WallM.Coefficients[9]._htz2k, WallM.Coefficients[9]._htz4k };
            }

            if (RoughPlasterOnLath == true)
            {
                Walls[4].SetMaterial(WallM.PlasterLime);
                WallFiveCoef = new double[] { WallM.Coefficients[10]._htz125, WallM.Coefficients[10]._htz250, WallM.Coefficients[10]._htz500, WallM.Coefficients[10]._htz1k, WallM.Coefficients[10]._htz2k, WallM.Coefficients[10]._htz4k };
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (TileConcrete == true)
            {
                Walls[5].SetMaterial(WallM.ConcreteTile);
                WallSixCoef = new double[] { WallM.Coefficients[0]._htz125, WallM.Coefficients[0]._htz250, WallM.Coefficients[0]._htz500, WallM.Coefficients[0]._htz1k, WallM.Coefficients[0]._htz2k, WallM.Coefficients[0]._htz4k };
            }

            if (WoodOnJoists == true)
            {
                Walls[5].SetMaterial(WallM.WoodOnJoists);
                WallSixCoef = new double[] { WallM.Coefficients[1]._htz125, WallM.Coefficients[1]._htz250, WallM.Coefficients[1]._htz500, WallM.Coefficients[1]._htz1k, WallM.Coefficients[1]._htz2k, WallM.Coefficients[1]._htz4k };
            }

            if (CarpetOnConcrete == true)
            {
                Walls[5].SetMaterial(WallM.CarpetOnConcrete);
                WallSixCoef = new double[] { WallM.Coefficients[2]._htz125, WallM.Coefficients[2]._htz250, WallM.Coefficients[2]._htz500, WallM.Coefficients[2]._htz1k, WallM.Coefficients[2]._htz2k, WallM.Coefficients[2]._htz4k };
            }

            if (CarpetOnFoam == true)
            {
                Walls[5].SetMaterial(WallM.CarpetOnConcrete);
                WallSixCoef = new double[] { WallM.Coefficients[3]._htz125, WallM.Coefficients[3]._htz250, WallM.Coefficients[3]._htz500, WallM.Coefficients[3]._htz1k, WallM.Coefficients[3]._htz2k, WallM.Coefficients[3]._htz4k };
            }

            if (UnglazedBrick == true)
            {
                Walls[5].SetMaterial(WallM.UnglazedBrick);
                WallSixCoef = new double[] { WallM.Coefficients[4]._htz125, WallM.Coefficients[4]._htz250, WallM.Coefficients[4]._htz500, WallM.Coefficients[4]._htz1k, WallM.Coefficients[4]._htz2k, WallM.Coefficients[4]._htz4k };
            }


            if (UnglazedPaintedBrick == true)
            {
                Walls[5].SetMaterial(WallM.UnglazedPaintedBrick);
                WallSixCoef = new double[] { WallM.Coefficients[5]._htz125, WallM.Coefficients[5]._htz250, WallM.Coefficients[5]._htz500, WallM.Coefficients[5]._htz1k, WallM.Coefficients[5]._htz2k, WallM.Coefficients[5]._htz4k };
            }

            if (Glass == true)
            {
                Walls[5].SetMaterial(WallM.Glass);
                WallSixCoef = new double[] { WallM.Coefficients[6]._htz125, WallM.Coefficients[6]._htz250, WallM.Coefficients[6]._htz500, WallM.Coefficients[6]._htz1k, WallM.Coefficients[6]._htz2k, WallM.Coefficients[6]._htz4k };
            }

            if (MarbleTile == true)
            {
                Walls[5].SetMaterial(WallM.MarbleTile);
                WallSixCoef = new double[] { WallM.Coefficients[7]._htz125, WallM.Coefficients[7]._htz250, WallM.Coefficients[7]._htz500, WallM.Coefficients[7]._htz1k, WallM.Coefficients[7]._htz2k, WallM.Coefficients[7]._htz4k };
            }

            if (PlywoodPanel == true)
            {
                Walls[5].SetMaterial(WallM.PlywoodPanel38);
                WallSixCoef = new double[] { WallM.Coefficients[8]._htz125, WallM.Coefficients[8]._htz250, WallM.Coefficients[8]._htz500, WallM.Coefficients[8]._htz1k, WallM.Coefficients[8]._htz2k, WallM.Coefficients[8]._htz4k };
            }

            if (AcousticCeilingTiles == true)
            {
                Walls[5].SetMaterial(WallM.AcousticalCeiling);
                WallSixCoef = new double[] { WallM.Coefficients[9]._htz125, WallM.Coefficients[9]._htz250, WallM.Coefficients[9]._htz500, WallM.Coefficients[9]._htz1k, WallM.Coefficients[9]._htz2k, WallM.Coefficients[9]._htz4k };
            }

            if (RoughPlasterOnLath == true)
            {
                Walls[5].SetMaterial(WallM.PlasterLime);
                WallSixCoef = new double[] { WallM.Coefficients[10]._htz125, WallM.Coefficients[10]._htz250, WallM.Coefficients[10]._htz500, WallM.Coefficients[10]._htz1k, WallM.Coefficients[10]._htz2k, WallM.Coefficients[10]._htz4k };
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {

            double height, width, depth, volume, length, area, C, RT60125;

            C = 0.049;

            height = Convert.ToDouble(textBox4.Text);
            width = Convert.ToDouble(textBox5.Text);
            depth = Convert.ToDouble(textBox6.Text);
            volume = (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text));

            labelVolume.Text = volume.ToString("n");

            //volume = textBox4 * textBox * textBox6;
            Wall WallOne = new Wall("WallOne", Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text));
            Wall WallTwo = new Wall("WallTwo", Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text));
            Wall WallThree = new Wall("WallThree", Convert.ToDouble(textBox11.Text), Convert.ToDouble(textBox12.Text));
            Wall WallFour = new Wall("WallFour", Convert.ToDouble(textBox13.Text), Convert.ToDouble(textBox14.Text));
            Wall WallFive = new Wall("WallFive", Convert.ToDouble(textBox15.Text), Convert.ToDouble(textBox1.Text));
            Wall WallSix = new Wall("WallSix", Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

            WallOne.area(WallOne._length, WallOne._height);
            WallTwo.area(WallOne._length, WallTwo._height);
            WallThree.area(WallOne._length, WallThree._height);
            WallFour.area(WallOne._length, WallFour._height);
            WallFive.area(WallOne._length, WallFive._height);
            WallSix.area(WallOne._length, WallSix._height);

            label32.Text = WallOne._area.ToString();
            label31.Text = WallTwo._area.ToString();
            label30.Text = WallThree._area.ToString();
            label29.Text = WallFour._area.ToString();
            label28.Text = WallFive._area.ToString();
            label27.Text = WallSix._area.ToString();


            //sum for surface area         
            label35.Text = (WallOne._area + WallTwo._area + WallThree._area + WallFour._area + WallFive._area + WallSix._area).ToString();

            //only change the label # keep the same htz125. So you will need to copy and paste six times for six wall surfaces. Label 38 = 125hz 

            label38.Text = (Convert.ToInt32(100.0 * ((C * (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text))) / ((WallM.Coefficients[0]._htz125) + (WallM.Coefficients[1]._htz125) + (WallM.Coefficients[2]._htz125) + (WallM.Coefficients[3]._htz125) +
                (WallM.Coefficients[4]._htz125) + (WallM.Coefficients[6]._htz125) + (WallM.Coefficients[7]._htz125) + (WallM.Coefficients[8]._htz125) + (WallM.Coefficients[9]._htz125) + (WallM.Coefficients[10]._htz125)) * ((Convert.ToDouble(label35.Text))))) / 100.0).ToString();

            //250hz[1] _250hz
            label44.Text = (Convert.ToInt32(100 * ((C * (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text))) / ((Convert.ToDouble(label32.Text) * WallM.Coefficients[1]._htz250) + (Convert.ToDouble(label31.Text) * WallM.Coefficients[1]._htz250) + (Convert.ToDouble(label30.Text) * WallM.Coefficients[1]._htz250) + (Convert.ToDouble(label29.Text) * WallM.Coefficients[1]._htz250) + (Convert.ToDouble(label28.Text) * WallM.Coefficients[1]._htz250) + (Convert.ToDouble(label27.Text) * WallM.Coefficients[1]._htz250)))) / 100.0).ToString();

            //500hz label59 [2] _500hz
            label59.Text = (Convert.ToInt32(100 * ((C * (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text))) / ((Convert.ToDouble(label32.Text) * WallM.Coefficients[2]._htz500) + (Convert.ToDouble(label31.Text) * WallM.Coefficients[2]._htz500) + (Convert.ToDouble(label30.Text) * WallM.Coefficients[2]._htz500) + (Convert.ToDouble(label29.Text) * WallM.Coefficients[2]._htz500) + (Convert.ToDouble(label28.Text) * WallM.Coefficients[2]._htz500) + (Convert.ToDouble(label27.Text) * WallM.Coefficients[2]._htz500)))) / 100.0).ToString();

            // 1000hz label60 [3] _1000hz
            label60.Text = (Convert.ToInt32(100 * ((C * (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text))) / ((Convert.ToDouble(label32.Text) * WallM.Coefficients[3]._htz1k) + (Convert.ToDouble(label31.Text) * WallM.Coefficients[3]._htz1k) + (Convert.ToDouble(label30.Text) * WallM.Coefficients[3]._htz1k) + (Convert.ToDouble(label29.Text) * WallM.Coefficients[3]._htz1k) + (Convert.ToDouble(label28.Text) * WallM.Coefficients[3]._htz1k) + (Convert.ToDouble(label27.Text) * WallM.Coefficients[3]._htz1k)))) / 100.0).ToString();

            //2000 hz label61 [4] _2000hz
            label61.Text = (Convert.ToInt32(((C * (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text))) / ((Convert.ToDouble(label32.Text) * WallM.Coefficients[4]._htz2k) + (Convert.ToDouble(label31.Text) * WallM.Coefficients[4]._htz2k) + (Convert.ToDouble(label30.Text) * WallM.Coefficients[4]._htz2k) + (Convert.ToDouble(label29.Text) * WallM.Coefficients[4]._htz2k) + (Convert.ToDouble(label28.Text) * WallM.Coefficients[4]._htz2k) + (Convert.ToDouble(label27.Text) * WallM.Coefficients[4]._htz2k)))) / 100.0).ToString();

            //4000 hz label62 [5] _4000hz
            label62.Text = (Convert.ToInt32(100 * ((C * (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text))) / ((Convert.ToDouble(label32.Text) * WallM.Coefficients[5]._htz4k) + (Convert.ToDouble(label31.Text) * WallM.Coefficients[5]._htz4k) + (Convert.ToDouble(label30.Text) * WallM.Coefficients[5]._htz4k) + (Convert.ToDouble(label29.Text) * WallM.Coefficients[5]._htz4k) + (Convert.ToDouble(label28.Text) * WallM.Coefficients[5]._htz4k) + (Convert.ToDouble(label27.Text) * WallM.Coefficients[5]._htz4k)))) / 100.0).ToString();


        }

        private float CalculateSurfaceArea(float length, float width)
        {
            return length * width;
        }

        private float CalculateTotal(float volume, float surfaceArea, float absorbtion)
        {
            return (.049f * volume) / (surfaceArea * absorbtion);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            double area, length, width;
            length = Convert.ToDouble(textBox11.Text);
            width = Convert.ToDouble(textBox12.Text);
            area = length * width;
            label30.Text = area.ToString("n");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelVolume_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            double area, length, width;
            length = Convert.ToDouble(textBox8.Text);
            width = Convert.ToDouble(textBox7.Text);
            area = length * width;
            label32.Text = area.ToString("n");

        }

        private void label22_Click(object sender, EventArgs e)
        {
            double area, length, width;
            length = Convert.ToDouble(textBox9.Text);
            width = Convert.ToDouble(textBox10.Text);
            area = length * width;
            label31.Text = area.ToString("n");
        }

        private void label24_Click(object sender, EventArgs e)
        {
            double area, length, width;
            length = Convert.ToDouble(textBox13.Text);
            width = Convert.ToDouble(textBox14.Text);
            area = length * width;
            label29.Text = area.ToString("n");
        }

        private void label25_Click(object sender, EventArgs e)
        {
            double area, length, width;
            length = Convert.ToDouble(textBox15.Text);
            width = Convert.ToDouble(textBox1.Text);
            area = length * width;
            label28.Text = area.ToString("n");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            double area, length, width;
            length = Convert.ToDouble(textBox2.Text);
            width = Convert.ToDouble(textBox3.Text);
            area = length * width;
            label27.Text = area.ToString("n");
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            double F, c, p, q, r, height, width, depth;

            height = Convert.ToDouble(textBox4.Text);
            width = Convert.ToDouble(textBox5.Text);
            depth = Convert.ToDouble(textBox6.Text);


            p = Convert.ToDouble(textBox16.Text);
            q = Convert.ToDouble(textBox17.Text);
            r = Convert.ToDouble(textBox18.Text);

            c = 1130;

            F = c / 2 * Math.Sqrt((Math.Pow(p, 2) / Math.Pow(depth, 2) + Math.Pow(q, 2) / Math.Pow(Width, 2) + Math.Pow(r, 2) / Math.Pow(height, 2)));
            label40.Text = F.ToString("n");
        }

   /*     private void CreateW1_Click(object sender, EventArgs e)
        {
            numRowsFilled += 1;
            if (TileConcrete == true)
            {
                Walls[0].SetMaterial(WallM.ConcreteTile);


                WallOneCoef = new double[] { WallM.Coefficients[0]._htz125, WallM.Coefficients[0]._htz250, WallM.Coefficients[0]._htz500, WallM.Coefficients[0]._htz1k, WallM.Coefficients[0]._htz2k, WallM.Coefficients[0]._htz4k };
            }

            if (WoodOnJoists == true)
            {
                Walls[0].SetMaterial(WallM.WoodOnJoists);


                WallOneCoef = new double[] { WallM.Coefficients[1]._htz125, WallM.Coefficients[1]._htz250, WallM.Coefficients[1]._htz500, WallM.Coefficients[1]._htz1k, WallM.Coefficients[1]._htz2k, WallM.Coefficients[1]._htz4k };
            }

            if (CarpetOnConcrete == true)
            {
                Walls[0].SetMaterial(WallM.CarpetOnConcrete);


                WallOneCoef = new double[] { WallM.Coefficients[2]._htz125, WallM.Coefficients[2]._htz250, WallM.Coefficients[2]._htz500, WallM.Coefficients[2]._htz1k, WallM.Coefficients[2]._htz2k, WallM.Coefficients[2]._htz4k };
            }

            if (CarpetOnFoam == true)
            {
                Walls[0].SetMaterial(WallM.CarpetOnFoam);
                ;

                WallOneCoef = new double[] { WallM.Coefficients[3]._htz125, WallM.Coefficients[3]._htz250, WallM.Coefficients[3]._htz500, WallM.Coefficients[3]._htz1k, WallM.Coefficients[3]._htz2k, WallM.Coefficients[3]._htz4k };
            }

            if (UnglazedBrick == true)
            {
                Walls[0].SetMaterial(WallM.UnglazedBrick);


                WallOneCoef = new double[] { WallM.Coefficients[4]._htz125, WallM.Coefficients[4]._htz250, WallM.Coefficients[4]._htz500, WallM.Coefficients[4]._htz1k, WallM.Coefficients[4]._htz2k, WallM.Coefficients[4]._htz4k };
            }

            if (UnglazedPaintedBrick == true)
            {
                Walls[0].SetMaterial(WallM.UnglazedPaintedBrick);

                WallOneCoef = new double[] { WallM.Coefficients[5]._htz125, WallM.Coefficients[5]._htz250, WallM.Coefficients[5]._htz500, WallM.Coefficients[5]._htz1k, WallM.Coefficients[5]._htz2k, WallM.Coefficients[5]._htz4k };
            }


            if (Glass == true)
            {
                Walls[0].SetMaterial(WallM.Glass);


                WallOneCoef = new double[] { WallM.Coefficients[6]._htz125, WallM.Coefficients[6]._htz250, WallM.Coefficients[6]._htz500, WallM.Coefficients[6]._htz1k, WallM.Coefficients[6]._htz2k, WallM.Coefficients[6]._htz4k };
            }

            if (MarbleTile == true)
            {
                Walls[0].SetMaterial(WallM.MarbleTile);

                WallOneCoef = new double[] { WallM.Coefficients[7]._htz125, WallM.Coefficients[7]._htz250, WallM.Coefficients[7]._htz500, WallM.Coefficients[7]._htz1k, WallM.Coefficients[7]._htz2k, WallM.Coefficients[7]._htz4k };
            }

            if (PlywoodPanel == true)
            {
                Walls[0].SetMaterial(WallM.PlywoodPanel38);


                WallOneCoef = new double[] { WallM.Coefficients[8]._htz125, WallM.Coefficients[8]._htz250, WallM.Coefficients[8]._htz500, WallM.Coefficients[8]._htz1k, WallM.Coefficients[8]._htz2k, WallM.Coefficients[8]._htz4k };
            }

            if (AcousticCeilingTiles == true)
            {
                Walls[0].SetMaterial(WallM.AcousticalCeiling);


                WallOneCoef = new double[] { WallM.Coefficients[9]._htz125, WallM.Coefficients[9]._htz250, WallM.Coefficients[9]._htz500, WallM.Coefficients[9]._htz1k, WallM.Coefficients[9]._htz2k, WallM.Coefficients[9]._htz4k };
            }

            if (RoughPlasterOnLath == true)
            {
                Walls[0].SetMaterial(WallM.PlasterLime);


                WallOneCoef = new double[] { WallM.Coefficients[10]._htz125, WallM.Coefficients[10]._htz250, WallM.Coefficients[10]._htz500, WallM.Coefficients[10]._htz1k, WallM.Coefficients[10]._htz2k, WallM.Coefficients[10]._htz4k };
            }


            //label44.Text = wall1Mat.wall1.name;
        }
    */ 

        public void updateTextIcon (string name )
        {
            try
            {
                SqlConnect sq = new SqlConnect();
                Dictionary<string, Object> Mat = sq.sqlMaterial(Name);
                foreach (var item in Mat)
                {
                    Materials M = item.Value;
                    label51.Text = M._htz125.ToString();
                    label50.Text = M._htz250.ToString();
                    label49.Text = M._htz500.ToString();
                    label48.Text = M._htz1k.ToString();
                    label47.Text = M._htz2k.ToString();
                    label46.Text = M._htz4k.ToString();

                    sq.SqlInsertData((float)M._htz125, (float)M._htz250
                        , (float)M._htz500, (float)M._htz1k, (float)M._htz2k,
                        (float)M._htz4k);

                }


            }



            catch (Exception ex)
            {
                Console.Write("Error in the code" + ex.ToString()
                    );

            }
        }



        private void button19_Click(object sender, EventArgs e)
        {
            string Name = "TileConcrete";
            updateTextIcon(Name);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string Name = "WoodOnJoists";
            updateTextIcon(Name);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string Name = "CarpetOnConcrete";
            updateTextIcon(Name);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string Name = "CarpetOnFoam";
            updateTextIcon(Name);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string Name = "UnglazedBrick";
            updateTextIcon(Name);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string Name = "UnglazedPaintedBrick";
            updateTextIcon(Name);
          
        }

        private void button13_Click(object sender, EventArgs e)
        {

            string Name = "Glass";
            updateTextIcon(Name);
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string Name = "MarbleTile";
            updateTextIcon(Name);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string Name = "PlywoodPanel";
            updateTextIcon(Name);

          
        }

        private void button10_Click(object sender, EventArgs e)
        {

            string Name = "AcousticCeilingTiles";
            updateTextIcon(Name);

           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Name = "RoughPlasterOnLath";
            updateTextIcon(Name);

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            label71.Text = ((Convert.ToDouble(label38.Text) + Convert.ToDouble(label44.Text) + Convert.ToDouble(label59.Text) + Convert.ToDouble(label60.Text) + Convert.ToDouble(label61.Text) + Convert.ToDouble(label62.Text)) / 6).ToString();
        }

       
    }
}
