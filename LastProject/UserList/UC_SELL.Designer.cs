namespace LastProject.UserList
{
    partial class UC_SELL
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.상품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.개수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.총가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.sumbutton = new System.Windows.Forms.Button();
            this.sumbox11 = new System.Windows.Forms.TextBox();
            this.Finishbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(393, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "판매창";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.상품명,
            this.가격,
            this.개수,
            this.총가격});
            this.dataGridView1.Location = new System.Drawing.Point(96, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(488, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // 상품명
            // 
            this.상품명.HeaderText = "상품명";
            this.상품명.MinimumWidth = 8;
            this.상품명.Name = "상품명";
            this.상품명.Width = 150;
            // 
            // 가격
            // 
            this.가격.HeaderText = "가격";
            this.가격.MinimumWidth = 8;
            this.가격.Name = "가격";
            this.가격.Width = 150;
            // 
            // 개수
            // 
            this.개수.HeaderText = "개수";
            this.개수.MinimumWidth = 8;
            this.개수.Name = "개수";
            this.개수.Width = 150;
            // 
            // 총가격
            // 
            this.총가격.HeaderText = "총가격";
            this.총가격.MinimumWidth = 8;
            this.총가격.Name = "총가격";
            this.총가격.Width = 150;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxProductName.Location = new System.Drawing.Point(738, 191);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(167, 28);
            this.textBoxProductName.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxQuantity.Location = new System.Drawing.Point(738, 300);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(167, 28);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPrice.Location = new System.Drawing.Point(738, 255);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(167, 28);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(738, 355);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(167, 28);
            this.textBoxTotalPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(638, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "상품명:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(663, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "가격:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(663, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "개수:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(629, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "총 가격:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addButton.Location = new System.Drawing.Point(747, 398);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 64);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "담기";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteButton.Location = new System.Drawing.Point(852, 401);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 61);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modifyButton.Location = new System.Drawing.Point(642, 401);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 61);
            this.modifyButton.TabIndex = 7;
            this.modifyButton.Text = "수정";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // sumbutton
            // 
            this.sumbutton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sumbutton.Location = new System.Drawing.Point(96, 555);
            this.sumbutton.Name = "sumbutton";
            this.sumbutton.Size = new System.Drawing.Size(162, 31);
            this.sumbutton.TabIndex = 8;
            this.sumbutton.Text = "합계";
            this.sumbutton.UseVisualStyleBackColor = true;
            this.sumbutton.Click += new System.EventHandler(this.sumbutton_Click);
            // 
            // sumbox11
            // 
            this.sumbox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sumbox11.Location = new System.Drawing.Point(286, 558);
            this.sumbox11.Name = "sumbox11";
            this.sumbox11.Size = new System.Drawing.Size(298, 28);
            this.sumbox11.TabIndex = 9;
            // 
            // Finishbutton
            // 
            this.Finishbutton.Location = new System.Drawing.Point(657, 558);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(280, 28);
            this.Finishbutton.TabIndex = 10;
            this.Finishbutton.Text = "계산하기";
            this.Finishbutton.UseVisualStyleBackColor = true;
            this.Finishbutton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // UC_SELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Finishbutton);
            this.Controls.Add(this.sumbox11);
            this.Controls.Add(this.sumbutton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_SELL";
            this.Size = new System.Drawing.Size(1039, 756);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.MaskedTextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.MaskedTextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button sumbutton;
        private System.Windows.Forms.TextBox sumbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 개수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 총가격;
        private System.Windows.Forms.Button Finishbutton;
    }
}
