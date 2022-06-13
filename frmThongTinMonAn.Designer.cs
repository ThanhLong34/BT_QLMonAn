namespace BT_QLMonAn
{
    partial class frmThongTinMonAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.cbNhomMonAn = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã món ăn/uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món ăn/uống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhóm món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Location = new System.Drawing.Point(167, 19);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.ReadOnly = true;
            this.txtMaMonAn.Size = new System.Drawing.Size(271, 24);
            this.txtMaMonAn.TabIndex = 0;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(167, 90);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(271, 24);
            this.txtDVT.TabIndex = 2;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(167, 55);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(271, 24);
            this.txtTenMonAn.TabIndex = 1;
            // 
            // nudDonGia
            // 
            this.nudDonGia.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDonGia.Location = new System.Drawing.Point(167, 128);
            this.nudDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDonGia.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(271, 24);
            this.nudDonGia.TabIndex = 3;
            this.nudDonGia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbNhomMonAn
            // 
            this.cbNhomMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhomMonAn.FormattingEnabled = true;
            this.cbNhomMonAn.Location = new System.Drawing.Point(167, 164);
            this.cbNhomMonAn.Name = "cbNhomMonAn";
            this.cbNhomMonAn.Size = new System.Drawing.Size(271, 25);
            this.cbNhomMonAn.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuu.Location = new System.Drawing.Point(167, 204);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 32);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThongTinMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 254);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbNhomMonAn);
            this.Controls.Add(this.nudDonGia);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtMaMonAn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cerebri Sans Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.ComboBox cbNhomMonAn;
        private System.Windows.Forms.Button btnLuu;
    }
}

