using LastProject.Resources;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;

namespace LastProject.UserList
{
    public partial class UC_SELL : UserControl
    {
        private List<List<string>> data;
        private List<int> deletedRows;
        private string dataFilePath = "sell_data.json";
        private Main_Form mainForm;

        public event EventHandler<EventArgs> FinishButtonClicked;
        private TextBox sumbox11;

        public void SetMainForm(Main_Form mainForm)
        {
            this.mainForm = mainForm;
        }

        public UC_SELL(string dataFilePath)
        {
            InitializeComponent();
            data = new List<List<string>>();
            deletedRows = new List<int>();
            this.dataFilePath = dataFilePath;
        }

        public List<List<string>> GetData()
        {
            return data;
        }

        private void UC_SELL_Load(object sender, EventArgs e)
        {
            AddColumnsToDataGridView();
            modifyButton.Click += modifyButton_Click;

            // Load data from file
            LoadData();

            RefreshDataGridView();
            Controls.Add(sumbox11);
        }

        private void AddColumnsToDataGridView()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "Product Name";
            dataGridView1.Columns[1].HeaderText = "Price";
            dataGridView1.Columns[2].HeaderText = "Count";
            dataGridView1.Columns[3].HeaderText = "Total Price";
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

        private void addButton_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            string price = textBoxPrice.Text;
            string quantity = textBoxQuantity.Text;
            string totalPrice = textBoxTotalPrice.Text;

            if (!string.IsNullOrEmpty(productName) &&
                !string.IsNullOrEmpty(price) &&
                !string.IsNullOrEmpty(quantity) &&
                !string.IsNullOrEmpty(totalPrice))
            {
                // Add the values to the data list
                List<string> newRow = new List<string>
                {
                    productName,
                    price,
                    quantity,
                    totalPrice
                };
                data.Add(newRow);

                // Add the values to the DataGridView
                dataGridView1.Rows.Add(newRow.ToArray());

                // Clear the TextBox controls
                textBoxProductName.Clear();
                textBoxPrice.Clear();
                textBoxQuantity.Clear();
                textBoxTotalPrice.Clear();

                // Save the updated data
                SaveData();
            }
            else
            {
                MessageBox.Show("모든 빈칸을 채워주세요");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("해당열을 삭제하시겟습니까?", "Confirmation", MessageBoxButtons.YesNo);
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

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the index of the selected row
                int rowIndex = selectedRow.Index;

                // Retrieve the values from the selected row
                string productName = selectedRow.Cells[0].Value.ToString();
                string price = selectedRow.Cells[1].Value.ToString();
                string quantity = selectedRow.Cells[2].Value.ToString();
                string totalPrice = selectedRow.Cells[3].Value.ToString();

                // Update the corresponding TextBox controls with the retrieved values
                textBoxProductName.Text = productName;
                textBoxPrice.Text = price;
                textBoxQuantity.Text = quantity;
                textBoxTotalPrice.Text = totalPrice;

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);

                // Remove the selected row from the data list
                data.RemoveAt(rowIndex);

                // Save the updated data
                SaveData();
            }
        }

        private void sumbutton_Click(object sender, EventArgs e)
        {
            decimal sumTotalPrice = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string totalPriceValue = row.Cells[3].Value.ToString();
                    decimal totalPriceDecimal;
                    if (decimal.TryParse(totalPriceValue, out totalPriceDecimal))
                    {
                        sumTotalPrice += totalPriceDecimal;
                    }
                }
            }

            // Display the sum in the sumbox11 TextBox
            sumbox11.Text = sumTotalPrice.ToString();
        }
        public List<List<string>> GetSellData()
        {
            // Implement the logic to retrieve the sell data
            // and return it as a List<List<string>>
            List<List<string>> sellData = new List<List<string>>();
            // Retrieve the sell data and populate the sellData variable
            // ...

            return sellData;
        }

        public void ClearTableList()
        {
            data.Clear();
            deletedRows.Clear();
            RefreshDataGridView();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (FinishButtonClicked != null)
            {
                // Trigger the event and pass the data to the main form
                FinishButtonClicked(this, EventArgs.Empty);
                mainForm.SetSellData(GetData());
            }
            ClearTableList();
        }


    }
}
