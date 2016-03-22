using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcousticalModeling
{
    public partial class WallMaterials : Form
    {
        public WallManager WallM = new WallManager();

        //public Wall wall1 = new Wall();

        enum mats { blank, one, two, three, four };
        mats currentMat = mats.blank;
        

        public WallMaterials()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[0]._htz125.ToString();
            label9.Text = WallM.Coefficients[0]._htz250.ToString();
            label10.Text = WallM.Coefficients[0]._htz500.ToString();
            label11.Text = WallM.Coefficients[0]._htz1k.ToString();
            label12.Text = WallM.Coefficients[0]._htz2k.ToString();
            label13.Text = WallM.Coefficients[0]._htz4k.ToString();
            currentMat = mats.one;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[1]._htz125.ToString();
            label9.Text = WallM.Coefficients[1]._htz250.ToString();
            label10.Text = WallM.Coefficients[1]._htz500.ToString();
            label11.Text = WallM.Coefficients[1]._htz1k.ToString();
            label12.Text = WallM.Coefficients[1]._htz2k.ToString();
            label13.Text = WallM.Coefficients[1]._htz4k.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[2]._htz125.ToString();
            label9.Text = WallM.Coefficients[2]._htz250.ToString();
            label10.Text = WallM.Coefficients[2]._htz500.ToString();
            label11.Text = WallM.Coefficients[2]._htz1k.ToString();
            label12.Text = WallM.Coefficients[2]._htz2k.ToString();
            label13.Text = WallM.Coefficients[2]._htz4k.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[3]._htz125.ToString();
            label9.Text = WallM.Coefficients[3]._htz250.ToString();
            label10.Text = WallM.Coefficients[3]._htz500.ToString();
            label11.Text = WallM.Coefficients[3]._htz1k.ToString();
            label12.Text = WallM.Coefficients[3]._htz2k.ToString();
            label13.Text = WallM.Coefficients[3]._htz4k.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[4]._htz125.ToString();
            label9.Text = WallM.Coefficients[4]._htz250.ToString();
            label10.Text = WallM.Coefficients[4]._htz500.ToString();
            label11.Text = WallM.Coefficients[4]._htz1k.ToString();
            label12.Text = WallM.Coefficients[4]._htz2k.ToString();
            label13.Text = WallM.Coefficients[4]._htz4k.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[5]._htz125.ToString();
            label9.Text = WallM.Coefficients[5]._htz250.ToString();
            label10.Text = WallM.Coefficients[5]._htz500.ToString();
            label11.Text = WallM.Coefficients[5]._htz1k.ToString();
            label12.Text = WallM.Coefficients[5]._htz2k.ToString();
            label13.Text = WallM.Coefficients[5]._htz4k.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[6]._htz125.ToString();
            label9.Text = WallM.Coefficients[6]._htz250.ToString();
            label10.Text = WallM.Coefficients[6]._htz500.ToString();
            label11.Text = WallM.Coefficients[6]._htz1k.ToString();
            label12.Text = WallM.Coefficients[6]._htz2k.ToString();
            label13.Text = WallM.Coefficients[6]._htz4k.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[7]._htz125.ToString();
            label9.Text = WallM.Coefficients[7]._htz250.ToString();
            label10.Text = WallM.Coefficients[7]._htz500.ToString();
            label11.Text = WallM.Coefficients[7]._htz1k.ToString();
            label12.Text = WallM.Coefficients[7]._htz2k.ToString();
            label13.Text = WallM.Coefficients[7]._htz4k.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[8]._htz125.ToString();
            label9.Text = WallM.Coefficients[8]._htz250.ToString();
            label10.Text = WallM.Coefficients[8]._htz500.ToString();
            label11.Text = WallM.Coefficients[8]._htz1k.ToString();
            label12.Text = WallM.Coefficients[8]._htz2k.ToString();
            label13.Text = WallM.Coefficients[8]._htz4k.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[9]._htz125.ToString();
            label9.Text = WallM.Coefficients[9]._htz250.ToString();
            label10.Text = WallM.Coefficients[9]._htz500.ToString();
            label11.Text = WallM.Coefficients[9]._htz1k.ToString();
            label12.Text = WallM.Coefficients[9]._htz2k.ToString();
            label13.Text = WallM.Coefficients[9]._htz4k.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label8.Text = WallM.Coefficients[10]._htz125.ToString();
            label9.Text = WallM.Coefficients[10]._htz250.ToString();
            label10.Text = WallM.Coefficients[10]._htz500.ToString();
            label11.Text = WallM.Coefficients[10]._htz1k.ToString();
            label12.Text = WallM.Coefficients[10]._htz2k.ToString();
            label13.Text = WallM.Coefficients[10]._htz4k.ToString();
        }

        private void WallOneSave_Click(object sender, EventArgs e)
        {
            //wall1.name = currentMat.ToString();
            //wall1._htz125 = double.Parse(label8.Text);
            //wall1._htz250 = double.Parse(label9.Text);
            //wall1._htz500 = double.Parse(label10.Text);
            //wall1._htz1k = double.Parse(label11.Text);
            //wall1._htz2k = double.Parse(label12.Text);
            //wall1._htz4k = double.Parse(label13.Text);
            //label14.Text = wall1.name;
        }

        private void WallMaterials_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
