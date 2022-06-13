namespace BT_QLMonAn
{
    partial class frmQuanLyMonAn
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
            this.cbNhomMonAn = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.lvMonAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách món ăn";
            // 
            // cbNhomMonAn
            // 
            this.cbNhomMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhomMonAn.FormattingEnabled = true;
            this.cbNhomMonAn.Location = new System.Drawing.Point(271, 21);
            this.cbNhomMonAn.Name = "cbNhomMonAn";
            this.cbNhomMonAn.Size = new System.Drawing.Size(308, 25);
            this.cbNhomMonAn.TabIndex = 2;
            this.cbNhomMonAn.SelectedValueChanged += new System.EventHandler(this.cbNhomMonAn_SelectedValueChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(271, 69);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(308, 24);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Font = new System.Drawing.Font("Cerebri Sans Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMonAn.Location = new System.Drawing.Point(585, 62);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(53, 35);
            this.btnThemMonAn.TabIndex = 4;
            this.btnThemMonAn.Text = "+";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // lvMonAn
            // 
            this.lvMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMonAn.FullRowSelect = true;
            this.lvMonAn.GridLines = true;
            this.lvMonAn.HideSelection = false;
            this.lvMonAn.Location = new System.Drawing.Point(16, 112);
            this.lvMonAn.Name = "lvMonAn";
            this.lvMonAn.Size = new System.Drawing.Size(622, 213);
            this.lvMonAn.TabIndex = 5;
            this.lvMonAn.UseCompatibleStateImageBehavior = false;
            this.lvMonAn.View = System.Windows.Forms.View.Details;
            this.lvMonAn.DoubleClick += new System.EventHandler(this.lvMonAn_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món ăn";
            this.columnHeader2.Width = 206;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn vị tính";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nhóm";
            this.columnHeader5.Width = 138;
            // 
            // frmQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 337);
            this.Controls.Add(this.lvMonAn);
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbNhomMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cerebri Sans Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý món ăn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNhomMonAn;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.ListView lvMonAn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}