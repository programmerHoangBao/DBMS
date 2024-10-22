namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.DetailBillViews
{
    partial class Form_ManagerDetailBill
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uiButtonUpdateDetailBill = new Sunny.UI.UIButton();
            this.uiButtonSearchBill = new Sunny.UI.UIButton();
            this.uiButtonRefresh = new Sunny.UI.UIButton();
            this.uiButtonDeleteDetailBill = new Sunny.UI.UIButton();
            this.uiButtonInsertDetailBill = new Sunny.UI.UIButton();
            this.uiPanelButton = new Sunny.UI.UIPanel();
            this.uiTitlePanelSupplier = new Sunny.UI.UITitlePanel();
            this.uiPanelInformationBill = new Sunny.UI.UIPanel();
            this.numeric_quantity = new System.Windows.Forms.NumericUpDown();
            this.cbb_idBill = new Sunny.UI.UIComboBox();
            this.cbb_idProduct = new Sunny.UI.UIComboBox();
            this.uiSymbolLabelInformation = new Sunny.UI.UISymbolLabel();
            this.lbl_idProduct = new Sunny.UI.UILabel();
            this.lbl_idBill = new Sunny.UI.UILabel();
            this.lbl_quantity = new Sunny.UI.UILabel();
            this.uiPanelSearch = new Sunny.UI.UIPanel();
            this.uiSymbolLabelSearch = new Sunny.UI.UISymbolLabel();
            this.uiLabelSearchTerm = new Sunny.UI.UILabel();
            this.uiTextBoxSearchTerm = new Sunny.UI.UITextBox();
            this.dgv_listDetailBill = new Sunny.UI.UIDataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanelButton.SuspendLayout();
            this.uiTitlePanelSupplier.SuspendLayout();
            this.uiPanelInformationBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).BeginInit();
            this.uiPanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listDetailBill)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uiButtonUpdateDetailBill
            // 
            this.uiButtonUpdateDetailBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonUpdateDetailBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonUpdateDetailBill.Location = new System.Drawing.Point(314, 15);
            this.uiButtonUpdateDetailBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonUpdateDetailBill.Name = "uiButtonUpdateDetailBill";
            this.uiButtonUpdateDetailBill.Radius = 32;
            this.uiButtonUpdateDetailBill.Size = new System.Drawing.Size(114, 32);
            this.uiButtonUpdateDetailBill.TabIndex = 0;
            this.uiButtonUpdateDetailBill.Text = "Cập nhật";
            this.uiButtonUpdateDetailBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonSearchBill
            // 
            this.uiButtonSearchBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonSearchBill.Location = new System.Drawing.Point(314, 53);
            this.uiButtonSearchBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSearchBill.Name = "uiButtonSearchBill";
            this.uiButtonSearchBill.Radius = 32;
            this.uiButtonSearchBill.Size = new System.Drawing.Size(114, 32);
            this.uiButtonSearchBill.TabIndex = 0;
            this.uiButtonSearchBill.Text = "Tìm kiếm";
            this.uiButtonSearchBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonRefresh
            // 
            this.uiButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonRefresh.Location = new System.Drawing.Point(190, 94);
            this.uiButtonRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonRefresh.Name = "uiButtonRefresh";
            this.uiButtonRefresh.Radius = 32;
            this.uiButtonRefresh.Size = new System.Drawing.Size(114, 32);
            this.uiButtonRefresh.TabIndex = 0;
            this.uiButtonRefresh.Text = "Làm mới";
            this.uiButtonRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonDeleteDetailBill
            // 
            this.uiButtonDeleteDetailBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonDeleteDetailBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonDeleteDetailBill.Location = new System.Drawing.Point(59, 53);
            this.uiButtonDeleteDetailBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonDeleteDetailBill.Name = "uiButtonDeleteDetailBill";
            this.uiButtonDeleteDetailBill.Radius = 32;
            this.uiButtonDeleteDetailBill.Size = new System.Drawing.Size(114, 32);
            this.uiButtonDeleteDetailBill.TabIndex = 0;
            this.uiButtonDeleteDetailBill.Text = "Xóa";
            this.uiButtonDeleteDetailBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonInsertDetailBill
            // 
            this.uiButtonInsertDetailBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonInsertDetailBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonInsertDetailBill.Location = new System.Drawing.Point(59, 15);
            this.uiButtonInsertDetailBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonInsertDetailBill.Name = "uiButtonInsertDetailBill";
            this.uiButtonInsertDetailBill.Radius = 32;
            this.uiButtonInsertDetailBill.Size = new System.Drawing.Size(114, 32);
            this.uiButtonInsertDetailBill.TabIndex = 0;
            this.uiButtonInsertDetailBill.Text = "Thêm";
            this.uiButtonInsertDetailBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiPanelButton
            // 
            this.uiPanelButton.Controls.Add(this.uiButtonUpdateDetailBill);
            this.uiPanelButton.Controls.Add(this.uiButtonSearchBill);
            this.uiPanelButton.Controls.Add(this.uiButtonRefresh);
            this.uiPanelButton.Controls.Add(this.uiButtonDeleteDetailBill);
            this.uiPanelButton.Controls.Add(this.uiButtonInsertDetailBill);
            this.uiPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelButton.Location = new System.Drawing.Point(0, 278);
            this.uiPanelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelButton.Name = "uiPanelButton";
            this.uiPanelButton.Radius = 1;
            this.uiPanelButton.Size = new System.Drawing.Size(604, 140);
            this.uiPanelButton.TabIndex = 5;
            this.uiPanelButton.Text = null;
            this.uiPanelButton.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanelSupplier
            // 
            this.uiTitlePanelSupplier.Controls.Add(this.uiPanelInformationBill);
            this.uiTitlePanelSupplier.Controls.Add(this.uiPanelSearch);
            this.uiTitlePanelSupplier.Controls.Add(this.uiPanelButton);
            this.uiTitlePanelSupplier.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTitlePanelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTitlePanelSupplier.Location = new System.Drawing.Point(591, 0);
            this.uiTitlePanelSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanelSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanelSupplier.Name = "uiTitlePanelSupplier";
            this.uiTitlePanelSupplier.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiTitlePanelSupplier.Radius = 20;
            this.uiTitlePanelSupplier.ShowText = false;
            this.uiTitlePanelSupplier.Size = new System.Drawing.Size(612, 423);
            this.uiTitlePanelSupplier.TabIndex = 10;
            this.uiTitlePanelSupplier.Text = "Chi Tiết Hóa Đơn";
            this.uiTitlePanelSupplier.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanelInformationBill
            // 
            this.uiPanelInformationBill.Controls.Add(this.numeric_quantity);
            this.uiPanelInformationBill.Controls.Add(this.cbb_idBill);
            this.uiPanelInformationBill.Controls.Add(this.cbb_idProduct);
            this.uiPanelInformationBill.Controls.Add(this.uiSymbolLabelInformation);
            this.uiPanelInformationBill.Controls.Add(this.lbl_idProduct);
            this.uiPanelInformationBill.Controls.Add(this.lbl_idBill);
            this.uiPanelInformationBill.Controls.Add(this.lbl_quantity);
            this.uiPanelInformationBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelInformationBill.Location = new System.Drawing.Point(0, 36);
            this.uiPanelInformationBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelInformationBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelInformationBill.Name = "uiPanelInformationBill";
            this.uiPanelInformationBill.Radius = 4;
            this.uiPanelInformationBill.Size = new System.Drawing.Size(603, 167);
            this.uiPanelInformationBill.TabIndex = 6;
            this.uiPanelInformationBill.Text = null;
            this.uiPanelInformationBill.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeric_quantity
            // 
            this.numeric_quantity.Location = new System.Drawing.Point(155, 123);
            this.numeric_quantity.Name = "numeric_quantity";
            this.numeric_quantity.Size = new System.Drawing.Size(224, 26);
            this.numeric_quantity.TabIndex = 4;
            // 
            // cbb_idBill
            // 
            this.cbb_idBill.DataSource = null;
            this.cbb_idBill.FillColor = System.Drawing.Color.White;
            this.cbb_idBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_idBill.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbb_idBill.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbb_idBill.Location = new System.Drawing.Point(155, 47);
            this.cbb_idBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_idBill.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbb_idBill.Name = "cbb_idBill";
            this.cbb_idBill.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbb_idBill.Size = new System.Drawing.Size(224, 29);
            this.cbb_idBill.SymbolSize = 24;
            this.cbb_idBill.TabIndex = 1;
            this.cbb_idBill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbb_idBill.Watermark = "";
            // 
            // cbb_idProduct
            // 
            this.cbb_idProduct.DataSource = null;
            this.cbb_idProduct.FillColor = System.Drawing.Color.White;
            this.cbb_idProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_idProduct.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbb_idProduct.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbb_idProduct.Location = new System.Drawing.Point(155, 86);
            this.cbb_idProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_idProduct.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbb_idProduct.Name = "cbb_idProduct";
            this.cbb_idProduct.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbb_idProduct.Size = new System.Drawing.Size(224, 29);
            this.cbb_idProduct.SymbolSize = 24;
            this.cbb_idProduct.TabIndex = 1;
            this.cbb_idProduct.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbb_idProduct.Watermark = "";
            // 
            // uiSymbolLabelInformation
            // 
            this.uiSymbolLabelInformation.BackColor = System.Drawing.Color.Lime;
            this.uiSymbolLabelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabelInformation.Location = new System.Drawing.Point(0, 0);
            this.uiSymbolLabelInformation.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabelInformation.Name = "uiSymbolLabelInformation";
            this.uiSymbolLabelInformation.Radius = 70;
            this.uiSymbolLabelInformation.RadiusSides = Sunny.UI.UICornerRadiusSides.RightBottom;
            this.uiSymbolLabelInformation.Size = new System.Drawing.Size(152, 33);
            this.uiSymbolLabelInformation.TabIndex = 3;
            this.uiSymbolLabelInformation.Text = "Thông Tin";
            // 
            // lbl_idProduct
            // 
            this.lbl_idProduct.AutoSize = true;
            this.lbl_idProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_idProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_idProduct.Location = new System.Drawing.Point(3, 86);
            this.lbl_idProduct.Name = "lbl_idProduct";
            this.lbl_idProduct.Size = new System.Drawing.Size(109, 20);
            this.lbl_idProduct.TabIndex = 1;
            this.lbl_idProduct.Text = "Mã sản phẩm:";
            // 
            // lbl_idBill
            // 
            this.lbl_idBill.AutoSize = true;
            this.lbl_idBill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_idBill.Location = new System.Drawing.Point(3, 47);
            this.lbl_idBill.Name = "lbl_idBill";
            this.lbl_idBill.Size = new System.Drawing.Size(97, 20);
            this.lbl_idBill.TabIndex = 1;
            this.lbl_idBill.Text = "Mã hóa đơn:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_quantity.Location = new System.Drawing.Point(3, 125);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(72, 20);
            this.lbl_quantity.TabIndex = 1;
            this.lbl_quantity.Text = "Số lượng";
            // 
            // uiPanelSearch
            // 
            this.uiPanelSearch.Controls.Add(this.uiSymbolLabelSearch);
            this.uiPanelSearch.Controls.Add(this.uiLabelSearchTerm);
            this.uiPanelSearch.Controls.Add(this.uiTextBoxSearchTerm);
            this.uiPanelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelSearch.Location = new System.Drawing.Point(0, 202);
            this.uiPanelSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelSearch.Name = "uiPanelSearch";
            this.uiPanelSearch.Radius = 1;
            this.uiPanelSearch.Size = new System.Drawing.Size(603, 74);
            this.uiPanelSearch.TabIndex = 7;
            this.uiPanelSearch.Text = null;
            this.uiPanelSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabelSearch
            // 
            this.uiSymbolLabelSearch.BackColor = System.Drawing.Color.Lime;
            this.uiSymbolLabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabelSearch.Location = new System.Drawing.Point(0, 3);
            this.uiSymbolLabelSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabelSearch.Name = "uiSymbolLabelSearch";
            this.uiSymbolLabelSearch.Radius = 70;
            this.uiSymbolLabelSearch.RadiusSides = Sunny.UI.UICornerRadiusSides.RightBottom;
            this.uiSymbolLabelSearch.Size = new System.Drawing.Size(152, 33);
            this.uiSymbolLabelSearch.TabIndex = 3;
            this.uiSymbolLabelSearch.Text = "Tìm kiếm";
            // 
            // uiLabelSearchTerm
            // 
            this.uiLabelSearchTerm.AutoSize = true;
            this.uiLabelSearchTerm.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabelSearchTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabelSearchTerm.Location = new System.Drawing.Point(3, 51);
            this.uiLabelSearchTerm.Name = "uiLabelSearchTerm";
            this.uiLabelSearchTerm.Size = new System.Drawing.Size(141, 20);
            this.uiLabelSearchTerm.TabIndex = 1;
            this.uiLabelSearchTerm.Text = "Thông tin tìm kiếm:";
            // 
            // uiTextBoxSearchTerm
            // 
            this.uiTextBoxSearchTerm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBoxSearchTerm.Location = new System.Drawing.Point(155, 43);
            this.uiTextBoxSearchTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxSearchTerm.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxSearchTerm.Name = "uiTextBoxSearchTerm";
            this.uiTextBoxSearchTerm.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxSearchTerm.ShowText = false;
            this.uiTextBoxSearchTerm.Size = new System.Drawing.Size(211, 29);
            this.uiTextBoxSearchTerm.TabIndex = 2;
            this.uiTextBoxSearchTerm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxSearchTerm.Watermark = "";
            // 
            // dgv_listDetailBill
            // 
            this.dgv_listDetailBill.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_listDetailBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listDetailBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_listDetailBill.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listDetailBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listDetailBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listDetailBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listDetailBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_listDetailBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listDetailBill.EnableHeadersVisualStyles = false;
            this.dgv_listDetailBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_listDetailBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_listDetailBill.Location = new System.Drawing.Point(0, 0);
            this.dgv_listDetailBill.Name = "dgv_listDetailBill";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listDetailBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_listDetailBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_listDetailBill.SelectedIndex = -1;
            this.dgv_listDetailBill.Size = new System.Drawing.Size(591, 423);
            this.dgv_listDetailBill.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_listDetailBill.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.dgv_listDetailBill);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(591, 423);
            this.uiPanel1.TabIndex = 9;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_ManagerDetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 423);
            this.Controls.Add(this.uiTitlePanelSupplier);
            this.Controls.Add(this.uiPanel1);
            this.Name = "Form_ManagerDetailBill";
            this.Text = "Form_ManagerDetailBill";
            this.Load += new System.EventHandler(this.Form_ManagerDetailBill_Load);
            this.uiPanelButton.ResumeLayout(false);
            this.uiTitlePanelSupplier.ResumeLayout(false);
            this.uiPanelInformationBill.ResumeLayout(false);
            this.uiPanelInformationBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).EndInit();
            this.uiPanelSearch.ResumeLayout(false);
            this.uiPanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listDetailBill)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIButton uiButtonUpdateDetailBill;
        private Sunny.UI.UIButton uiButtonSearchBill;
        private Sunny.UI.UIButton uiButtonRefresh;
        private Sunny.UI.UIButton uiButtonDeleteDetailBill;
        private Sunny.UI.UIButton uiButtonInsertDetailBill;
        private Sunny.UI.UIPanel uiPanelButton;
        private Sunny.UI.UITitlePanel uiTitlePanelSupplier;
        private Sunny.UI.UIPanel uiPanelInformationBill;
        private Sunny.UI.UIComboBox cbb_idProduct;
        private Sunny.UI.UISymbolLabel uiSymbolLabelInformation;
        private Sunny.UI.UILabel lbl_idProduct;
        private Sunny.UI.UILabel lbl_idBill;
        private Sunny.UI.UILabel lbl_quantity;
        private Sunny.UI.UIPanel uiPanelSearch;
        private Sunny.UI.UISymbolLabel uiSymbolLabelSearch;
        private Sunny.UI.UILabel uiLabelSearchTerm;
        private Sunny.UI.UITextBox uiTextBoxSearchTerm;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cbb_idBill;
        private System.Windows.Forms.NumericUpDown numeric_quantity;
        public Sunny.UI.UIDataGridView dgv_listDetailBill;
    }
}