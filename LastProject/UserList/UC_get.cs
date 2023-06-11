using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LastProject.UserList
{
    public partial class UC_get : UserControl
    {
        private List<List<string>> data;
        private List<int> deletedRows;
        private string dataFilePath;

        public UC_get(string filePath)
        {
            InitializeComponent();

            data = new List<List<string>>();
            deletedRows = new List<int>();
            dataFilePath = filePath;
        }

        private void UC_get_Load(object sender, EventArgs e)
        {
            AddColumnsToDataGridView();
            // Load data from file
            LoadData();

            RefreshDataGridView();
        }


        // Rest of the code...
        private void AddColumnsToDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "고유 번호";
            dataGridView1.Columns[1].HeaderText = "이름";
            dataGridView1.Columns[2].HeaderText = "가격";
            dataGridView1.Columns[3].HeaderText = "개수";
            dataGridView1.Columns[4].HeaderText = "총 가격";
        }

        private void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                string jsonData = File.ReadAllText(dataFilePath);
                data = JsonConvert.DeserializeObject<List<List<string>>>(jsonData);
            }
        }

        private void SaveData()
        {
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(dataFilePath, jsonData);
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                if (!deletedRows.Contains(i))
                {
                    dataGridView1.Rows.Add(data[i].ToArray());
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your code logic here
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string serialNumber = textNum.Text;
            string id = textBoxID.Text;
            string price = textBoxPrice.Text;
            string totalPrice = textBoxTotalPrice.Text;
            string count = textBoxCount.Text;

            if (!string.IsNullOrEmpty(serialNumber) &&
                !string.IsNullOrEmpty(id) &&
                !string.IsNullOrEmpty(price) &&
                !string.IsNullOrEmpty(totalPrice) &&
                !string.IsNullOrEmpty(count))
            {
                // Add the values to the data list
                List<string> newRow = new List<string>
        {
            serialNumber,
            id,
            price,
            totalPrice,
            count
        };
                data.Add(newRow);

                // Add the values to the DataGridView
                dataGridView1.Rows.Add(newRow.ToArray());

                // Clear the TextBox controls
                textNum.Clear();
                textBoxID.Clear();
                textBoxPrice.Clear();
                textBoxTotalPrice.Clear();
                textBoxCount.Clear();

                // Save the updated data
                SaveData();
            }
            else
            {
                MessageBox.Show("모든 항목의 값을 입력하여주세요");
            }
        }




        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("이 정보를 삭제하시겠습니까?", "삭제되었습니다.", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                    {
                        if (!selectedRow.IsNewRow)
                        {
                            int rowIndex = selectedRow.Index;

                            // Remove the row from the DataGridView
                            dataGridView1.Rows.RemoveAt(rowIndex);

                            // Store the index of the row to be deleted
                            deletedRows.Add(rowIndex);
                        }
                    }

                    // Remove the deleted rows from the data list
                    List<List<string>> updatedData = new List<List<string>>();
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (!deletedRows.Contains(i))
                        {
                            updatedData.Add(data[i]);
                        }
                    }
                    data = updatedData;

                    // Save the updated data
                    SaveData();
                }
            }
        }

        private void UDbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the index of the selected row
                int rowIndex = selectedRow.Index;

                // Retrieve the values from the selected row
                string serialNumber = selectedRow.Cells[0].Value.ToString();
                string id = selectedRow.Cells[1].Value.ToString();
                string price = selectedRow.Cells[2].Value.ToString();
                string totalPrice = selectedRow.Cells[3].Value.ToString();
                string count = selectedRow.Cells[4].Value.ToString();

                // Update the corresponding TextBox controls with the retrieved values
                textNum.Text = serialNumber;
                textBoxID.Text = id;
                textBoxPrice.Text = price;
                textBoxTotalPrice.Text = totalPrice;
                textBoxCount.Text = count;

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);

                // Remove the selected row from the data list
                data.RemoveAt(rowIndex);

                // Save the updated data
                SaveData();
            }
        }

    }
}
