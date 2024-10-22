namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.BillViews
{
    partial class Form_ManagerBill
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
            this.cbb_selectTypeBill = new Sunny.UI.UIComboBox();
            this.uiSymbolLabelSearch = new Sunny.UI.UISymbolLabel();
            this.uiLabelSearchTerm = new Sunny.UI.UILabel();
            this.uiTextBoxSearchTerm = new Sunny.UI.UITextBox();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.cbb_typeBill = new Sunny.UI.UIComboBox();
            this.uiSymbolLabelInformation = new Sunny.UI.UISymbolLabel();
            this.lbl_typeBill = new Sunny.UI.UILabel();
            this.lbl_idBill = new Sunny.UI.UILabel();
            this.txt_idSupOrCus = new Sunny.UI.UITextBox();
            this.lbl_idSupOrCus = new Sunny.UI.UILabel();
            this.txt_idBill = new Sunny.UI.UITextBox();
            this.uiLabelAddress = new Sunny.UI.UILabel();
            this.uiButtonUpdateBill = new Sunny.UI.UIButton();
            this.uiButtonSearchBill = new Sunny.UI.UIButton();
            this.uiButtonRefresh = new Sunny.UI.UIButton();
            this.uiButtonDeleteBill = new Sunny.UI.UIButton();
            this.uiButtonInsertBill = new Sunny.UI.UIButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uiPanelInformationBill = new Sunny.UI.UIPanel();
            this.uiPanelSearch = new Sunny.UI.UIPanel();
            this.uiPanelButton = new Sunny.UI.UIPanel();
            this.uiTitlePanelBill = new Sunny.UI.UITitlePanel();
            this.uiPanelSelectAndShowData = new Sunny.UI.UIPanel();
            this.uiPanelSelect = new Sunny.UI.UIPanel();
            this.dgv_listbill = new Sunny.UI.UIDataGridView();
            this.uiPanelInformationBill.SuspendLayout();
            this.uiPanelSearch.SuspendLayout();
            this.uiPanelButton.SuspendLayout();
            this.uiTitlePanelBill.SuspendLayout();
            this.uiPanelSelectAndShowData.SuspendLayout();
            this.uiPanelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbill)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_selectTypeBill
            // 
            this.cbb_selectTypeBill.DataSource = null;
            this.cbb_selectTypeBill.FillColor = System.Drawing.Color.White;
            this.cbb_selectTypeBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_selectTypeBill.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbb_selectTypeBill.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbb_selectTypeBill.Location = new System.Drawing.Point(13, 14);
            this.cbb_selectTypeBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_selectTypeBill.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbb_selectTypeBill.Name = "cbb_selectTypeBill";
            this.cbb_selectTypeBill.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbb_selectTypeBill.Size = new System.Drawing.Size(150, 29);
            this.cbb_selectTypeBill.SymbolSize = 24;
            this.cbb_selectTypeBill.TabIndex = 1;
            this.cbb_selectTypeBill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbb_selectTypeBill.Watermark = "";
            this.cbb_selectTypeBill.SelectedIndexChanged += new System.EventHandler(this.cbb_selectTypeBill_SelectedIndexChanged);
            // 
            // uiSymbolLabelSearch
            // 
            this.uiSymbolLabelSearch.BackColor = System.Drawing.Color.Lime;
            this.uiSymbolLabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabelSearch.Location = new System.Drawing.Point(3, 3);
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
            this.uiLabelSearchTerm.Location = new System.Drawing.Point(49, 73);
            this.uiLabelSearchTerm.Name = "uiLabelSearchTerm";
            this.uiLabelSearchTerm.Size = new System.Drawing.Size(216, 29);
            this.uiLabelSearchTerm.TabIndex = 1;
            this.uiLabelSearchTerm.Text = "Thông tin tìm kiếm:";
            // 
            // uiTextBoxSearchTerm
            // 
            this.uiTextBoxSearchTerm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBoxSearchTerm.Location = new System.Drawing.Point(272, 73);
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
            // uiListBox1
            // 
            this.uiListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiListBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.White;
            this.uiListBox1.Location = new System.Drawing.Point(256, 184);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.ShowText = false;
            this.uiListBox1.Size = new System.Drawing.Size(224, 81);
            this.uiListBox1.TabIndex = 6;
            this.uiListBox1.Text = "uiListBox1";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiButton1.Location = new System.Drawing.Point(487, 184);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 30;
            this.uiButton1.Size = new System.Drawing.Size(155, 44);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "Chọn sản phẩm";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // cbb_typeBill
            // 
            this.cbb_typeBill.DataSource = null;
            this.cbb_typeBill.FillColor = System.Drawing.Color.White;
            this.cbb_typeBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_typeBill.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbb_typeBill.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbb_typeBill.Location = new System.Drawing.Point(256, 100);
            this.cbb_typeBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_typeBill.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbb_typeBill.Name = "cbb_typeBill";
            this.cbb_typeBill.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbb_typeBill.Size = new System.Drawing.Size(224, 29);
            this.cbb_typeBill.SymbolSize = 24;
            this.cbb_typeBill.TabIndex = 1;
            this.cbb_typeBill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbb_typeBill.Watermark = "";
            this.cbb_typeBill.SelectedIndexChanged += new System.EventHandler(this.cbb_typeBill_SelectedIndexChanged);
            // 
            // uiSymbolLabelInformation
            // 
            this.uiSymbolLabelInformation.BackColor = System.Drawing.Color.Lime;
            this.uiSymbolLabelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabelInformation.Location = new System.Drawing.Point(3, 3);
            this.uiSymbolLabelInformation.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabelInformation.Name = "uiSymbolLabelInformation";
            this.uiSymbolLabelInformation.Radius = 70;
            this.uiSymbolLabelInformation.RadiusSides = Sunny.UI.UICornerRadiusSides.RightBottom;
            this.uiSymbolLabelInformation.Size = new System.Drawing.Size(152, 33);
            this.uiSymbolLabelInformation.TabIndex = 3;
            this.uiSymbolLabelInformation.Text = "Thông Tin";
            // 
            // lbl_typeBill
            // 
            this.lbl_typeBill.AutoSize = true;
            this.lbl_typeBill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_typeBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_typeBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_typeBill.Location = new System.Drawing.Point(28, 100);
            this.lbl_typeBill.Name = "lbl_typeBill";
            this.lbl_typeBill.Size = new System.Drawing.Size(158, 29);
            this.lbl_typeBill.TabIndex = 1;
            this.lbl_typeBill.Text = "Loại hóa đơn:";
            // 
            // lbl_idBill
            // 
            this.lbl_idBill.AutoSize = true;
            this.lbl_idBill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_idBill.Location = new System.Drawing.Point(28, 61);
            this.lbl_idBill.Name = "lbl_idBill";
            this.lbl_idBill.Size = new System.Drawing.Size(145, 29);
            this.lbl_idBill.TabIndex = 1;
            this.lbl_idBill.Text = "Mã hóa đơn:";
            // 
            // txt_idSupOrCus
            // 
            this.txt_idSupOrCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idSupOrCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_idSupOrCus.Location = new System.Drawing.Point(256, 139);
            this.txt_idSupOrCus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idSupOrCus.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_idSupOrCus.Name = "txt_idSupOrCus";
            this.txt_idSupOrCus.Padding = new System.Windows.Forms.Padding(5);
            this.txt_idSupOrCus.ShowText = false;
            this.txt_idSupOrCus.Size = new System.Drawing.Size(224, 29);
            this.txt_idSupOrCus.TabIndex = 2;
            this.txt_idSupOrCus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_idSupOrCus.Watermark = "";
            // 
            // lbl_idSupOrCus
            // 
            this.lbl_idSupOrCus.AutoSize = true;
            this.lbl_idSupOrCus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idSupOrCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_idSupOrCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_idSupOrCus.Location = new System.Drawing.Point(28, 139);
            this.lbl_idSupOrCus.Name = "lbl_idSupOrCus";
            this.lbl_idSupOrCus.Size = new System.Drawing.Size(200, 29);
            this.lbl_idSupOrCus.TabIndex = 1;
            this.lbl_idSupOrCus.Text = "Mã nhà cung cấp:";
            // 
            // txt_idBill
            // 
            this.txt_idBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_idBill.Location = new System.Drawing.Point(256, 61);
            this.txt_idBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idBill.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_idBill.Name = "txt_idBill";
            this.txt_idBill.Padding = new System.Windows.Forms.Padding(5);
            this.txt_idBill.ShowText = false;
            this.txt_idBill.Size = new System.Drawing.Size(224, 29);
            this.txt_idBill.TabIndex = 2;
            this.txt_idBill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_idBill.Watermark = "";
            // 
            // uiLabelAddress
            // 
            this.uiLabelAddress.AutoSize = true;
            this.uiLabelAddress.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabelAddress.Location = new System.Drawing.Point(28, 184);
            this.uiLabelAddress.Name = "uiLabelAddress";
            this.uiLabelAddress.Size = new System.Drawing.Size(231, 29);
            this.uiLabelAddress.TabIndex = 1;
            this.uiLabelAddress.Text = "Chọn loại sản phẩm:";
            // 
            // uiButtonUpdateBill
            // 
            this.uiButtonUpdateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonUpdateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonUpdateBill.Location = new System.Drawing.Point(412, 19);
            this.uiButtonUpdateBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonUpdateBill.Name = "uiButtonUpdateBill";
            this.uiButtonUpdateBill.Radius = 32;
            this.uiButtonUpdateBill.Size = new System.Drawing.Size(143, 47);
            this.uiButtonUpdateBill.TabIndex = 0;
            this.uiButtonUpdateBill.Text = "Cập nhật";
            this.uiButtonUpdateBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonSearchBill
            // 
            this.uiButtonSearchBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonSearchBill.Location = new System.Drawing.Point(412, 98);
            this.uiButtonSearchBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSearchBill.Name = "uiButtonSearchBill";
            this.uiButtonSearchBill.Radius = 32;
            this.uiButtonSearchBill.Size = new System.Drawing.Size(143, 47);
            this.uiButtonSearchBill.TabIndex = 0;
            this.uiButtonSearchBill.Text = "Tìm kiếm";
            this.uiButtonSearchBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonRefresh
            // 
            this.uiButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonRefresh.Location = new System.Drawing.Point(272, 151);
            this.uiButtonRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonRefresh.Name = "uiButtonRefresh";
            this.uiButtonRefresh.Radius = 32;
            this.uiButtonRefresh.Size = new System.Drawing.Size(143, 47);
            this.uiButtonRefresh.TabIndex = 0;
            this.uiButtonRefresh.Text = "Làm mới";
            this.uiButtonRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonDeleteBill
            // 
            this.uiButtonDeleteBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonDeleteBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonDeleteBill.Location = new System.Drawing.Point(132, 98);
            this.uiButtonDeleteBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonDeleteBill.Name = "uiButtonDeleteBill";
            this.uiButtonDeleteBill.Radius = 32;
            this.uiButtonDeleteBill.Size = new System.Drawing.Size(143, 47);
            this.uiButtonDeleteBill.TabIndex = 0;
            this.uiButtonDeleteBill.Text = "Xóa";
            this.uiButtonDeleteBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonInsertBill
            // 
            this.uiButtonInsertBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonInsertBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonInsertBill.Location = new System.Drawing.Point(132, 19);
            this.uiButtonInsertBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonInsertBill.Name = "uiButtonInsertBill";
            this.uiButtonInsertBill.Radius = 32;
            this.uiButtonInsertBill.Size = new System.Drawing.Size(143, 47);
            this.uiButtonInsertBill.TabIndex = 0;
            this.uiButtonInsertBill.Text = "Thêm";
            this.uiButtonInsertBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButtonInsertBill.Click += new System.EventHandler(this.uiButtonInsertSupplier_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uiPanelInformationBill
            // 
            this.uiPanelInformationBill.Controls.Add(this.uiSymbolLabelInformation);
            this.uiPanelInformationBill.Controls.Add(this.txt_idBill);
            this.uiPanelInformationBill.Controls.Add(this.uiListBox1);
            this.uiPanelInformationBill.Controls.Add(this.txt_idSupOrCus);
            this.uiPanelInformationBill.Controls.Add(this.lbl_idBill);
            this.uiPanelInformationBill.Controls.Add(this.lbl_idSupOrCus);
            this.uiPanelInformationBill.Controls.Add(this.lbl_typeBill);
            this.uiPanelInformationBill.Controls.Add(this.uiLabelAddress);
            this.uiPanelInformationBill.Controls.Add(this.cbb_typeBill);
            this.uiPanelInformationBill.Controls.Add(this.uiButton1);
            this.uiPanelInformationBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelInformationBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelInformationBill.Location = new System.Drawing.Point(0, 40);
            this.uiPanelInformationBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelInformationBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelInformationBill.Name = "uiPanelInformationBill";
            this.uiPanelInformationBill.Size = new System.Drawing.Size(656, 336);
            this.uiPanelInformationBill.TabIndex = 0;
            this.uiPanelInformationBill.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanelSearch
            // 
            this.uiPanelSearch.Controls.Add(this.uiSymbolLabelSearch);
            this.uiPanelSearch.Controls.Add(this.uiTextBoxSearchTerm);
            this.uiPanelSearch.Controls.Add(this.uiLabelSearchTerm);
            this.uiPanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelSearch.Location = new System.Drawing.Point(0, 376);
            this.uiPanelSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelSearch.Name = "uiPanelSearch";
            this.uiPanelSearch.Size = new System.Drawing.Size(656, 170);
            this.uiPanelSearch.TabIndex = 1;
            this.uiPanelSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanelButton
            // 
            this.uiPanelButton.AutoSize = true;
            this.uiPanelButton.Controls.Add(this.uiButtonInsertBill);
            this.uiPanelButton.Controls.Add(this.uiButtonUpdateBill);
            this.uiPanelButton.Controls.Add(this.uiButtonDeleteBill);
            this.uiPanelButton.Controls.Add(this.uiButtonSearchBill);
            this.uiPanelButton.Controls.Add(this.uiButtonRefresh);
            this.uiPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelButton.Location = new System.Drawing.Point(0, 546);
            this.uiPanelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelButton.Name = "uiPanelButton";
            this.uiPanelButton.Size = new System.Drawing.Size(656, 292);
            this.uiPanelButton.TabIndex = 1;
            this.uiPanelButton.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanelBill
            // 
            this.uiTitlePanelBill.Controls.Add(this.uiPanelButton);
            this.uiTitlePanelBill.Controls.Add(this.uiPanelSearch);
            this.uiTitlePanelBill.Controls.Add(this.uiPanelInformationBill);
            this.uiTitlePanelBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiTitlePanelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTitlePanelBill.Location = new System.Drawing.Point(974, 0);
            this.uiTitlePanelBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanelBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanelBill.Name = "uiTitlePanelBill";
            this.uiTitlePanelBill.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiTitlePanelBill.Radius = 40;
            this.uiTitlePanelBill.ShowText = false;
            this.uiTitlePanelBill.Size = new System.Drawing.Size(656, 838);
            this.uiTitlePanelBill.TabIndex = 2;
            this.uiTitlePanelBill.Text = "Hóa Đơn";
            this.uiTitlePanelBill.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanelSelectAndShowData
            // 
            this.uiPanelSelectAndShowData.Controls.Add(this.dgv_listbill);
            this.uiPanelSelectAndShowData.Controls.Add(this.uiPanelSelect);
            this.uiPanelSelectAndShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelSelectAndShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelSelectAndShowData.Location = new System.Drawing.Point(0, 0);
            this.uiPanelSelectAndShowData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelSelectAndShowData.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelSelectAndShowData.Name = "uiPanelSelectAndShowData";
            this.uiPanelSelectAndShowData.Size = new System.Drawing.Size(974, 838);
            this.uiPanelSelectAndShowData.TabIndex = 3;
            this.uiPanelSelectAndShowData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanelSelect
            // 
            this.uiPanelSelect.Controls.Add(this.cbb_selectTypeBill);
            this.uiPanelSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelSelect.Location = new System.Drawing.Point(0, 0);
            this.uiPanelSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelSelect.Name = "uiPanelSelect";
            this.uiPanelSelect.Size = new System.Drawing.Size(974, 76);
            this.uiPanelSelect.TabIndex = 0;
            this.uiPanelSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_listbill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_listbill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listbill.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listbill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listbill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listbill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_listbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listbill.EnableHeadersVisualStyles = false;
            this.dgv_listbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_listbill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_listbill.Location = new System.Drawing.Point(0, 76);
            this.dgv_listbill.Name = "dgv_listbill";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listbill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_listbill.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_listbill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_listbill.RowTemplate.Height = 28;
            this.dgv_listbill.SelectedIndex = -1;
            this.dgv_listbill.Size = new System.Drawing.Size(974, 762);
            this.dgv_listbill.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_listbill.TabIndex = 1;
            // 
            // Form_ManagerBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 838);
            this.Controls.Add(this.uiPanelSelectAndShowData);
            this.Controls.Add(this.uiTitlePanelBill);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ManagerBill";
            this.Text = "Form_ManagerBill";
            this.Load += new System.EventHandler(this.Form_ManagerBill_Load);
            this.uiPanelInformationBill.ResumeLayout(false);
            this.uiPanelInformationBill.PerformLayout();
            this.uiPanelSearch.ResumeLayout(false);
            this.uiPanelSearch.PerformLayout();
            this.uiPanelButton.ResumeLayout(false);
            this.uiTitlePanelBill.ResumeLayout(false);
            this.uiTitlePanelBill.PerformLayout();
            this.uiPanelSelectAndShowData.ResumeLayout(false);
            this.uiPanelSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIComboBox cbb_selectTypeBill;
        private Sunny.UI.UISymbolLabel uiSymbolLabelSearch;
        private Sunny.UI.UILabel uiLabelSearchTerm;
        private Sunny.UI.UITextBox uiTextBoxSearchTerm;
        private Sunny.UI.UISymbolLabel uiSymbolLabelInformation;
        private Sunny.UI.UILabel lbl_typeBill;
        private Sunny.UI.UILabel lbl_idBill;
        private Sunny.UI.UITextBox txt_idSupOrCus;
        private Sunny.UI.UILabel lbl_idSupOrCus;
        private Sunny.UI.UIButton uiButtonUpdateBill;
        private Sunny.UI.UIButton uiButtonSearchBill;
        private Sunny.UI.UIButton uiButtonRefresh;
        private Sunny.UI.UIButton uiButtonDeleteBill;
        private Sunny.UI.UIButton uiButtonInsertBill;
        private Sunny.UI.UITextBox txt_idBill;
        private Sunny.UI.UIComboBox cbb_typeBill;
        private Sunny.UI.UIListBox uiListBox1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabelAddress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIPanel uiPanelButton;
        private Sunny.UI.UIPanel uiPanelSearch;
        private Sunny.UI.UIPanel uiPanelInformationBill;
        private Sunny.UI.UITitlePanel uiTitlePanelBill;
        private Sunny.UI.UIPanel uiPanelSelectAndShowData;
        private Sunny.UI.UIDataGridView dgv_listbill;
        private Sunny.UI.UIPanel uiPanelSelect;
    }
}