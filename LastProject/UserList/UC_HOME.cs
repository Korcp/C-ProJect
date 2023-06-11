using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProject.UserList
{
    public partial class UC_HOME : UserControl
    {
        public UC_HOME()
        {
            InitializeComponent();
        }
        Random rand = new Random();

        private void LoadChart()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);

            dataPoint.addLabely("1000", rand.Next(0,100).ToString());
            dataPoint.addLabely("2000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("3000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("4000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("5000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("6000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("7000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("8000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("9000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("10000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("11000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("12000", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("13000", rand.Next(0, 1000).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
