using System;
using System.Diagnostics;
using System.Windows.Forms;
using LastProject.UserList;
using System.Collections.Generic;

namespace LastProject.Resources
{
    public partial class Main_Form : Form
    {
        public string DataFilePath { get; set; }
        private string dataFilePath;
        private Stopwatch stopwatch;
        private UC_SELL ucSell;
        private UC_get ucGet;
        private UC_list ucList;
        private UC_HOME uch = new UC_HOME();
        public UC_SELL uc_sell;
        
        public Main_Form()
        {
            InitializeComponent();
            this.dataFilePath = dataFilePath;
            stopwatch = Stopwatch.StartNew();
            timer2.Start();
            timer1.Start();
            ucSell = new UC_SELL("sell_data.json");
            ucSell.SetMainForm(this);
            ucSell.FinishButtonClicked += UcSell_FinishButtonClicked;
            ucGet = new UC_get("data.json");
            ucList = new UC_list();
            uc_sell = new UC_SELL("sell_data.json");
            uc_sell.SetMainForm(this);
            ucSell.FinishButtonClicked += UcSell_FinishButtonClicked;
            AddControlsToPanel(uch);
           

        }

        private void UcSell_FinishButtonClicked(object sender, EventArgs e)
        {
            // Get the table data from uc_sell
            List<List<string>> tableData = ucSell.GetData();

            // Pass the table data to UC_list
            ucList.SetData(tableData);

            // Save the updated data for the current payment
            ucList.SaveData();

            // Reset the uc_sell control
            ucSell.ClearTableList();
        }





        public void SetSellData(List<List<string>> sellData)
        {
            // Implement the logic to set the sell data in your Main_Form class
            // based on the provided sellData parameter
            // ...
        }

        public void ResetUC_SELL()
        {
            // Reset the UC_SELL control to its initial state
            uc_sell.ClearTableList();
        }

        public UC_list GetUCListInstance()
        {
            // Return the instance of UC_list
            return ucList;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            // Subscribe to the FinishButtonClicked event of ucSell
            ucSell.FinishButtonClicked += UcSell_FinishButtonClicked;
            uc_sell = new UC_SELL(DataFilePath);
        }


        private void UpdateSalesDetails()
        {
            // Implement the logic to update the sales details in your Main_Form class
            // based on the calculation performed in ucSell
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            nowtimes.Text = dt1.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;
            gettime.Text = $"{elapsedTime.Hours:00}:{elapsedTime.Minutes:00}:{elapsedTime.Seconds:00}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopwatch.Stop();
            timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MessageBox.Show("Thank you");
            using (Form1 f1 = new Form1())
            {
                f1.ShowDialog();
            }
        }

        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void moveSidePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnhome);
            AddControlsToPanel(uch);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSell);
            AddControlsToPanel(ucSell);
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnlist);
            AddControlsToPanel(ucList);
            ucList.SetData(ucSell.GetData());
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnget);
            AddControlsToPanel(ucGet);
        }


        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
