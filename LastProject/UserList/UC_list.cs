using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LastProject.UserList
{
    public partial class UC_list : UserControl
    {
        private List<List<string>> data;
        private string dataFilePath = "list_data.json";

        public UC_list()
        {
            InitializeComponent();
            data = new List<List<string>>();
        }

        private void UC_list_Load(object sender, EventArgs e)
        {
            // You can perform any additional initialization here
        }

        public void SaveData()
        {
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(dataFilePath, jsonData);
        }

        public void SetData(List<List<string>> tableData)
        {
            data = tableData;
            RefreshDataGridView();
        }

        public void AddSellData(List<string> sellData)
        {
            data.Add(sellData);
            RefreshDataGridView();
        }
        public void LoadData(string dataFilePath)
        {
            this.dataFilePath = dataFilePath;

            if (File.Exists(dataFilePath))
            {
                string jsonData = File.ReadAllText(dataFilePath);
                data = JsonConvert.DeserializeObject<List<List<string>>>(jsonData);
                RefreshDataGridView();
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView3.Rows.Clear();

            foreach (List<string> row in data)
            {
                dataGridView3.Rows.Add(row.ToArray());
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in dataGridView3.SelectedRows)
                    {
                        if (!selectedRow.IsNewRow)
                        {
                            int rowIndex = selectedRow.Index;
                            dataGridView3.Rows.RemoveAt(rowIndex);
                            data.RemoveAt(rowIndex);
                        }
                    }

                    SaveData();
                }
            }
        }
    }
}