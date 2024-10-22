namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.HomeViews
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_header = new System.Windows.Forms.Panel();
            this.uiLabel_header = new Sunny.UI.UILabel();
            this.btnHamburger_menu = new Sunny.UI.UIImageButton();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.uiSBtnHome = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonTypeProdcut = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonManagerSupplier = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonCustomer = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonProduct = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonRevenue = new Sunny.UI.UISymbolButton();
            this.uiPanel_Body = new Sunny.UI.UIPanel();
            this.uiSymbolButtonBill = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonDetailBill = new Sunny.UI.UISymbolButton();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburger_menu)).BeginInit();
            this.flowLayoutPanel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_header.Controls.Add(this.uiLabel_header);
            this.panel_header.Controls.Add(this.btnHamburger_menu);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1478, 50);
            this.panel_header.TabIndex = 1;
            // 
            // uiLabel_header
            // 
            this.uiLabel_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uiLabel_header.AutoSize = true;
            this.uiLabel_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel_header.Location = new System.Drawing.Point(710, 4);
            this.uiLabel_header.Name = "uiLabel_header";
            this.uiLabel_header.Size = new System.Drawing.Size(165, 52);
            this.uiLabel_header.TabIndex = 1;
            this.uiLabel_header.Text = "Header";
            // 
            // btnHamburger_menu
            // 
            this.btnHamburger_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHamburger_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHamburger_menu.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Hamburger_menu_01;
            this.btnHamburger_menu.Location = new System.Drawing.Point(43, -1);
            this.btnHamburger_menu.Name = "btnHamburger_menu";
            this.btnHamburger_menu.Size = new System.Drawing.Size(100, 57);
            this.btnHamburger_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHamburger_menu.TabIndex = 0;
            this.btnHamburger_menu.TabStop = false;
            this.btnHamburger_menu.Text = null;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 1094);
            this.panel_footer.Margin = new System.Windows.Forms.Padding(5);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1478, 50);
            this.panel_footer.TabIndex = 2;
            // 
            // flowLayoutPanel_Menu
            // 
            this.flowLayoutPanel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSBtnHome);
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButtonTypeProdcut);
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButtonManagerSupplier);
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButtonCustomer);
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButtonProduct);
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButtonBill);
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButtonDetailBill);
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButtonRevenue);
            this.flowLayoutPanel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Menu.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel_Menu.Name = "flowLayoutPanel_Menu";
            this.flowLayoutPanel_Menu.Size = new System.Drawing.Size(200, 1044);
            this.flowLayoutPanel_Menu.TabIndex = 3;
            // 
            // uiSBtnHome
            // 
            this.uiSBtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSBtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSBtnHome.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSBtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSBtnHome.Location = new System.Drawing.Point(3, 3);
            this.uiSBtnHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSBtnHome.Name = "uiSBtnHome";
            this.uiSBtnHome.Radius = 20;
            this.uiSBtnHome.Size = new System.Drawing.Size(190, 50);
            this.uiSBtnHome.TabIndex = 0;
            this.uiSBtnHome.Text = "Home";
            this.uiSBtnHome.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButtonTypeProdcut
            // 
            this.uiSymbolButtonTypeProdcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonTypeProdcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonTypeProdcut.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButtonTypeProdcut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButtonTypeProdcut.Location = new System.Drawing.Point(3, 59);
            this.uiSymbolButtonTypeProdcut.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonTypeProdcut.Name = "uiSymbolButtonTypeProdcut";
            this.uiSymbolButtonTypeProdcut.Radius = 20;
            this.uiSymbolButtonTypeProdcut.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButtonTypeProdcut.TabIndex = 0;
            this.uiSymbolButtonTypeProdcut.Text = "Loại sản phẩm";
            this.uiSymbolButtonTypeProdcut.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonTypeProdcut.Click += new System.EventHandler(this.btnTypeProdcut_Click);
            // 
            // uiSymbolButtonManagerSupplier
            // 
            this.uiSymbolButtonManagerSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonManagerSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonManagerSupplier.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButtonManagerSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButtonManagerSupplier.Location = new System.Drawing.Point(3, 115);
            this.uiSymbolButtonManagerSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonManagerSupplier.Name = "uiSymbolButtonManagerSupplier";
            this.uiSymbolButtonManagerSupplier.Radius = 20;
            this.uiSymbolButtonManagerSupplier.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButtonManagerSupplier.TabIndex = 0;
            this.uiSymbolButtonManagerSupplier.Text = "Nhà cung cấp";
            this.uiSymbolButtonManagerSupplier.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonManagerSupplier.Click += new System.EventHandler(this.btnManagerSupplier_Click);
            // 
            // uiSymbolButtonCustomer
            // 
            this.uiSymbolButtonCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonCustomer.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButtonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButtonCustomer.Location = new System.Drawing.Point(3, 171);
            this.uiSymbolButtonCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonCustomer.Name = "uiSymbolButtonCustomer";
            this.uiSymbolButtonCustomer.Radius = 20;
            this.uiSymbolButtonCustomer.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButtonCustomer.TabIndex = 0;
            this.uiSymbolButtonCustomer.Text = "Khánh Hàng";
            this.uiSymbolButtonCustomer.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonCustomer.Click += new System.EventHandler(this.uiSBtnBtnCustomer_Click);
            // 
            // uiSymbolButtonProduct
            // 
            this.uiSymbolButtonProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonProduct.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButtonProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButtonProduct.Location = new System.Drawing.Point(3, 227);
            this.uiSymbolButtonProduct.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonProduct.Name = "uiSymbolButtonProduct";
            this.uiSymbolButtonProduct.Radius = 20;
            this.uiSymbolButtonProduct.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButtonProduct.TabIndex = 0;
            this.uiSymbolButtonProduct.Text = "Sản Phẩm";
            this.uiSymbolButtonProduct.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonProduct.Click += new System.EventHandler(this.uiSymbolButtonProduct_Click);
            // 
            // uiSymbolButtonRevenue
            // 
            this.uiSymbolButtonRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonRevenue.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButtonRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButtonRevenue.Location = new System.Drawing.Point(3, 395);
            this.uiSymbolButtonRevenue.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonRevenue.Name = "uiSymbolButtonRevenue";
            this.uiSymbolButtonRevenue.Radius = 20;
            this.uiSymbolButtonRevenue.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButtonRevenue.TabIndex = 0;
            this.uiSymbolButtonRevenue.Text = "Doanh thu";
            this.uiSymbolButtonRevenue.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonRevenue.Click += new System.EventHandler(this.uiSymbolButtonRevenue_Click);
            // 
            // uiPanel_Body
            // 
            this.uiPanel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel_Body.Location = new System.Drawing.Point(200, 50);
            this.uiPanel_Body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_Body.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_Body.Name = "uiPanel_Body";
            this.uiPanel_Body.Size = new System.Drawing.Size(1278, 1044);
            this.uiPanel_Body.TabIndex = 4;
            this.uiPanel_Body.Text = "Body";
            this.uiPanel_Body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButtonBill
            // 
            this.uiSymbolButtonBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonBill.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButtonBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButtonBill.Location = new System.Drawing.Point(3, 283);
            this.uiSymbolButtonBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonBill.Name = "uiSymbolButtonBill";
            this.uiSymbolButtonBill.Radius = 20;
            this.uiSymbolButtonBill.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButtonBill.TabIndex = 0;
            this.uiSymbolButtonBill.Text = "Hóa Đơn";
            this.uiSymbolButtonBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonBill.Click += new System.EventHandler(this.uiSymbolButtonBill_Click);
            // 
            // uiSymbolButtonDetailBill
            // 
            this.uiSymbolButtonDetailBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonDetailBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonDetailBill.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButtonDetailBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButtonDetailBill.Location = new System.Drawing.Point(3, 339);
            this.uiSymbolButtonDetailBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonDetailBill.Name = "uiSymbolButtonDetailBill";
            this.uiSymbolButtonDetailBill.Radius = 20;
            this.uiSymbolButtonDetailBill.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButtonDetailBill.TabIndex = 0;
            this.uiSymbolButtonDetailBill.Text = "Chi tiết bill";
            this.uiSymbolButtonDetailBill.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonDetailBill.Click += new System.EventHandler(this.uiSymbolButtonDetailBill_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1144);
            this.Controls.Add(this.uiPanel_Body);
            this.Controls.Add(this.flowLayoutPanel_Menu);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburger_menu)).EndInit();
            this.flowLayoutPanel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private Sunny.UI.UILabel uiLabel_header;
        private Sunny.UI.UIImageButton btnHamburger_menu;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Menu;
        private Sunny.UI.UISymbolButton uiSBtnHome;
        private Sunny.UI.UIPanel uiPanel_Body;
        private Sunny.UI.UISymbolButton uiSymbolButtonTypeProdcut;
        private Sunny.UI.UISymbolButton uiSymbolButtonManagerSupplier;
        private Sunny.UI.UISymbolButton uiSymbolButtonCustomer;
        private Sunny.UI.UISymbolButton uiSymbolButtonRevenue;
        private Sunny.UI.UISymbolButton uiSymbolButtonProduct;
        private Sunny.UI.UISymbolButton uiSymbolButtonBill;
        private Sunny.UI.UISymbolButton uiSymbolButtonDetailBill;
    }
}