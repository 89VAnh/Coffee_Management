namespace Anh_Coffee.View
{
    partial class frmEditFood
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboFood = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(64, 48);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 25);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Tên món :";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(194, 232);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(225, 114);
            this.txtNote.TabIndex = 2;
            this.txtNote.Text = "";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(64, 249);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(71, 25);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Ghi chú :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(64, 153);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(80, 25);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Số lượng :";
            // 
            // numAmount
            // 
            this.numAmount.AutoRoundedCorners = true;
            this.numAmount.BackColor = System.Drawing.Color.Transparent;
            this.numAmount.BorderRadius = 18;
            this.numAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(194, 153);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(225, 39);
            this.numAmount.TabIndex = 5;
            this.numAmount.UseTransparentBackground = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 23;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(194, 388);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 48);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboFood
            // 
            this.cboFood.BackColor = System.Drawing.Color.Transparent;
            this.cboFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFood.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboFood.ItemHeight = 30;
            this.cboFood.Location = new System.Drawing.Point(194, 48);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(225, 36);
            this.cboFood.TabIndex = 7;
            // 
            // frmEditFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 496);
            this.Controls.Add(this.cboFood);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "frmEditFood";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEditFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.RichTextBox txtNote;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numAmount;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ComboBox cboFood;
    }
}