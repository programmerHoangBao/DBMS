namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.Form_Home
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
            this.btnHome = new Sunny.UI.UISymbolButton();
            this.btnTypeProdcut = new Sunny.UI.UISymbolButton();
            this.uiPanel_Body = new Sunny.UI.UIPanel();
            this.btnManagerSupplier = new Sunny.UI.UISymbolButton();
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
            this.flowLayoutPanel_Menu.Controls.Add(this.btnHome);
            this.flowLayoutPanel_Menu.Controls.Add(this.btnTypeProdcut);
            this.flowLayoutPanel_Menu.Controls.Add(this.btnManagerSupplier);
            this.flowLayoutPanel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Menu.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel_Menu.Name = "flowLayoutPanel_Menu";
            this.flowLayoutPanel_Menu.Size = new System.Drawing.Size(200, 1044);
            this.flowLayoutPanel_Menu.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHome.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Radius = 20;
            this.btnHome.Size = new System.Drawing.Size(190, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnTypeProdcut
            // 
            this.btnTypeProdcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeProdcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTypeProdcut.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.btnTypeProdcut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypeProdcut.Location = new System.Drawing.Point(3, 59);
            this.btnTypeProdcut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTypeProdcut.Name = "btnTypeProdcut";
            this.btnTypeProdcut.Radius = 20;
            this.btnTypeProdcut.Size = new System.Drawing.Size(190, 50);
            this.btnTypeProdcut.TabIndex = 0;
            this.btnTypeProdcut.Text = "Loại sản phẩm";
            this.btnTypeProdcut.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTypeProdcut.Click += new System.EventHandler(this.btnTypeProdcut_Click);
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
            // btnManagerSupplier
            // 
            this.btnManagerSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagerSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnManagerSupplier.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.Home_01;
            this.btnManagerSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagerSupplier.Location = new System.Drawing.Point(3, 115);
            this.btnManagerSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnManagerSupplier.Name = "btnManagerSupplier";
            this.btnManagerSupplier.Radius = 20;
            this.btnManagerSupplier.Size = new System.Drawing.Size(190, 50);
            this.btnManagerSupplier.TabIndex = 0;
            this.btnManagerSupplier.Text = "Nhà cung cấp";
            this.btnManagerSupplier.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnManagerSupplier.Click += new System.EventHandler(this.btnManagerSupplier_Click);
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
        private Sunny.UI.UISymbolButton btnHome;
        private Sunny.UI.UIPanel uiPanel_Body;
        private Sunny.UI.UISymbolButton btnTypeProdcut;
        private Sunny.UI.UISymbolButton btnManagerSupplier;
    }
}