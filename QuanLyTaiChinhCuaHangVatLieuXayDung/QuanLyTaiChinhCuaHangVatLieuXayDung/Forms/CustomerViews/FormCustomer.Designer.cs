namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.CustomerViews
{
    partial class FormCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiButton_Insert = new Sunny.UI.UIButton();
            this.uiButton_Update = new Sunny.UI.UIButton();
            this.uiButton_Delete = new Sunny.UI.UIButton();
            this.uiRadioButton_Insert = new Sunny.UI.UIRadioButton();
            this.uiRadioButton_Update = new Sunny.UI.UIRadioButton();
            this.uiRadioButton_Delete = new Sunny.UI.UIRadioButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiDataGridViewCustomer = new Sunny.UI.UIDataGridView();
            this.uiTextBoxIdCustomer = new Sunny.UI.UITextBox();
            this.uiTextBoxNameCustomer = new Sunny.UI.UITextBox();
            this.uiTextBoxPhoneNumber = new Sunny.UI.UITextBox();
            this.uiTextBoxAddress = new Sunny.UI.UITextBox();
            this.uiTextBoxSearch = new Sunny.UI.UITextBox();
            this.uiButtonSearch = new Sunny.UI.UIButton();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(56, 43);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(170, 57);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Mã khách hàng; ";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(56, 136);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(170, 57);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Tên khách hàng: ";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(56, 228);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(170, 57);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Số điện thoại: ";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(56, 320);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(170, 57);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "Địa chỉ: ";
            // 
            // uiButton_Insert
            // 
            this.uiButton_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton_Insert.Location = new System.Drawing.Point(42, 430);
            this.uiButton_Insert.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Insert.Name = "uiButton_Insert";
            this.uiButton_Insert.Size = new System.Drawing.Size(137, 69);
            this.uiButton_Insert.TabIndex = 6;
            this.uiButton_Insert.Text = "Thêm";
            this.uiButton_Insert.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton_Insert.Click += new System.EventHandler(this.uiButton_Insert_Click);
            // 
            // uiButton_Update
            // 
            this.uiButton_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton_Update.Location = new System.Drawing.Point(220, 430);
            this.uiButton_Update.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Update.Name = "uiButton_Update";
            this.uiButton_Update.Size = new System.Drawing.Size(137, 69);
            this.uiButton_Update.TabIndex = 7;
            this.uiButton_Update.Text = "Sửa";
            this.uiButton_Update.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton_Update.Click += new System.EventHandler(this.uiButton_Update_Click);
            // 
            // uiButton_Delete
            // 
            this.uiButton_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton_Delete.Location = new System.Drawing.Point(412, 430);
            this.uiButton_Delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Delete.Name = "uiButton_Delete";
            this.uiButton_Delete.Size = new System.Drawing.Size(137, 69);
            this.uiButton_Delete.TabIndex = 8;
            this.uiButton_Delete.Text = "Xóa";
            this.uiButton_Delete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton_Delete.Click += new System.EventHandler(this.uiButton_Delete_Click);
            // 
            // uiRadioButton_Insert
            // 
            this.uiRadioButton_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiRadioButton_Insert.Location = new System.Drawing.Point(77, 515);
            this.uiRadioButton_Insert.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton_Insert.Name = "uiRadioButton_Insert";
            this.uiRadioButton_Insert.Size = new System.Drawing.Size(102, 37);
            this.uiRadioButton_Insert.TabIndex = 10;
            this.uiRadioButton_Insert.Text = "Thêm";
            this.uiRadioButton_Insert.CheckedChanged += new System.EventHandler(this.uiRadioButton_Insert_CheckedChanged);
            // 
            // uiRadioButton_Update
            // 
            this.uiRadioButton_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiRadioButton_Update.Location = new System.Drawing.Point(258, 515);
            this.uiRadioButton_Update.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton_Update.Name = "uiRadioButton_Update";
            this.uiRadioButton_Update.Size = new System.Drawing.Size(112, 37);
            this.uiRadioButton_Update.TabIndex = 11;
            this.uiRadioButton_Update.Text = "Sửa";
            this.uiRadioButton_Update.CheckedChanged += new System.EventHandler(this.uiRadioButton_Update_CheckedChanged);
            // 
            // uiRadioButton_Delete
            // 
            this.uiRadioButton_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiRadioButton_Delete.Location = new System.Drawing.Point(448, 515);
            this.uiRadioButton_Delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton_Delete.Name = "uiRadioButton_Delete";
            this.uiRadioButton_Delete.Size = new System.Drawing.Size(68, 37);
            this.uiRadioButton_Delete.TabIndex = 12;
            this.uiRadioButton_Delete.Text = "Xóa";
            this.uiRadioButton_Delete.CheckedChanged += new System.EventHandler(this.uiRadioButton_Delete_CheckedChanged);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiDataGridViewCustomer);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(594, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(564, 721);
            this.uiPanel1.TabIndex = 13;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiDataGridViewCustomer
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridViewCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.uiDataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridViewCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.uiDataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle13;
            this.uiDataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridViewCustomer.EnableHeadersVisualStyles = false;
            this.uiDataGridViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridViewCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.uiDataGridViewCustomer.Name = "uiDataGridViewCustomer";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.uiDataGridViewCustomer.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDataGridViewCustomer.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.uiDataGridViewCustomer.RowTemplate.Height = 24;
            this.uiDataGridViewCustomer.SelectedIndex = -1;
            this.uiDataGridViewCustomer.Size = new System.Drawing.Size(564, 721);
            this.uiDataGridViewCustomer.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridViewCustomer.TabIndex = 0;
            this.uiDataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowCustomers_CellClick);
            // 
            // uiTextBoxIdCustomer
            // 
            this.uiTextBoxIdCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxIdCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBoxIdCustomer.Location = new System.Drawing.Point(242, 43);
            this.uiTextBoxIdCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxIdCustomer.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxIdCustomer.Name = "uiTextBoxIdCustomer";
            this.uiTextBoxIdCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxIdCustomer.ShowText = false;
            this.uiTextBoxIdCustomer.Size = new System.Drawing.Size(307, 45);
            this.uiTextBoxIdCustomer.TabIndex = 14;
            this.uiTextBoxIdCustomer.Text = "uiTextBox1";
            this.uiTextBoxIdCustomer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxIdCustomer.Watermark = "";
            // 
            // uiTextBoxNameCustomer
            // 
            this.uiTextBoxNameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBoxNameCustomer.Location = new System.Drawing.Point(242, 136);
            this.uiTextBoxNameCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxNameCustomer.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxNameCustomer.Name = "uiTextBoxNameCustomer";
            this.uiTextBoxNameCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxNameCustomer.ShowText = false;
            this.uiTextBoxNameCustomer.Size = new System.Drawing.Size(307, 45);
            this.uiTextBoxNameCustomer.TabIndex = 15;
            this.uiTextBoxNameCustomer.Text = "uiTextBox2";
            this.uiTextBoxNameCustomer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxNameCustomer.Watermark = "";
            // 
            // uiTextBoxPhoneNumber
            // 
            this.uiTextBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBoxPhoneNumber.Location = new System.Drawing.Point(242, 228);
            this.uiTextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxPhoneNumber.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxPhoneNumber.Name = "uiTextBoxPhoneNumber";
            this.uiTextBoxPhoneNumber.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxPhoneNumber.ShowText = false;
            this.uiTextBoxPhoneNumber.Size = new System.Drawing.Size(307, 45);
            this.uiTextBoxPhoneNumber.TabIndex = 15;
            this.uiTextBoxPhoneNumber.Text = "uiTextBox3";
            this.uiTextBoxPhoneNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxPhoneNumber.Watermark = "";
            // 
            // uiTextBoxAddress
            // 
            this.uiTextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBoxAddress.Location = new System.Drawing.Point(242, 320);
            this.uiTextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxAddress.Name = "uiTextBoxAddress";
            this.uiTextBoxAddress.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxAddress.ShowText = false;
            this.uiTextBoxAddress.Size = new System.Drawing.Size(307, 45);
            this.uiTextBoxAddress.TabIndex = 15;
            this.uiTextBoxAddress.Text = "uiTextBox4";
            this.uiTextBoxAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxAddress.Watermark = "";
            // 
            // uiTextBoxSearch
            // 
            this.uiTextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBoxSearch.Location = new System.Drawing.Point(42, 570);
            this.uiTextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxSearch.Name = "uiTextBoxSearch";
            this.uiTextBoxSearch.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxSearch.ShowText = false;
            this.uiTextBoxSearch.Size = new System.Drawing.Size(339, 45);
            this.uiTextBoxSearch.TabIndex = 16;
            this.uiTextBoxSearch.Text = "uiTextBox4";
            this.uiTextBoxSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxSearch.Watermark = "";
            // 
            // uiButtonSearch
            // 
            this.uiButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonSearch.Location = new System.Drawing.Point(412, 560);
            this.uiButtonSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSearch.Name = "uiButtonSearch";
            this.uiButtonSearch.Size = new System.Drawing.Size(137, 69);
            this.uiButtonSearch.TabIndex = 17;
            this.uiButtonSearch.Text = "Tìm kiếm";
            this.uiButtonSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButtonSearch.Click += new System.EventHandler(this.uiButtonSearch_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 721);
            this.Controls.Add(this.uiButtonSearch);
            this.Controls.Add(this.uiTextBoxSearch);
            this.Controls.Add(this.uiTextBoxAddress);
            this.Controls.Add(this.uiTextBoxPhoneNumber);
            this.Controls.Add(this.uiTextBoxNameCustomer);
            this.Controls.Add(this.uiTextBoxIdCustomer);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiRadioButton_Delete);
            this.Controls.Add(this.uiRadioButton_Update);
            this.Controls.Add(this.uiRadioButton_Insert);
            this.Controls.Add(this.uiButton_Delete);
            this.Controls.Add(this.uiButton_Update);
            this.Controls.Add(this.uiButton_Insert);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton uiButton_Insert;
        private Sunny.UI.UIButton uiButton_Update;
        private Sunny.UI.UIButton uiButton_Delete;
        private Sunny.UI.UIRadioButton uiRadioButton_Insert;
        private Sunny.UI.UIRadioButton uiRadioButton_Update;
        private Sunny.UI.UIRadioButton uiRadioButton_Delete;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView uiDataGridViewCustomer;
        private Sunny.UI.UITextBox uiTextBoxIdCustomer;
        private Sunny.UI.UITextBox uiTextBoxNameCustomer;
        private Sunny.UI.UITextBox uiTextBoxPhoneNumber;
        private Sunny.UI.UITextBox uiTextBoxAddress;
        private Sunny.UI.UITextBox uiTextBoxSearch;
        private Sunny.UI.UIButton uiButtonSearch;
    }
}