namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.ExpenseSlipView
{
    partial class Form_ExpenseSlipManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.labelTotalMoney = new Sunny.UI.UILabel();
            this.buttonFillReceive = new Sunny.UI.UIButton();
            this.buttonSpend = new Sunny.UI.UIButton();
            this.buttonRefresh = new Sunny.UI.UIButton();
            this.datePickerDayCreate = new Sunny.UI.UIDatePicker();
            this.textBoxID = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.textBoxTotalMoney = new Sunny.UI.UITextBox();
            this.textBoxSearchProduct = new Sunny.UI.UITextBox();
            this.textBoxContent = new Sunny.UI.UITextBox();
            this.buttonSearch = new Sunny.UI.UIButton();
            this.comBoBoxTypeExpenseSlip = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.buttonDelete = new Sunny.UI.UIButton();
            this.buttonAdd = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.buttonUpdate = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.dataGridViewExpenseSlip = new Sunny.UI.UIDataGridView();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseSlip)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.labelTotalMoney);
            this.uiPanel1.Controls.Add(this.buttonFillReceive);
            this.uiPanel1.Controls.Add(this.buttonSpend);
            this.uiPanel1.Controls.Add(this.buttonRefresh);
            this.uiPanel1.Controls.Add(this.datePickerDayCreate);
            this.uiPanel1.Controls.Add(this.textBoxID);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.textBoxTotalMoney);
            this.uiPanel1.Controls.Add(this.textBoxSearchProduct);
            this.uiPanel1.Controls.Add(this.textBoxContent);
            this.uiPanel1.Controls.Add(this.buttonSearch);
            this.uiPanel1.Controls.Add(this.comBoBoxTypeExpenseSlip);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.buttonDelete);
            this.uiPanel1.Controls.Add(this.buttonAdd);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.buttonUpdate);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(866, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(385, 614);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.labelTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelTotalMoney.Location = new System.Drawing.Point(138, 550);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(224, 45);
            this.labelTotalMoney.TabIndex = 64;
            this.labelTotalMoney.Text = "Tổng: ";
            // 
            // buttonFillReceive
            // 
            this.buttonFillReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFillReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFillReceive.Location = new System.Drawing.Point(35, 379);
            this.buttonFillReceive.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonFillReceive.Name = "buttonFillReceive";
            this.buttonFillReceive.Size = new System.Drawing.Size(130, 45);
            this.buttonFillReceive.TabIndex = 63;
            this.buttonFillReceive.Text = "Lọc phiếu thu";
            this.buttonFillReceive.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonFillReceive.Click += new System.EventHandler(this.buttonFillReceive_Click);
            // 
            // buttonSpend
            // 
            this.buttonSpend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSpend.Location = new System.Drawing.Point(178, 379);
            this.buttonSpend.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonSpend.Name = "buttonSpend";
            this.buttonSpend.Size = new System.Drawing.Size(130, 45);
            this.buttonSpend.TabIndex = 62;
            this.buttonSpend.Text = "Lọc phiếu chi";
            this.buttonSpend.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSpend.Click += new System.EventHandler(this.buttonSpend_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRefresh.Location = new System.Drawing.Point(35, 450);
            this.buttonRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(102, 45);
            this.buttonRefresh.TabIndex = 61;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // datePickerDayCreate
            // 
            this.datePickerDayCreate.FillColor = System.Drawing.Color.White;
            this.datePickerDayCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerDayCreate.Location = new System.Drawing.Point(170, 62);
            this.datePickerDayCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePickerDayCreate.MaxLength = 10;
            this.datePickerDayCreate.MinimumSize = new System.Drawing.Size(63, 0);
            this.datePickerDayCreate.Name = "datePickerDayCreate";
            this.datePickerDayCreate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.datePickerDayCreate.Size = new System.Drawing.Size(200, 29);
            this.datePickerDayCreate.SymbolDropDown = 61555;
            this.datePickerDayCreate.SymbolNormal = 61555;
            this.datePickerDayCreate.SymbolSize = 24;
            this.datePickerDayCreate.TabIndex = 60;
            this.datePickerDayCreate.Text = "2024-10-21";
            this.datePickerDayCreate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.datePickerDayCreate.Value = new System.DateTime(2024, 10, 21, 19, 34, 40, 157);
            this.datePickerDayCreate.Watermark = "";
            // 
            // textBoxID
            // 
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(170, 14);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxID.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxID.ShowText = false;
            this.textBoxID.Size = new System.Drawing.Size(200, 29);
            this.textBoxID.TabIndex = 50;
            this.textBoxID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxID.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(12, 68);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(130, 23);
            this.uiLabel2.TabIndex = 45;
            this.uiLabel2.Text = "Ngày tạo:";
            // 
            // textBoxTotalMoney
            // 
            this.textBoxTotalMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalMoney.Location = new System.Drawing.Point(170, 203);
            this.textBoxTotalMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotalMoney.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxTotalMoney.Name = "textBoxTotalMoney";
            this.textBoxTotalMoney.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxTotalMoney.ShowText = false;
            this.textBoxTotalMoney.Size = new System.Drawing.Size(200, 29);
            this.textBoxTotalMoney.TabIndex = 51;
            this.textBoxTotalMoney.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxTotalMoney.Watermark = "";
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearchProduct.Location = new System.Drawing.Point(35, 329);
            this.textBoxSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearchProduct.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxSearchProduct.ShowText = false;
            this.textBoxSearchProduct.Size = new System.Drawing.Size(220, 29);
            this.textBoxSearchProduct.TabIndex = 59;
            this.textBoxSearchProduct.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxSearchProduct.Watermark = "";
            // 
            // textBoxContent
            // 
            this.textBoxContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContent.Location = new System.Drawing.Point(170, 110);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContent.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxContent.ShowText = false;
            this.textBoxContent.Size = new System.Drawing.Size(200, 29);
            this.textBoxContent.TabIndex = 52;
            this.textBoxContent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxContent.Watermark = "";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSearch.Location = new System.Drawing.Point(271, 329);
            this.buttonSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 29);
            this.buttonSearch.TabIndex = 58;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comBoBoxTypeExpenseSlip
            // 
            this.comBoBoxTypeExpenseSlip.DataSource = null;
            this.comBoBoxTypeExpenseSlip.FillColor = System.Drawing.Color.White;
            this.comBoBoxTypeExpenseSlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoBoxTypeExpenseSlip.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comBoBoxTypeExpenseSlip.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comBoBoxTypeExpenseSlip.Location = new System.Drawing.Point(170, 158);
            this.comBoBoxTypeExpenseSlip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBoBoxTypeExpenseSlip.MinimumSize = new System.Drawing.Size(63, 0);
            this.comBoBoxTypeExpenseSlip.Name = "comBoBoxTypeExpenseSlip";
            this.comBoBoxTypeExpenseSlip.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comBoBoxTypeExpenseSlip.Size = new System.Drawing.Size(200, 29);
            this.comBoBoxTypeExpenseSlip.SymbolSize = 24;
            this.comBoBoxTypeExpenseSlip.TabIndex = 54;
            this.comBoBoxTypeExpenseSlip.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comBoBoxTypeExpenseSlip.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(13, 20);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(130, 23);
            this.uiLabel1.TabIndex = 46;
            this.uiLabel1.Text = "ID Hóa đơn:";
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(13, 209);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(130, 23);
            this.uiLabel5.TabIndex = 47;
            this.uiLabel5.Text = "Tổng tiền:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(271, 257);
            this.buttonDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 45);
            this.buttonDelete.TabIndex = 55;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(35, 257);
            this.buttonAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 45);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(13, 116);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(130, 23);
            this.uiLabel3.TabIndex = 48;
            this.uiLabel3.Text = "Nội dung:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(12, 164);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(130, 23);
            this.uiLabel4.TabIndex = 49;
            this.uiLabel4.Text = "Loại hóa đơn:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(153, 257);
            this.buttonUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(99, 45);
            this.buttonUpdate.TabIndex = 57;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.dataGridViewExpenseSlip);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(866, 614);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = "uiPanel2";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewExpenseSlip
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridViewExpenseSlip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExpenseSlip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpenseSlip.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExpenseSlip.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpenseSlip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExpenseSlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpenseSlip.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewExpenseSlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExpenseSlip.EnableHeadersVisualStyles = false;
            this.dataGridViewExpenseSlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataGridViewExpenseSlip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridViewExpenseSlip.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExpenseSlip.Name = "dataGridViewExpenseSlip";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpenseSlip.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewExpenseSlip.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataGridViewExpenseSlip.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewExpenseSlip.RowTemplate.Height = 24;
            this.dataGridViewExpenseSlip.SelectedIndex = -1;
            this.dataGridViewExpenseSlip.Size = new System.Drawing.Size(866, 614);
            this.dataGridViewExpenseSlip.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridViewExpenseSlip.TabIndex = 0;
            this.dataGridViewExpenseSlip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpenseSlip_CellClick);
            // 
            // Form_ExpenseSlipManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 614);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "Form_ExpenseSlipManager";
            this.Text = "Form_ExpenseSlipManager";
            this.Load += new System.EventHandler(this.Form_ExpenseSlipManager_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseSlip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIDataGridView dataGridViewExpenseSlip;
        private Sunny.UI.UITextBox textBoxID;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox textBoxTotalMoney;
        private Sunny.UI.UITextBox textBoxSearchProduct;
        private Sunny.UI.UITextBox textBoxContent;
        private Sunny.UI.UIButton buttonSearch;
        private Sunny.UI.UIComboBox comBoBoxTypeExpenseSlip;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton buttonDelete;
        private Sunny.UI.UIButton buttonAdd;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton buttonUpdate;
        private Sunny.UI.UIDatePicker datePickerDayCreate;
        private Sunny.UI.UIButton buttonRefresh;
        private Sunny.UI.UILabel labelTotalMoney;
        private Sunny.UI.UIButton buttonFillReceive;
        private Sunny.UI.UIButton buttonSpend;
    }
}