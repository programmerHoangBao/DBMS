namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.Home

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
            this.uiImageButton_Hamburger_menu = new Sunny.UI.UIImageButton();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.uiSymbolButton_Home = new Sunny.UI.UISymbolButton();
            this.productButton = new Sunny.UI.UISymbolButton();
            this.expenseSlipButton = new Sunny.UI.UISymbolButton();
            this.uiPanel_Body = new Sunny.UI.UIPanel();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton_Hamburger_menu)).BeginInit();
            this.flowLayoutPanel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_header.Controls.Add(this.uiLabel_header);
            this.panel_header.Controls.Add(this.uiImageButton_Hamburger_menu);
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
            this.uiLabel_header.Size = new System.Drawing.Size(141, 42);
            this.uiLabel_header.TabIndex = 1;
            this.uiLabel_header.Text = "Header";
            // 
            // uiImageButton_Hamburger_menu
            // 
            this.uiImageButton_Hamburger_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton_Hamburger_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiImageButton_Hamburger_menu.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Hamburger_menu_01;
            this.uiImageButton_Hamburger_menu.Location = new System.Drawing.Point(43, -1);
            this.uiImageButton_Hamburger_menu.Name = "uiImageButton_Hamburger_menu";
            this.uiImageButton_Hamburger_menu.Size = new System.Drawing.Size(100, 50);
            this.uiImageButton_Hamburger_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton_Hamburger_menu.TabIndex = 0;
            this.uiImageButton_Hamburger_menu.TabStop = false;
            this.uiImageButton_Hamburger_menu.Text = null;
            this.uiImageButton_Hamburger_menu.Click += new System.EventHandler(this.uiImageButton_Hamburger_menu_Click);
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 1005);
            this.panel_footer.Margin = new System.Windows.Forms.Padding(5);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1478, 50);
            this.panel_footer.TabIndex = 2;
            // 
            // flowLayoutPanel_Menu
            // 
            this.flowLayoutPanel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Menu.Controls.Add(this.uiSymbolButton_Home);
            this.flowLayoutPanel_Menu.Controls.Add(this.productButton);
            this.flowLayoutPanel_Menu.Controls.Add(this.expenseSlipButton);
            this.flowLayoutPanel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Menu.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel_Menu.Name = "flowLayoutPanel_Menu";
            this.flowLayoutPanel_Menu.Size = new System.Drawing.Size(200, 955);
            this.flowLayoutPanel_Menu.TabIndex = 3;
            // 
            // uiSymbolButton_Home
            // 
            this.uiSymbolButton_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton_Home.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.uiSymbolButton_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton_Home.Location = new System.Drawing.Point(3, 3);
            this.uiSymbolButton_Home.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_Home.Name = "uiSymbolButton_Home";
            this.uiSymbolButton_Home.Radius = 20;
            this.uiSymbolButton_Home.Size = new System.Drawing.Size(190, 50);
            this.uiSymbolButton_Home.TabIndex = 0;
            this.uiSymbolButton_Home.Text = "Home";
            this.uiSymbolButton_Home.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton_Home.Click += new System.EventHandler(this.uiSymbolButton_Home_Click);
            // 
            // productButton
            // 
            this.productButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productButton.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.productButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton.Location = new System.Drawing.Point(3, 59);
            this.productButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.productButton.Name = "productButton";
            this.productButton.Radius = 20;
            this.productButton.Size = new System.Drawing.Size(190, 50);
            this.productButton.TabIndex = 1;
            this.productButton.Text = "Products";
            this.productButton.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // expenseSlipButton
            // 
            this.expenseSlipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenseSlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expenseSlipButton.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.expenseSlipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenseSlipButton.Location = new System.Drawing.Point(3, 115);
            this.expenseSlipButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.expenseSlipButton.Name = "expenseSlipButton";
            this.expenseSlipButton.Radius = 20;
            this.expenseSlipButton.Size = new System.Drawing.Size(190, 50);
            this.expenseSlipButton.TabIndex = 2;
            this.expenseSlipButton.Text = "ExpenseSlips";
            this.expenseSlipButton.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiPanel_Body
            // 
            this.uiPanel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel_Body.Location = new System.Drawing.Point(200, 50);
            this.uiPanel_Body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_Body.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_Body.Name = "uiPanel_Body";
            this.uiPanel_Body.Size = new System.Drawing.Size(1278, 955);
            this.uiPanel_Body.TabIndex = 4;
            this.uiPanel_Body.Text = "Body";
            this.uiPanel_Body.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel_Body.Click += new System.EventHandler(this.uiPanel_Body_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1055);
            this.Controls.Add(this.uiPanel_Body);
            this.Controls.Add(this.flowLayoutPanel_Menu);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton_Hamburger_menu)).EndInit();
            this.flowLayoutPanel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private Sunny.UI.UILabel uiLabel_header;
        private Sunny.UI.UIImageButton uiImageButton_Hamburger_menu;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Menu;
        private Sunny.UI.UISymbolButton uiSymbolButton_Home;
        private Sunny.UI.UIPanel uiPanel_Body;
        private Sunny.UI.UISymbolButton productButton;
        private Sunny.UI.UISymbolButton expenseSlipButton;
    }
}