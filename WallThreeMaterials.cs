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
    public partial class WallThreeMaterials : Form
    {
        public WallThreeMaterials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = (".01");
            label9.Text = (".01");
            label10.Text = (".015");
            label11.Text = (".02");
            label12.Text = (".02");
            label13.Text = (".02");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = (".15");
            label9.Text = (".11");
            label10.Text = (".1");
            label11.Text = (".07");
            label12.Text = (".06");
            label13.Text = (".07");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = (".02");
            label9.Text = (".06");
            label10.Text = (".14");
            label11.Text = (".37");
            label12.Text = (".6");
            label13.Text = (".65");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = (".08");
            label9.Text = (".24");
            label10.Text = (".57");
            label11.Text = (".69");
            label12.Text = (".71");
            label13.Text = (".73");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label8.Text = (".03");
            label9.Text = (".03");
            label10.Text = (".03");
            label11.Text = (".04");
            label12.Text = (".05");
            label13.Text = (".07");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label8.Text = (".01");
            label9.Text = (".01");
            label10.Text = (".02");
            label11.Text = (".02");
            label12.Text = (".02");
            label13.Text = (".03");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label8.Text = (".18");
            label9.Text = (".06");
            label10.Text = (".04");
            label11.Text = (".03");
            label12.Text = (".02");
            label13.Text = (".02");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label8.Text = (".01");
            label9.Text = (".01");
            label10.Text = (".01");
            label11.Text = (".01");
            label12.Text = (".02");
            label13.Text = (".02");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label8.Text = (".28");
            label9.Text = (".22");
            label10.Text = (".17");
            label11.Text = (".09");
            label12.Text = (".10");
            label13.Text = (".11");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label8.Text = (".05");
            label9.Text = (".22");
            label10.Text = (".52");
            label11.Text = (".56");
            label12.Text = (".45");
            label13.Text = (".32");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label8.Text = (".02");
            label9.Text = (".03");
            label10.Text = (".04");
            label11.Text = (".05");
            label12.Text = (".04");
            label13.Text = (".03");

        }

        private void WallThreeMaterials_Load(object sender, EventArgs e)
        {

        }
    }
}
