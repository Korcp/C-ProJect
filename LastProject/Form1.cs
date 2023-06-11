using LastProject.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            nowtime.Text = dt.ToString("HH:mm:ss");
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (text_id.Text == "2019875026" && text_PW.Text == "1234") {
                this.Hide();
                MessageBox.Show("관리자님 환영합니다.");
                using (Main_Form mf = new Main_Form())
                {
                    mf.ShowDialog();
                }
            }

            else {
                MessageBox.Show("아이디와패스워드를 확인해주세요.");
                        
        }
            
                    
        }              
               
    }
}
