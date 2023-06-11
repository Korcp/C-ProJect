namespace LastProject.UserList
{
    partial class UC_list
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.상품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.개수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.총가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(383, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "판매내역";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.상품명,
            this.가격,
            this.개수,
            this.총가격});
            this.dataGridView3.Location = new System.Drawing.Point(81, 138);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 30;
            this.dataGridView3.Size = new System.Drawing.Size(665, 382);
            this.dataGridView3.TabIndex = 1;
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
            this.총가격.HeaderText = "총 가격";
            this.총가격.MinimumWidth = 8;
            this.총가격.Name = "총가격";
            this.총가격.Width = 150;
            // 
            // UC_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_list";
            this.Size = new System.Drawing.Size(1039, 756);
            this.Load += new System.EventHandler(this.UC_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 개수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 총가격;
    }
}
