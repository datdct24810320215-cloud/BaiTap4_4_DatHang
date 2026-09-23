namespace BaiTap4_4_DatHang
{
    partial class frmFastFood
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpMenu = new GroupBox();
            lstMenu = new ListBox();
            grpOrder = new GroupBox();
            lstOrder = new ListBox();
            btnThem = new Button();
            lblTongTien = new Label();
            btnXoa = new Button();
            btnTinhTien = new Button();
            grpMenu.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(lstMenu);
            grpMenu.Location = new Point(12, 12);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(378, 259);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menu";
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(15, 29);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(344, 214);
            lstMenu.TabIndex = 0;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Location = new Point(419, 12);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(369, 259);
            grpOrder.TabIndex = 0;
            grpOrder.TabStop = false;
            grpOrder.Text = "Món đã chọn";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(14, 23);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(338, 214);
            lstOrder.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(72, 294);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 46);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm món >>";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F);
            lblTongTien.Location = new Point(563, 305);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(128, 21);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(233, 294);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 46);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa hết";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(419, 294);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(90, 46);
            btnTinhTien.TabIndex = 1;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // frmFastFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTongTien);
            Controls.Add(btnTinhTien);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(grpOrder);
            Controls.Add(grpMenu);
            Name = "frmFastFood";
            Text = "Fast Food Ordering";
            Load += frmFastFood_Load;
            grpMenu.ResumeLayout(false);
            grpOrder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMenu;
        private ListBox lstMenu;
        private GroupBox grpOrder;
        private ListBox lstOrder;
        private Button btnThem;
        private Label lblTongTien;
        private Button btnXoa;
        private Button btnTinhTien;
    }
}
