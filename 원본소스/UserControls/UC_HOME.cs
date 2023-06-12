using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.UserControls
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

            dataPoint.addLabely("1월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("2월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("3월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("4월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("5월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("6월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("7월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("8월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("9월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("10월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("11월", rand.Next(0, 500).ToString());
            dataPoint.addLabely("12월", rand.Next(0, 500).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
