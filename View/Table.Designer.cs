﻿namespace Anh_Coffee.View
{
    partial class Table
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
            this.btnTable = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTable.BorderRadius = 8;
            this.btnTable.BorderThickness = 1;
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTable.FillColor = System.Drawing.Color.White;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTable.ForeColor = System.Drawing.Color.Black;
            this.btnTable.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnTable.Image = global::Anh_Coffee.Properties.Resources.tableEmpty;
            this.btnTable.ImageOffset = new System.Drawing.Point(0, 21);
            this.btnTable.ImageSize = new System.Drawing.Size(80, 80);
            this.btnTable.Location = new System.Drawing.Point(0, 0);
            this.btnTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTable.Name = "btnTable";
            this.btnTable.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTable.Size = new System.Drawing.Size(142, 94);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "Bàn 1";
            this.btnTable.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnTable.UseTransparentBackground = true;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnTable);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(142, 94);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btnTable;
    }
}
