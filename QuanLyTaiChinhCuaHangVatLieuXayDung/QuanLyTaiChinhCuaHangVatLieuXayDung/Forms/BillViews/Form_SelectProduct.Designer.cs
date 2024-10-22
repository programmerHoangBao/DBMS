namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.BillViews
{
    partial class Form_SelectProduct
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
            this.lbl_idBill = new Sunny.UI.UILabel();
            this.txt_idBill = new Sunny.UI.UITextBox();
            this.lbl_idProduct = new Sunny.UI.UILabel();
            this.cbb_idProduct = new Sunny.UI.UIComboBox();
            this.lbl_quantity = new Sunny.UI.UILabel();
            this.numeric_quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_selected = new Sunny.UI.UILabel();
            this.listbox_selected = new Sunny.UI.UIListBox();
            this.btt_add = new Sunny.UI.UIButton();
            this.btt_delete = new Sunny.UI.UIButton();
            this.btt_complete = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idBill
            // 
            this.lbl_idBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_idBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_idBill.Location = new System.Drawing.Point(96, 60);
            this.lbl_idBill.Name = "lbl_idBill";
            this.lbl_idBill.Size = new System.Drawing.Size(168, 23);
            this.lbl_idBill.TabIndex = 0;
            this.lbl_idBill.Text = "Mã hóa đơn:";
            // 
            // txt_idBill
            // 
            this.txt_idBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idBill.Enabled = false;
            this.txt_idBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_idBill.Location = new System.Drawing.Point(303, 54);
            this.txt_idBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idBill.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_idBill.Name = "txt_idBill";
            this.txt_idBill.Padding = new System.Windows.Forms.Padding(5);
            this.txt_idBill.ShowText = false;
            this.txt_idBill.Size = new System.Drawing.Size(300, 29);
            this.txt_idBill.TabIndex = 1;
            this.txt_idBill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_idBill.Watermark = "";
            // 
            // lbl_idProduct
            // 
            this.lbl_idProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_idProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_idProduct.Location = new System.Drawing.Point(96, 117);
            this.lbl_idProduct.Name = "lbl_idProduct";
            this.lbl_idProduct.Size = new System.Drawing.Size(168, 23);
            this.lbl_idProduct.TabIndex = 0;
            this.lbl_idProduct.Text = "Mã sản phẩm:";
            // 
            // cbb_idProduct
            // 
            this.cbb_idProduct.DataSource = null;
            this.cbb_idProduct.FillColor = System.Drawing.Color.White;
            this.cbb_idProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_idProduct.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbb_idProduct.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbb_idProduct.Location = new System.Drawing.Point(303, 111);
            this.cbb_idProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_idProduct.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbb_idProduct.Name = "cbb_idProduct";
            this.cbb_idProduct.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbb_idProduct.Size = new System.Drawing.Size(300, 29);
            this.cbb_idProduct.SymbolSize = 24;
            this.cbb_idProduct.TabIndex = 2;
            this.cbb_idProduct.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbb_idProduct.Watermark = "";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_quantity.Location = new System.Drawing.Point(96, 169);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(168, 23);
            this.lbl_quantity.TabIndex = 0;
            this.lbl_quantity.Text = "Số lượng";
            // 
            // numeric_quantity
            // 
            this.numeric_quantity.Location = new System.Drawing.Point(303, 169);
            this.numeric_quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_quantity.Name = "numeric_quantity";
            this.numeric_quantity.Size = new System.Drawing.Size(300, 20);
            this.numeric_quantity.TabIndex = 3;
            this.numeric_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_selected
            // 
            this.lbl_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_selected.Location = new System.Drawing.Point(96, 223);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(168, 46);
            this.lbl_selected.TabIndex = 0;
            this.lbl_selected.Text = "Danh sách đã chọn:";
            // 
            // listbox_selected
            // 
            this.listbox_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listbox_selected.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.listbox_selected.ItemSelectForeColor = System.Drawing.Color.White;
            this.listbox_selected.Location = new System.Drawing.Point(303, 223);
            this.listbox_selected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listbox_selected.MinimumSize = new System.Drawing.Size(1, 1);
            this.listbox_selected.Name = "listbox_selected";
            this.listbox_selected.Padding = new System.Windows.Forms.Padding(2);
            this.listbox_selected.ShowText = false;
            this.listbox_selected.Size = new System.Drawing.Size(300, 129);
            this.listbox_selected.TabIndex = 4;
            this.listbox_selected.Text = "uiListBox1";
            // 
            // btt_add
            // 
            this.btt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btt_add.Location = new System.Drawing.Point(623, 157);
            this.btt_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(100, 35);
            this.btt_add.TabIndex = 5;
            this.btt_add.Text = "Thêm";
            this.btt_add.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btt_delete.Location = new System.Drawing.Point(623, 223);
            this.btt_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(100, 35);
            this.btt_delete.TabIndex = 5;
            this.btt_delete.Text = "Xóa";
            this.btt_delete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // btt_complete
            // 
            this.btt_complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btt_complete.Location = new System.Drawing.Point(401, 388);
            this.btt_complete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btt_complete.Name = "btt_complete";
            this.btt_complete.Size = new System.Drawing.Size(100, 35);
            this.btt_complete.TabIndex = 5;
            this.btt_complete.Text = "Hoàn tất";
            this.btt_complete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btt_complete.Click += new System.EventHandler(this.btt_complete_Click);
            // 
            // Form_SelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btt_complete);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.listbox_selected);
            this.Controls.Add(this.numeric_quantity);
            this.Controls.Add(this.cbb_idProduct);
            this.Controls.Add(this.txt_idBill);
            this.Controls.Add(this.lbl_selected);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_idProduct);
            this.Controls.Add(this.lbl_idBill);
            this.Name = "Form_SelectProduct";
            this.Text = "Form_SelectProduct";
            this.Load += new System.EventHandler(this.Form_SelectProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lbl_idBill;
        private Sunny.UI.UILabel lbl_idProduct;
        private Sunny.UI.UIComboBox cbb_idProduct;
        private Sunny.UI.UILabel lbl_quantity;
        private System.Windows.Forms.NumericUpDown numeric_quantity;
        private Sunny.UI.UILabel lbl_selected;
        private Sunny.UI.UIListBox listbox_selected;
        private Sunny.UI.UIButton btt_add;
        private Sunny.UI.UIButton btt_delete;
        private Sunny.UI.UIButton btt_complete;
        public Sunny.UI.UITextBox txt_idBill;
    }
}