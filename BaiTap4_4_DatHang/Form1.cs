namespace BaiTap4_4_DatHang
{
    public partial class frmFastFood : Form
    {
        public frmFastFood()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa sạch danh sách đã chọn
            lstOrder.Items.Clear();
            // Đặt lại tổng tiền về 0
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn món trong Menu chưa
            if (lstMenu.SelectedItem != null)
            {
                // Thêm món đang chọn vào ListBox bên phải
                lstOrder.Items.Add(lstMenu.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn từ Menu!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmFastFood_Load(object sender, EventArgs e)
        {
            // Nạp danh sách món ăn kèm giá tiền vào ListBox
            lstMenu.Items.Add("Hamburger - 50000");
            lstMenu.Items.Add("Pizza - 80000");
            lstMenu.Items.Add("Fried Chicken - 60000");
            lstMenu.Items.Add("Coca Cola - 15000");
            lstMenu.Items.Add("Khoai tây chiên - 25000");
            lstMenu.Items.Add("Trà sữa - 30000");
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double tongTien = 0;

            // Duyệt qua từng món trong danh sách đã chọn
            foreach (var item in lstOrder.Items)
            {
                // Tách chuỗi để lấy phần giá tiền (ví dụ: "Hamburger - 50000" -> lấy "50000")
                string[] parts = item.ToString().Split('-');
                if (parts.Length == 2)
                {
                    // Chuyển đổi phần giá tiền sang số và cộng dồn
                    tongTien += double.Parse(parts[1].Trim());
                }
            }

            // Hiển thị tổng tiền lên Label, định dạng có dấu phẩy ngăn cách nghìn
            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
        }
    }
}
