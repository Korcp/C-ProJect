using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.UserControls;

namespace WindowsFormsApp4.Resources
{
    public partial class Form_Dashboard : Form
    {

        int PanelWidth;
        bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            timer2.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_HOME uch = new UC_HOME();
            AddControlsToPanel(uch);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }

            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width<= 85)
                {
                    timer1.Stop();
                    isCollapsed=true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
 private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }


        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c); 
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_HOME uch = new UC_HOME();
            AddControlsToPanel(uch);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSales);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveSidePanel(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveSidePanel(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moveSidePanel(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            moveSidePanel(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            moveSidePanel(button7);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
        }
    }
}
