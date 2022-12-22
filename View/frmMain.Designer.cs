namespace Anh_Coffee.View
{
    partial class frmMain
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangeTable = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.cboDiscountType = new System.Windows.Forms.ComboBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cboChangeTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Margin = new System.Windows.Forms.Padding(10);
            this.flpTable.Name = "flpTable";
            this.flpTable.Padding = new System.Windows.Forms.Padding(20);
            this.flpTable.Size = new System.Drawing.Size(1224, 433);
            this.flpTable.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.SlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(38, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.BorderRadius = 10;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.SlateBlue;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(214, 469);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 33);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xoá món";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBill.Location = new System.Drawing.Point(37, 521);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(906, 240);
            this.dgvBill.TabIndex = 4;
            this.dgvBill.DataSourceChanged += new System.EventHandler(this.dgvBill_DataSourceChanged);
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BorderRadius = 20;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(969, 700);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(241, 46);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Thanh toán";
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeTable.AutoRoundedCorners = true;
            this.btnChangeTable.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeTable.BorderRadius = 17;
            this.btnChangeTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeTable.FillColor = System.Drawing.Color.Cyan;
            this.btnChangeTable.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnChangeTable.ForeColor = System.Drawing.Color.White;
            this.btnChangeTable.Location = new System.Drawing.Point(1041, 466);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(169, 36);
            this.btnChangeTable.TabIndex = 9;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseTransparentBackground = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(965, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giảm giá :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(969, 595);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(174, 30);
            this.txtDiscount.TabIndex = 6;
            // 
            // cboDiscountType
            // 
            this.cboDiscountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDiscountType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiscountType.FormattingEnabled = true;
            this.cboDiscountType.Items.AddRange(new object[] {
            "%",
            "k ₫"});
            this.cboDiscountType.Location = new System.Drawing.Point(1149, 595);
            this.cboDiscountType.Name = "cboDiscountType";
            this.cboDiscountType.Size = new System.Drawing.Size(61, 31);
            this.cboDiscountType.Sorted = true;
            this.cboDiscountType.TabIndex = 5;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(969, 650);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(241, 30);
            this.txtTotalPrice.TabIndex = 7;
            // 
            // cboChangeTable
            // 
            this.cboChangeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChangeTable.AutoRoundedCorners = true;
            this.cboChangeTable.BackColor = System.Drawing.Color.Transparent;
            this.cboChangeTable.BorderRadius = 17;
            this.cboChangeTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChangeTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChangeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChangeTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboChangeTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboChangeTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChangeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChangeTable.ItemHeight = 30;
            this.cboChangeTable.Location = new System.Drawing.Point(808, 466);
            this.cboChangeTable.Name = "cboChangeTable";
            this.cboChangeTable.Size = new System.Drawing.Size(227, 36);
            this.cboChangeTable.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(392, 469);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ID";
            this.Column6.HeaderText = "ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 125;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên món";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Amount";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Total";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Note";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 773);
            this.Controls.Add(this.cboChangeTable);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.cboDiscountType);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeTable);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.flpTable);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private System.Windows.Forms.DataGridView dgvBill;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnChangeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.ComboBox cboDiscountType;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cboChangeTable;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}