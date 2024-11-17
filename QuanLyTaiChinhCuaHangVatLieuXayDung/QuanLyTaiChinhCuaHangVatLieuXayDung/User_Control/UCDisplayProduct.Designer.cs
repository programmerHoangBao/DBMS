namespace QuanLyTaiChinhCuaHangVatLieuXayDung.User_Control
{
    partial class UCDisplayProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelImageProduct = new System.Windows.Forms.Panel();
            this.pictureBoxImageProduct = new System.Windows.Forms.PictureBox();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.labelPrice = new Sunny.UI.UILabel();
            this.labelQunatity = new Sunny.UI.UILabel();
            this.labelNameProduct = new Sunny.UI.UILabel();
            this.uiSymbolButtonTransaction = new Sunny.UI.UISymbolButton();
            this.panelImageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageProduct)).BeginInit();
            this.panelLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImageProduct
            // 
            this.panelImageProduct.Controls.Add(this.pictureBoxImageProduct);
            this.panelImageProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImageProduct.Location = new System.Drawing.Point(0, 0);
            this.panelImageProduct.Name = "panelImageProduct";
            this.panelImageProduct.Size = new System.Drawing.Size(230, 148);
            this.panelImageProduct.TabIndex = 0;
            // 
            // pictureBoxImageProduct
            // 
            this.pictureBoxImageProduct.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBoxImageProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImageProduct.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImageProduct.Name = "pictureBoxImageProduct";
            this.pictureBoxImageProduct.Size = new System.Drawing.Size(230, 148);
            this.pictureBoxImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImageProduct.TabIndex = 0;
            this.pictureBoxImageProduct.TabStop = false;
            // 
            // panelLabel
            // 
            this.panelLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLabel.Controls.Add(this.labelPrice);
            this.panelLabel.Controls.Add(this.labelQunatity);
            this.panelLabel.Controls.Add(this.labelNameProduct);
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabel.Location = new System.Drawing.Point(0, 148);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(230, 99);
            this.panelLabel.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelPrice.Location = new System.Drawing.Point(0, 62);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(226, 23);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "PriceProduct + Unit";
            // 
            // labelQunatity
            // 
            this.labelQunatity.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQunatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQunatity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelQunatity.Location = new System.Drawing.Point(0, 31);
            this.labelQunatity.Name = "labelQunatity";
            this.labelQunatity.Size = new System.Drawing.Size(226, 31);
            this.labelQunatity.TabIndex = 0;
            this.labelQunatity.Text = "Số lượng: ";
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelNameProduct.Location = new System.Drawing.Point(0, 0);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(226, 31);
            this.labelNameProduct.TabIndex = 0;
            this.labelNameProduct.Text = "Tên: ";
            // 
            // uiSymbolButtonTransaction
            // 
            this.uiSymbolButtonTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiSymbolButtonTransaction.FillColor = System.Drawing.Color.Orange;
            this.uiSymbolButtonTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonTransaction.Image = global::QuanLyTaiChinhCuaHangVatLieuXayDung.Properties.Resources.transaction_Export_32;
            this.uiSymbolButtonTransaction.Location = new System.Drawing.Point(0, 247);
            this.uiSymbolButtonTransaction.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonTransaction.Name = "uiSymbolButtonTransaction";
            this.uiSymbolButtonTransaction.Radius = 29;
            this.uiSymbolButtonTransaction.Size = new System.Drawing.Size(230, 40);
            this.uiSymbolButtonTransaction.TabIndex = 0;
            this.uiSymbolButtonTransaction.Text = "Giao dịch";
            this.uiSymbolButtonTransaction.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // UCDisplayProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.uiSymbolButtonTransaction);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.panelImageProduct);
            this.Name = "UCDisplayProduct";
            this.Size = new System.Drawing.Size(230, 290);
            this.Load += new System.EventHandler(this.UCDisplayProduct_Load);
            this.panelImageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageProduct)).EndInit();
            this.panelLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImageProduct;
        private System.Windows.Forms.PictureBox pictureBoxImageProduct;
        private System.Windows.Forms.Panel panelLabel;
        private Sunny.UI.UILabel labelNameProduct;
        private Sunny.UI.UISymbolButton uiSymbolButtonTransaction;
        private Sunny.UI.UILabel labelPrice;
        private Sunny.UI.UILabel labelQunatity;
    }
}
