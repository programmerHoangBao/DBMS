namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.BillViews
{
    partial class Form_ManagerBIll
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
            this.dgv_listbill = new Sunny.UI.UIDataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.cbb_selectTypeBill = new Sunny.UI.UIComboBox();
            this.uiPanelSearch = new Sunny.UI.UIPanel();
            this.uiSymbolLabelSearch = new Sunny.UI.UISymbolLabel();
            this.uiLabelSearchTerm = new Sunny.UI.UILabel();
            this.uiTextBoxSearchTerm = new Sunny.UI.UITextBox();
            this.uiPanelInformationBill = new Sunny.UI.UIPanel();
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
            this.uiPanelButton = new Sunny.UI.UIPanel();
            this.uiButtonUpdateBill = new Sunny.UI.UIButton();
            this.uiButtonSearchBill = new Sunny.UI.UIButton();
            this.uiButtonRefresh = new Sunny.UI.UIButton();
            this.uiButtonDeleteBill = new Sunny.UI.UIButton();
            this.uiButtonInsertBill = new Sunny.UI.UIButton();
            this.uiTitlePanelSupplier = new Sunny.UI.UITitlePanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbill)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanelSearch.SuspendLayout();
            this.uiPanelInformationBill.SuspendLayout();
            this.uiPanelButton.SuspendLayout();
            this.uiTitlePanelSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_listbill
            // 
            this.dgv_listbill.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_listbill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_listbill.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listbill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listbill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listbill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_listbill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_listbill.EnableHeadersVisualStyles = false;
            this.dgv_listbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_listbill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_listbill.Location = new System.Drawing.Point(0, 52);
            this.dgv_listbill.Name = "dgv_listbill";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listbill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_listbill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_listbill.SelectedIndex = -1;
            this.dgv_listbill.Size = new System.Drawing.Size(591, 493);
            this.dgv_listbill.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_listbill.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.cbb_selectTypeBill);
            this.uiPanel1.Controls.Add(this.dgv_listbill);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(591, 545);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_selectTypeBill
            // 
            this.cbb_selectTypeBill.DataSource = null;
            this.cbb_selectTypeBill.FillColor = System.Drawing.Color.White;
            this.cbb_selectTypeBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_selectTypeBill.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbb_selectTypeBill.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbb_selectTypeBill.Location = new System.Drawing.Point(13, 12);
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
            // uiPanelSearch
            // 
            this.uiPanelSearch.Controls.Add(this.uiSymbolLabelSearch);
            this.uiPanelSearch.Controls.Add(this.uiLabelSearchTerm);
            this.uiPanelSearch.Controls.Add(this.uiTextBoxSearchTerm);
            this.uiPanelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelSearch.Location = new System.Drawing.Point(0, 303);
            this.uiPanelSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelSearch.Name = "uiPanelSearch";
            this.uiPanelSearch.Radius = 1;
            this.uiPanelSearch.Size = new System.Drawing.Size(603, 106);
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
            // uiPanelInformationBill
            // 
            this.uiPanelInformationBill.Controls.Add(this.uiListBox1);
            this.uiPanelInformationBill.Controls.Add(this.uiButton1);
            this.uiPanelInformationBill.Controls.Add(this.cbb_typeBill);
            this.uiPanelInformationBill.Controls.Add(this.uiSymbolLabelInformation);
            this.uiPanelInformationBill.Controls.Add(this.lbl_typeBill);
            this.uiPanelInformationBill.Controls.Add(this.lbl_idBill);
            this.uiPanelInformationBill.Controls.Add(this.txt_idSupOrCus);
            this.uiPanelInformationBill.Controls.Add(this.lbl_idSupOrCus);
            this.uiPanelInformationBill.Controls.Add(this.txt_idBill);
            this.uiPanelInformationBill.Controls.Add(this.uiLabelAddress);
            this.uiPanelInformationBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelInformationBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelInformationBill.Location = new System.Drawing.Point(0, 40);
            this.uiPanelInformationBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelInformationBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelInformationBill.Name = "uiPanelInformationBill";
            this.uiPanelInformationBill.Size = new System.Drawing.Size(603, 271);
            this.uiPanelInformationBill.TabIndex = 6;
            this.uiPanelInformationBill.Text = null;
            this.uiPanelInformationBill.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiListBox1
            // 
            this.uiListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiListBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.White;
            this.uiListBox1.Location = new System.Drawing.Point(155, 170);
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
            this.uiButton1.Location = new System.Drawing.Point(386, 170);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(109, 32);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "Chọn sản phẩm";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // cbb_typeBill
            // 
            this.cbb_typeBill.DataSource = null;
            this.cbb_typeBill.FillColor = System.Drawing.Color.White;
            this.cbb_typeBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_typeBill.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbb_typeBill.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbb_typeBill.Location = new System.Drawing.Point(155, 86);
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
            this.uiSymbolLabelInformation.Location = new System.Drawing.Point(0, 0);
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
            this.lbl_typeBill.Location = new System.Drawing.Point(3, 86);
            this.lbl_typeBill.Name = "lbl_typeBill";
            this.lbl_typeBill.Size = new System.Drawing.Size(105, 20);
            this.lbl_typeBill.TabIndex = 1;
            this.lbl_typeBill.Text = "Loại hóa đơn:";
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
            // txt_idSupOrCus
            // 
            this.txt_idSupOrCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idSupOrCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_idSupOrCus.Location = new System.Drawing.Point(155, 125);
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
            this.lbl_idSupOrCus.Location = new System.Drawing.Point(3, 125);
            this.lbl_idSupOrCus.Name = "lbl_idSupOrCus";
            this.lbl_idSupOrCus.Size = new System.Drawing.Size(135, 20);
            this.lbl_idSupOrCus.TabIndex = 1;
            this.lbl_idSupOrCus.Text = "Mã nhà cung cấp:";
            // 
            // txt_idBill
            // 
            this.txt_idBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_idBill.Location = new System.Drawing.Point(155, 47);
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
            this.uiLabelAddress.Location = new System.Drawing.Point(3, 170);
            this.uiLabelAddress.Name = "uiLabelAddress";
            this.uiLabelAddress.Size = new System.Drawing.Size(153, 20);
            this.uiLabelAddress.TabIndex = 1;
            this.uiLabelAddress.Text = "Chọn loại sản phẩm:";
            // 
            // uiPanelButton
            // 
            this.uiPanelButton.Controls.Add(this.uiButtonUpdateBill);
            this.uiPanelButton.Controls.Add(this.uiButtonSearchBill);
            this.uiPanelButton.Controls.Add(this.uiButtonRefresh);
            this.uiPanelButton.Controls.Add(this.uiButtonDeleteBill);
            this.uiPanelButton.Controls.Add(this.uiButtonInsertBill);
            this.uiPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanelButton.Location = new System.Drawing.Point(0, 409);
            this.uiPanelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelButton.Name = "uiPanelButton";
            this.uiPanelButton.Radius = 1;
            this.uiPanelButton.Size = new System.Drawing.Size(603, 136);
            this.uiPanelButton.TabIndex = 5;
            this.uiPanelButton.Text = null;
            this.uiPanelButton.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButtonUpdateBill
            // 
            this.uiButtonUpdateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonUpdateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonUpdateBill.Location = new System.Drawing.Point(314, 15);
            this.uiButtonUpdateBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonUpdateBill.Name = "uiButtonUpdateBill";
            this.uiButtonUpdateBill.Radius = 32;
            this.uiButtonUpdateBill.Size = new System.Drawing.Size(114, 32);
            this.uiButtonUpdateBill.TabIndex = 0;
            this.uiButtonUpdateBill.Text = "Cập nhật";
            this.uiButtonUpdateBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            // uiButtonDeleteBill
            // 
            this.uiButtonDeleteBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonDeleteBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonDeleteBill.Location = new System.Drawing.Point(59, 53);
            this.uiButtonDeleteBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonDeleteBill.Name = "uiButtonDeleteBill";
            this.uiButtonDeleteBill.Radius = 32;
            this.uiButtonDeleteBill.Size = new System.Drawing.Size(114, 32);
            this.uiButtonDeleteBill.TabIndex = 0;
            this.uiButtonDeleteBill.Text = "Xóa";
            this.uiButtonDeleteBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButtonInsertBill
            // 
            this.uiButtonInsertBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonInsertBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButtonInsertBill.Location = new System.Drawing.Point(59, 15);
            this.uiButtonInsertBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonInsertBill.Name = "uiButtonInsertBill";
            this.uiButtonInsertBill.Radius = 32;
            this.uiButtonInsertBill.Size = new System.Drawing.Size(114, 32);
            this.uiButtonInsertBill.TabIndex = 0;
            this.uiButtonInsertBill.Text = "Thêm";
            this.uiButtonInsertBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButtonInsertBill.Click += new System.EventHandler(this.uiButtonInsertSupplier_Click);
            // 
            // uiTitlePanelSupplier
            // 
            this.uiTitlePanelSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiTitlePanelSupplier.Controls.Add(this.uiPanelInformationBill);
            this.uiTitlePanelSupplier.Controls.Add(this.uiPanelButton);
            this.uiTitlePanelSupplier.Controls.Add(this.uiPanelSearch);
            this.uiTitlePanelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTitlePanelSupplier.Location = new System.Drawing.Point(598, 2);
            this.uiTitlePanelSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanelSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanelSupplier.Name = "uiTitlePanelSupplier";
            this.uiTitlePanelSupplier.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.uiTitlePanelSupplier.Radius = 20;
            this.uiTitlePanelSupplier.ShowText = false;
            this.uiTitlePanelSupplier.Size = new System.Drawing.Size(603, 543);
            this.uiTitlePanelSupplier.TabIndex = 8;
            this.uiTitlePanelSupplier.Text = "Nhà Cung Cấp";
            this.uiTitlePanelSupplier.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_ManagerBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 545);
            this.Controls.Add(this.uiTitlePanelSupplier);
            this.Controls.Add(this.uiPanel1);
            this.Name = "Form_ManagerBill";
            this.Text = "Form_ManagerBill";
            this.Load += new System.EventHandler(this.Form_ManagerBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listbill)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanelSearch.ResumeLayout(false);
            this.uiPanelSearch.PerformLayout();
            this.uiPanelInformationBill.ResumeLayout(false);
            this.uiPanelInformationBill.PerformLayout();
            this.uiPanelButton.ResumeLayout(false);
            this.uiTitlePanelSupplier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgv_listbill;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cbb_selectTypeBill;
        private Sunny.UI.UIPanel uiPanelSearch;
        private Sunny.UI.UISymbolLabel uiSymbolLabelSearch;
        private Sunny.UI.UILabel uiLabelSearchTerm;
        private Sunny.UI.UITextBox uiTextBoxSearchTerm;
        private Sunny.UI.UIPanel uiPanelInformationBill;
        private Sunny.UI.UISymbolLabel uiSymbolLabelInformation;
        private Sunny.UI.UILabel lbl_typeBill;
        private Sunny.UI.UILabel lbl_idBill;
        private Sunny.UI.UITextBox txt_idSupOrCus;
        private Sunny.UI.UILabel lbl_idSupOrCus;
        private Sunny.UI.UIPanel uiPanelButton;
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
        private Sunny.UI.UITitlePanel uiTitlePanelSupplier;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}